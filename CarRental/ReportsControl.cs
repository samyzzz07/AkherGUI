using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class ReportsControl : UserControl
{
    private ReportsDB db = new ReportsDB();
    private string currentTab = "Revenue";

    public ReportsControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvReport);
        Load += ReportsControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }

    private void ReportsControl_Load(object sender, EventArgs e)
    {
        if (cmbMonth.Items.Count > 0)
        {
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        if (cmbYear.Items.Contains("2026"))
        {
            cmbYear.SelectedItem = "2026";
        }
        else if (cmbYear.Items.Count > 0)
        {
            cmbYear.SelectedIndex = 0;
        }

        SetActiveTab("Revenue");
        LoadRevenue();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)ReloadCurrentTab);
            return;
        }

        ReloadCurrentTab();
    }

    private void btnTabRevenue_Click(object sender, EventArgs e)
    {
        SetActiveTab("Revenue");
        LoadRevenue();
    }

    private void btnTabFleet_Click(object sender, EventArgs e)
    {
        SetActiveTab("Fleet");
        LoadFleet();
    }

    private void btnTabOverdue_Click(object sender, EventArgs e)
    {
        SetActiveTab("Overdue");
        LoadOverdue();
    }

    private void btnTabDaily_Click(object sender, EventArgs e)
    {
        SetActiveTab("Daily");
        LoadDaily();
    }

    private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadCurrentTab();
    }

    private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadCurrentTab();
    }

    private void ReloadCurrentTab()
    {
        switch (currentTab)
        {
            case "Revenue":
                LoadRevenue();
                break;
            case "Fleet":
                LoadFleet();
                break;
            case "Overdue":
                LoadOverdue();
                break;
            case "Daily":
                LoadDaily();
                break;
        }
    }

    private void SetActiveTab(string tab)
    {
        currentTab = tab;

        StyleTabButton(btnTabRevenue, tab == "Revenue");
        StyleTabButton(btnTabFleet, tab == "Fleet");
        StyleTabButton(btnTabOverdue, tab == "Overdue");
        StyleTabButton(btnTabDaily, tab == "Daily");

        pnlTabs.Invalidate();
    }

    private static void StyleTabButton(Button button, bool isActive)
    {
        button.ForeColor = isActive ? AppTheme.Accent : AppTheme.TextSecondary;
        button.Font = new Font("Segoe UI", 9F, isActive ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
    }

    private void LoadRevenue()
    {
        int month = cmbMonth.SelectedIndex + 1;
        int year = int.Parse(cmbYear.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString());

        dgvReport.DataSource = db.GetRevenueByType(month, year);
        ApplyRevenueGrid();
        UpdateRevenueStats();
    }

    private void ApplyRevenueGrid()
    {
        if (dgvReport.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("VehicleType", "Type");
        SetHeaderIfExists("TotalRentals", "Trips");
        SetHeaderIfExists("TotalRevenue", "Revenue");
        HideColumnIfExists("Month");
        HideColumnIfExists("Year");
    }

    private void UpdateRevenueStats()
    {
        int totalTrips = 0;
        decimal totalRevenue = 0;

        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "TotalRentals", out var tripsText) && int.TryParse(tripsText, out var trips))
            {
                totalTrips += trips;
            }

            if (TryGetCellText(row, "TotalRevenue", out var revenueText) && decimal.TryParse(revenueText, out var revenue))
            {
                totalRevenue += revenue;
            }
        }

        lblStat1Val.Text = totalTrips.ToString("N0");
        lblStat1Label.Text = "Total Trips";
        lblStat2Val.Text = "$" + totalRevenue.ToString("N0");
        lblStat2Label.Text = "Total Revenue";
        lblStat3Val.Text = cmbMonth.SelectedItem?.ToString() + " " + cmbYear.SelectedItem?.ToString();
        lblStat3Label.Text = "Selected Period";
    }

    private void LoadFleet()
    {
        dgvReport.DataSource = db.GetFleetUtilization();
        ApplyFleetGrid();
        lblStat1Val.Text = dgvReport.Rows.Count.ToString("N0");
        lblStat1Label.Text = "Vehicles";
        lblStat2Val.Text = CountRowsByStatus("Available").ToString("N0");
        lblStat2Label.Text = "Available";
        lblStat3Val.Text = CountRowsByStatus("Rented").ToString("N0");
        lblStat3Label.Text = "Rented";
    }

    private void ApplyFleetGrid()
    {
        if (dgvReport.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("VehicleID", "ID");
        SetHeaderIfExists("Family", "Model");
        SetHeaderIfExists("VType", "Type");
        SetHeaderIfExists("VStatus", "Status");
        SetHeaderIfExists("Mileage", "Mileage");
        HideColumnIfExists("Colour");
        HideColumnIfExists("OriginCountry");
        HideColumnIfExists("LicensePlate");
        HideColumnIfExists("DailyRate");
        HideColumnIfExists("VYear");
    }

    private int CountRowsByStatus(string status)
    {
        var count = 0;
        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "VStatus", out var value) && string.Equals(value, status, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        return count;
    }

    private void LoadOverdue()
    {
        dgvReport.DataSource = db.GetOverdueReport();
        ApplyOverdueGrid();
        lblStat1Val.Text = dgvReport.Rows.Count.ToString("N0");
        lblStat1Label.Text = "Overdue Rentals";
        lblStat2Val.Text = CountOverdueDays().ToString("N0");
        lblStat2Label.Text = "Total Late Days";
        // Force USD dollar sign instead of relying on system currency (was showing AED)
        lblStat3Val.Text = "$" + CountEstimatedLateFees().ToString("N0");
        lblStat3Label.Text = "Estimated Fees";
    }

    private void ApplyOverdueGrid()
    {
        if (dgvReport.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("CustomerName", "Customer");
        SetHeaderIfExists("VehicleModel", "Vehicle");
        SetHeaderIfExists("EndDate", "Was Due");
        SetHeaderIfExists("DaysLate", "Days Late");
        SetHeaderIfExists("EstimatedLateFee", "Late Fee");

        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "DaysLate", out var daysLateText) && int.TryParse(daysLateText, out var daysLate) && daysLate > 0)
            {
                row.DefaultCellStyle.ForeColor = AppTheme.BadgeRedText;
                row.DefaultCellStyle.Font = new Font(dgvReport.Font, FontStyle.Bold);
            }
        }
    }

    private int CountOverdueDays()
    {
        var total = 0;
        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "DaysLate", out var daysLateText) && int.TryParse(daysLateText, out var daysLate))
            {
                total += daysLate;
            }
        }

        return total;
    }

    private decimal CountEstimatedLateFees()
    {
        var total = 0m;
        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "EstimatedLateFee", out var feeText) && decimal.TryParse(feeText, out var fee))
            {
                total += fee;
            }
        }

        return total;
    }

    private void LoadDaily()
    {
        dgvReport.DataSource = db.GetDailyRentalReport();
        ApplyDailyGrid();
        lblStat1Val.Text = dgvReport.Rows.Count.ToString("N0");
        lblStat1Label.Text = "Rows";
        lblStat2Val.Text = GetDailyRentalsTotal().ToString("N0");
        lblStat2Label.Text = "Rentals";
        lblStat3Val.Text = cmbMonth.SelectedItem?.ToString() ?? string.Empty;
        lblStat3Label.Text = "Current Month";
    }

    private void ApplyDailyGrid()
    {
        if (dgvReport.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("StartDate", "Date");
        SetHeaderIfExists("TotalRentals", "Rentals");
    }

    private int GetDailyRentalsTotal()
    {
        var total = 0;
        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            if (TryGetCellText(row, "TotalRentals", out var rentalsText) && int.TryParse(rentalsText, out var rentals))
            {
                total += rentals;
            }
        }

        return total;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        using var saveFileDialog = new SaveFileDialog
        {
            Filter = "CSV|*.csv",
            FileName = $"{currentTab}_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
        };

        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        var builder = new StringBuilder();
        var visibleColumns = new System.Collections.Generic.List<DataGridViewColumn>();

        foreach (DataGridViewColumn column in dgvReport.Columns)
        {
            if (column.Visible)
            {
                visibleColumns.Add(column);
            }
        }

        for (var i = 0; i < visibleColumns.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(',');
            }

            builder.Append(EscapeCsv(visibleColumns[i].HeaderText));
        }
        builder.AppendLine();

        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            for (var i = 0; i < visibleColumns.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append(',');
                }

                var value = row.Cells[visibleColumns[i].Index].Value?.ToString() ?? string.Empty;
                builder.Append(EscapeCsv(value));
            }

            builder.AppendLine();
        }

        File.WriteAllText(saveFileDialog.FileName, builder.ToString(), Encoding.UTF8);
        MessageBox.Show("CSV exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static string EscapeCsv(string value)
    {
        if (value.Contains('"') || value.Contains(',') || value.Contains('\n') || value.Contains('\r'))
        {
            return '"' + value.Replace("\"", "\"\"") + '"';
        }

        return value;
    }

    private void SetActiveTabButtonStyle()
    {
        btnTabRevenue.ForeColor = currentTab == "Revenue" ? AppTheme.Accent : AppTheme.TextSecondary;
        btnTabFleet.ForeColor = currentTab == "Fleet" ? AppTheme.Accent : AppTheme.TextSecondary;
        btnTabOverdue.ForeColor = currentTab == "Overdue" ? AppTheme.Accent : AppTheme.TextSecondary;
        btnTabDaily.ForeColor = currentTab == "Daily" ? AppTheme.Accent : AppTheme.TextSecondary;
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvReport.Columns.Contains(columnName))
        {
            dgvReport.Columns[columnName].HeaderText = headerText;
        }
    }

    private void HideColumnIfExists(string columnName)
    {
        if (dgvReport.Columns.Contains(columnName))
        {
            dgvReport.Columns[columnName].Visible = false;
        }
    }

    private bool TryGetCellText(DataGridViewRow row, string columnName, out string value)
    {
        value = string.Empty;

        if (!dgvReport.Columns.Contains(columnName))
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

    private void pnlTabs_Paint(object sender, PaintEventArgs e)
    {
        var activeButton = currentTab switch
        {
            "Fleet" => btnTabFleet,
            "Overdue" => btnTabOverdue,
            "Daily" => btnTabDaily,
            _ => btnTabRevenue
        };

        var y = pnlTabs.Height - 2;
        using var pen = new Pen(AppTheme.Accent, 2);
        e.Graphics.DrawLine(pen, activeButton.Left + 8, y, activeButton.Right - 8, y);
    }
}
