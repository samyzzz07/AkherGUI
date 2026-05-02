using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;

namespace CarRental;

public partial class CustomerRentalBookingControl : UserControl
{
    private readonly int ssn;
    private CustomerPortalDB db = new CustomerPortalDB();
    private int selectedVehicleID = -1;
    private int selectedDailyRate = 0;

    public CustomerRentalBookingControl(int ssn)
    {
        InitializeComponent();
        ConfigureDatePickers();
        AppTheme.StyleDataGridView(dgvAvailable);
        this.ssn = ssn;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
        Load += CustomerRentalBookingControl_Load;
    }

    private void CustomerRentalBookingControl_Load(object sender, EventArgs e)
    {
        ConfigureDatePickers();
        LoadStoreLocations();
        LoadAvailableVehicles();
        UpdateSummary();
    }
    
    private void LoadStoreLocations()
    {
        try
        {
            var tbl = db.GetStoreLocations();
            if (tbl == null || tbl.Rows.Count == 0)
            {
                return;
            }

            if (tbl.Columns.Contains("Name") && tbl.Columns.Contains("StoreID"))
            {
                cmbStoreLocations.DataSource = tbl;
                cmbStoreLocations.DisplayMember = "Name";
                cmbStoreLocations.ValueMember = "StoreID";
            }
            else if (tbl.Columns.Count >= 2)
            {
                cmbStoreLocations.DataSource = tbl;
                cmbStoreLocations.DisplayMember = tbl.Columns[1].ColumnName;
                cmbStoreLocations.ValueMember = tbl.Columns[0].ColumnName;
            }
            else
            {
                cmbStoreLocations.DataSource = tbl;
                cmbStoreLocations.DisplayMember = tbl.Columns[0].ColumnName;
                cmbStoreLocations.ValueMember = tbl.Columns[0].ColumnName;
            }
        }
        catch
        {
            // non-fatal - store dropdown is optional
        }
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

    private void LoadAvailableVehicles()
    {
        dgvAvailable.DataSource = db.GetAvailableCars();
        ApplyGridConfiguration();
        EnsureSelectColumn();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)RefreshBookingData);
            return;
        }

        RefreshBookingData();
    }

    private void RefreshBookingData()
    {
        LoadAvailableVehicles();
        UpdateSummary();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvAvailable.Columns.Count == 0)
        {
            return;
        }

        // Hide all columns first
        foreach (DataGridViewColumn col in dgvAvailable.Columns)
        {
            col.Visible = false;
        }

        // Show only the desired columns
        SetColumnVisibility("Family", true, "Model");
        SetColumnVisibility("VType", true, "Type");
        SetColumnVisibility("VYear", true, "Year");
        SetColumnVisibility("DailyRate", true, "Rate/day");
        SetColumnVisibility("Mileage", true, "Mileage");
        
        AppTheme.StyleDataGridView(dgvAvailable);
    }

    private void SetColumnVisibility(string columnName, bool visible, string? headerText = null)
    {
        if (dgvAvailable.Columns.Contains(columnName))
        {
            dgvAvailable.Columns[columnName].Visible = visible;
            if (headerText != null)
            {
                dgvAvailable.Columns[columnName].HeaderText = headerText;
            }
        }
    }

    private void EnsureSelectColumn()
    {
        // Select column is handled by row selection
    }

    private void dgvAvailable_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        btnSelect.Enabled = dgvAvailable.SelectedRows.Count > 0;
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

        // Get vehicle name from selected row
        string vehicleName = "Selected vehicle";
        int selectedRowIndex = GetSelectedRowIndex();
        if (selectedRowIndex >= 0)
        {
            vehicleName = dgvAvailable.Rows[selectedRowIndex].Cells["Family"].Value?.ToString() ?? "Selected vehicle";
        }

        // Calculate rental cost using database method
        string startDate = dtpStart.Value.ToString("yyyy-MM-dd");
        string endDate = dtpEnd.Value.ToString("yyyy-MM-dd");
        
        int subtotal = db.CalculateRentalCost(selectedVehicleID, startDate, endDate);
        int tax = (int)Math.Round(subtotal * 0.14);
        int total = subtotal + tax;

        lblVehicleVal.Text = vehicleName;
        lblDurationVal.Text = days + " days";
        lblRateVal.Text = "$" + selectedDailyRate.ToString("N0");
        lblSubtotalVal.Text = "$" + subtotal.ToString("N0");
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
        if (selectedVehicleID == -1)
        {
            MessageBox.Show("Please select a vehicle.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int days = (dtpEnd.Value.Date - dtpStart.Value.Date).Days;
        if (days <= 0)
        {
            MessageBox.Show("Please choose valid rental dates.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

            try
            {
                string startDate = dtpStart.Value.ToString("yyyy-MM-dd");
                string endDate = dtpEnd.Value.ToString("yyyy-MM-dd");
                int cost = db.CalculateRentalCost(selectedVehicleID, startDate, endDate);

                int rentalID = GetNextIdentity("RentalID", "Rental");
                int paymentID = GetNextIdentity("PaymentID", "Payment");

                if (chkReserveWithoutPayment != null && chkReserveWithoutPayment.Checked)
                {
                    db.CreateRentalWithoutPayment(rentalID, ssn, selectedVehicleID, paymentID, startDate, endDate, cost);
                }
                else
                {
                    db.CreateRentalWithPayment(rentalID, ssn, selectedVehicleID, paymentID, startDate, endDate, cost);
                }

                MessageBox.Show(
                    "Rental confirmed successfully!",
                    "Booking Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetBooking();
                LoadAvailableVehicles();
            }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Error confirming rental: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void ResetBooking()
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

        UpdateSummary();
    }

    private int GetNextIdentity(string columnName, string tableName)
    {
        using var conn = new SqlConnection(DBHelper.ConnStr);
        using var cmd = new SqlCommand($"SELECT ISNULL(MAX({columnName}), 0) + 1 FROM {tableName}", conn);
        conn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    private void pnlSummary_Paint(object sender, PaintEventArgs e)
    {
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            pnlSummary.ClientRectangle,
            AppTheme.Sidebar,
            Color.FromArgb(34, 22, 68),
            System.Drawing.Drawing2D.LinearGradientMode.Vertical);

        var rect = new Rectangle(0, 0, pnlSummary.Width - 1, pnlSummary.Height - 1);
        using var path = CreateRoundedPath(rect, 20);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        e.Graphics.FillPath(brush, path);
        using var pen = new Pen(Color.FromArgb(84, 67, 150), 1);
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
