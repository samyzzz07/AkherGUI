using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class ReturnsControl : UserControl
{
    private ReturnsDB db = new ReturnsDB();

    public ReturnsControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvReturns);
        Load += ReturnsControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }
    

    private void ReturnsControl_Load(object sender, EventArgs e)
    {
        LoadReturns();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadReturns);
            return;
        }

        LoadReturns();
    }

    private void LoadReturns()
    {
        dgvReturns.DataSource = db.GetPendingReturns();
        ApplyGridConfiguration();
        EnsureProcessColumn();
        ApplyDaysOverdueFormatting();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvReturns.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("RentalID", "Rental ID");
        SetHeaderIfExists("CustomerName", "Customer");
        SetHeaderIfExists("VehicleModel", "Vehicle");
        SetHeaderIfExists("LicensePlate", "Plate");
        SetHeaderIfExists("StartDate", "Start");
        SetHeaderIfExists("EndDate", "Due");
        SetHeaderIfExists("DaysOverdue", "Days Overdue");
    }

    private void EnsureProcessColumn()
    {
        // Action buttons are now outside the grid
    }

    private void ApplyDaysOverdueFormatting()
    {
        if (!dgvReturns.Columns.Contains("DaysOverdue"))
        {
            return;
        }

        foreach (DataGridViewRow row in dgvReturns.Rows)
        {
            var value = row.Cells["DaysOverdue"].Value;
            if (value == null || !int.TryParse(value.ToString(), out var daysOverdue))
            {
                continue;
            }

            if (daysOverdue > 0)
            {
                row.Cells["DaysOverdue"].Style.ForeColor = AppTheme.BadgeRedText;
                row.Cells["DaysOverdue"].Style.Font = new Font(dgvReturns.Font, FontStyle.Bold);
            }
            else
            {
                row.Cells["DaysOverdue"].Style.ForeColor = AppTheme.BadgeGreenText;
                row.Cells["DaysOverdue"].Style.Font = new Font(dgvReturns.Font, FontStyle.Bold);
            }
        }
    }

    private bool TryGetCellText(DataGridViewRow row, string columnName, out string value)
    {
        value = string.Empty;

        if (!dgvReturns.Columns.Contains(columnName))
        {
            return false;
        }

        var cellValue = row.Cells[columnName].Value;
        if (cellValue == null)
        {
            return false;
        }

        value = cellValue.ToString() ?? string.Empty;
        return value.Length > 0;
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvReturns.Columns.Contains(columnName))
        {
            dgvReturns.Columns[columnName].HeaderText = headerText;
        }
    }

    private void dgvReturns_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        var hasSelection = dgvReturns.SelectedRows.Count > 0;
        if (btnProcess != null)
        {
            btnProcess.Enabled = hasSelection;
        }
    }

    private void btnProcess_Click(object sender, EventArgs e)
    {
        if (dgvReturns.SelectedRows.Count == 0)
        {
            return;
        }

        var row = dgvReturns.SelectedRows[0];
        ProcessReturn(row);
    }

    private void ProcessReturn(DataGridViewRow row)
    {
        if (!TryGetInt(row, "RentalID", out var rentalID))
        {
            MessageBox.Show(
                "Selected row is missing RentalID.",
                "Process Return",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var hasVehicleID = TryGetInt(row, "VehicleID", out var vehicleID);
        var hasPaymentID = TryGetInt(row, "PaymentID", out var paymentID);

        if (!hasVehicleID || !hasPaymentID)
        {
            try
            {
                var details = db.GetRentalDetails(rentalID);
                if (details.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Could not find rental details.",
                        "Process Return",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var detailRow = details.Rows[0];
                if (!hasVehicleID && !int.TryParse(detailRow["VehicleID"]?.ToString() ?? string.Empty, out vehicleID))
                {
                    MessageBox.Show(
                        "Could not retrieve VehicleID.",
                        "Process Return",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!hasPaymentID && !int.TryParse(detailRow["PaymentID"]?.ToString() ?? string.Empty, out paymentID))
                {
                    MessageBox.Show(
                        "Could not retrieve PaymentID.",
                        "Process Return",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error retrieving rental details: {ex.Message}",
                    "Process Return",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        var customerName = TryGetCellText(row, "CustomerName", out var customerText) ? customerText : string.Empty;
        var vehicleModel = TryGetCellText(row, "VehicleModel", out var vehicleText) ? vehicleText : string.Empty;

        var result = MessageBox.Show(
            $"Confirm return for {customerName} - {vehicleModel}?",
            "Confirm Return",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            db.ConfirmReturn(rentalID, vehicleID, paymentID);
            MessageBox.Show(
                "Return processed successfully",
                "Returns",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void dgvReturns_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        UpdateActionButtonsState();
    }

    private static bool TryGetInt(DataGridViewRow row, string columnName, out int value)
    {
        value = 0;
        if (!row.DataGridView!.Columns.Contains(columnName))
        {
            return false;
        }

        var raw = row.Cells[columnName].Value;
        return raw != null && int.TryParse(raw.ToString(), out value);
    }
}
