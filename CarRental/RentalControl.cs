using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;

namespace CarRental;

public partial class RentalControl : UserControl
{
    private RentalsDB db = new RentalsDB();
    private int selectedVehicleID = -1;
    private int selectedDailyRate = 0;

    public RentalControl()
    {
        InitializeComponent();
        ConfigureDatePickers();
        AppTheme.StyleDataGridView(dgvAvailable);
        Load += RentalControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }
    

    private void RentalControl_Load(object sender, EventArgs e)
    {
        ResetRentalSelection();
        LoadAvailableVehicles();
        UpdateSummary();
    }

    private void ConfigureDatePickers()
    {
        dtpStart.MinDate = DateTime.Today;
        if (dtpStart.Value.Date < dtpStart.MinDate.Date)
        {
            dtpStart.Value = dtpStart.MinDate;
        }

        dtpEnd.MinDate = dtpStart.Value.Date;
        if (dtpEnd.Value.Date < dtpEnd.MinDate.Date)
        {
            dtpEnd.Value = dtpEnd.MinDate;
        }
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)RefreshAvailableVehicles);
            return;
        }

        RefreshAvailableVehicles();
    }

    private void LoadAvailableVehicles()
    {
        dgvAvailable.DataSource = db.GetAvailableVehicles();
        ApplyGridConfiguration();
        EnsureSelectColumn();
    }

    private void RefreshAvailableVehicles()
    {
        ResetRentalSelection();
        LoadAvailableVehicles();
        UpdateSummary();
    }

    private void ResetRentalSelection()
    {
        selectedVehicleID = -1;
        selectedDailyRate = 0;
        dtpStart.Value = DateTime.Today;
        ConfigureDatePickers();
        dtpEnd.Value = DateTime.Today.AddDays(1);

        foreach (DataGridViewRow row in dgvAvailable.Rows)
        {
            row.DefaultCellStyle.BackColor = AppTheme.CardBg;
        }
    }

    private void ApplyGridConfiguration()
    {
        if (dgvAvailable.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("VehicleID", "ID");
        SetHeaderIfExists("Family", "Model");
        SetHeaderIfExists("VType", "Type");
        SetHeaderIfExists("VYear", "Year");
        SetHeaderIfExists("DailyRate", "Rate/day");
        SetHeaderIfExists("Mileage", "Mileage");
    }

    private void EnsureSelectColumn()
    {
        // Action buttons are now outside the grid
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvAvailable.Columns.Contains(columnName))
        {
            dgvAvailable.Columns[columnName].HeaderText = headerText;
        }
    }

    private void btnLookup_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtSSN.Text.Trim(), out var ssn))
        {
            MessageBox.Show(
                "Please enter a valid SSN.",
                "Lookup",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        DataTable dt = db.GetCustomerBySSN(ssn);
        if (dt.Rows.Count > 0)
        {
            txtCustomerName.Text = dt.Rows[0]["CName"]?.ToString();
            UpdateSummary();
        }
        else
        {
            txtCustomerName.Clear();
            MessageBox.Show("Customer not found", "Lookup", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void dgvAvailable_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        var hasSelection = dgvAvailable.SelectedRows.Count > 0;
        if (btnSelect != null)
        {
            btnSelect.Enabled = hasSelection;
        }
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        if (dgvAvailable.SelectedRows.Count == 0)
        {
            return;
        }

        var row = dgvAvailable.SelectedRows[0];
        if (row.Cells["VehicleID"].Value == null || row.Cells["DailyRate"].Value == null)
        {
            return;
        }

        selectedVehicleID = Convert.ToInt32(row.Cells["VehicleID"].Value);
        selectedDailyRate = Convert.ToInt32(row.Cells["DailyRate"].Value);

        foreach (DataGridViewRow gridRow in dgvAvailable.Rows)
        {
            gridRow.DefaultCellStyle.BackColor = AppTheme.CardBg;
        }

        row.DefaultCellStyle.BackColor = AppTheme.SidebarActiveBg;
        UpdateSummary();
    }

    private void dgvAvailable_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        dgvAvailable.ClearSelection();
        dgvAvailable.Rows[e.RowIndex].Selected = true;
        UpdateActionButtonsState();
    }

    private void dtpStart_ValueChanged(object sender, EventArgs e)
    {
        ConfigureDatePickers();
        UpdateSummary();
    }

    private void dtpEnd_ValueChanged(object sender, EventArgs e)
    {
        if (dtpEnd.Value.Date < dtpStart.Value.Date)
        {
            dtpEnd.Value = dtpStart.Value.Date;
        }

        UpdateSummary();
    }

    private void UpdateSummary()
    {
        if (selectedVehicleID == -1)
        {
            lblVehicleVal.Text = "No vehicle selected";
            lblDurationVal.Text = "0 days";
            lblRateVal.Text = "$0";
            lblSubtotalVal.Text = "$0";
            lblTaxVal.Text = "$0";
            lblTotal.Text = "$0";
            return;
        }

        int days = (dtpEnd.Value.Date - dtpStart.Value.Date).Days;
        if (days <= 0)
        {
            lblVehicleVal.Text = "Selected vehicle";
            lblDurationVal.Text = "Invalid";
            lblRateVal.Text = "$" + selectedDailyRate.ToString("N0");
            lblSubtotalVal.Text = "$0";
            lblTaxVal.Text = "$0";
            lblTotal.Text = "Invalid dates";
            return;
        }

        int cost = db.CalculateRentalCost(
            selectedVehicleID,
            dtpStart.Value.ToString("yyyy-MM-dd"),
            dtpEnd.Value.ToString("yyyy-MM-dd"));

        int tax = (int)Math.Round(cost * 0.14);
        int total = cost + tax;

        lblVehicleVal.Text = dgvAvailable.Rows.Count > 0
            ? dgvAvailable.Rows[GetSelectedRowIndex()].Cells["Family"].Value?.ToString() ?? "Selected vehicle"
            : "Selected vehicle";
        lblDurationVal.Text = days + " days";
        lblRateVal.Text = "$" + selectedDailyRate.ToString("N0");
        lblSubtotalVal.Text = "$" + cost.ToString("N0");
        lblTaxVal.Text = "$" + tax.ToString("N0");
        lblTotal.Text = "$" + total.ToString("N0");
    }

    private int GetSelectedRowIndex()
    {
        for (var i = 0; i < dgvAvailable.Rows.Count; i++)
        {
            var value = dgvAvailable.Rows[i].Cells["VehicleID"].Value;
            if (value != null && Convert.ToInt32(value) == selectedVehicleID)
            {
                return i;
            }
        }

        return -1;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (!ValidateRental(out var ssn, out var startDate, out var endDate, out var cost))
        {
            return;
        }

        try
        {
            int rentalID = GetNextIdentity("RentalID", "Rental");
            int paymentID = GetNextIdentity("PaymentID", "Payment");

            if (chkReserveWithoutPayment.Checked)
            {
                db.CreateRentalWithoutPayment(rentalID, ssn, selectedVehicleID, paymentID, startDate, endDate, cost);
            }
            else
            {
                db.CreateRentalWithPayment(rentalID, ssn, selectedVehicleID, paymentID, startDate, endDate, cost);
            }

            MessageBox.Show(
                "Rental confirmed successfully",
                "Rental",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetRentalSelection();
            LoadAvailableVehicles();
            UpdateSummary();
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

    private bool ValidateRental(out int ssn, out string startDate, out string endDate, out int cost)
    {
        ssn = 0;
        startDate = dtpStart.Value.ToString("yyyy-MM-dd");
        endDate = dtpEnd.Value.ToString("yyyy-MM-dd");
        cost = 0;

        if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
        {
            MessageBox.Show("Please lookup a customer first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(txtSSN.Text.Trim(), out ssn))
        {
            MessageBox.Show("Please enter a valid SSN.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (selectedVehicleID == -1)
        {
            MessageBox.Show("Please select a vehicle.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        int days = (dtpEnd.Value.Date - dtpStart.Value.Date).Days;
        if (days <= 0)
        {
            MessageBox.Show("Please choose valid rental dates.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        cost = db.CalculateRentalCost(selectedVehicleID, startDate, endDate);
        return true;
    }

    private int GetNextIdentity(string columnName, string tableName)
    {
        using var conn = new SqlConnection(DBHelper.ConnStr);
        using var cmd = new SqlCommand($"SELECT ISNULL(MAX({columnName}), 0) + 1 FROM {tableName}", conn);
        conn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    private void ResetForm()
    {
        txtSSN.Clear();
        txtCustomerName.Clear();
        ResetRentalSelection();
        UpdateSummary();
    }

    private void pnlSummary_Paint(object sender, PaintEventArgs e)
    {
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            pnlSummary.ClientRectangle,
            Color.FromArgb(10, 10, 15),
            Color.FromArgb(5, 25, 22),
            System.Drawing.Drawing2D.LinearGradientMode.Vertical);

        var rect = new Rectangle(0, 0, pnlSummary.Width - 1, pnlSummary.Height - 1);
        using var path = CreateRoundedPath(rect, 20);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        e.Graphics.FillPath(brush, path);
        using var pen = new Pen(Color.FromArgb(0, 210, 190), 1);
        e.Graphics.DrawPath(pen, path);
    }

    private static System.Drawing.Drawing2D.GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        int diameter = radius * 2;
        var arc = new Rectangle(rect.Location, new Size(diameter, diameter));

        path.AddArc(arc, 180, 90);
        arc.X = rect.Right - diameter;
        path.AddArc(arc, 270, 90);
        arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);
        arc.X = rect.Left;
        path.AddArc(arc, 90, 90);
        path.CloseFigure();
        return path;
    }
}
