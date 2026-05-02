using System;
using System.Data;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class FleetControl : UserControl
{
    private CarsDB db = new CarsDB();

    public FleetControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvCars);
        Load += FleetControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;

    }

    private void FleetControl_Load(object sender, EventArgs e)
    {
        if (cmbStatus.Items.Count > 0)
        {
            cmbStatus.SelectedIndex = 0;
        }

        if (cmbType.Items.Count > 0)
        {
            cmbType.SelectedIndex = 0;
        }

        RefreshCars();
    }

    private void LoadCars()
    {
        dgvCars.DataSource = db.GetAllVehicles();
        dgvCars.BackgroundColor = Color.FromArgb(22, 22, 32);
        dgvCars.DefaultCellStyle.BackColor = Color.FromArgb(22, 22, 32);
        dgvCars.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
        dgvCars.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 28);
        dgvCars.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
        dgvCars.GridColor = Color.FromArgb(30, 30, 45);
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void RefreshCars()
    {
        var statusText = cmbStatus.SelectedItem?.ToString() ?? "All";
        var statusFilter = string.Equals(statusText, "All Status", StringComparison.OrdinalIgnoreCase)
            ? "All"
            : statusText;

        if (string.IsNullOrWhiteSpace(txtSearch.Text) && string.Equals(statusFilter, "All", StringComparison.OrdinalIgnoreCase))
        {
            LoadCars();
            return;
        }

        dgvCars.DataSource = db.SearchVehicles(txtSearch.Text, statusFilter);
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)RefreshCars);
            return;
        }

        RefreshCars();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvCars.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("VehicleID", "ID");
        SetHeaderIfExists("VStatus", "Status");
        SetHeaderIfExists("VType", "Type");
        SetHeaderIfExists("Family", "Model");
        SetHeaderIfExists("BrandName", "Brand");
        SetHeaderIfExists("VYear", "Year");
        SetHeaderIfExists("LicensePlate", "Plate");
        SetHeaderIfExists("DailyRate", "Rate/day");
        SetHeaderIfExists("Mileage", "Mileage");

        SetVisibleIfExists("Colour", false);
        SetVisibleIfExists("OriginCountry", false);
    }

    private void EnsureActionColumns()
    {
        // Action buttons are now outside the grid
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvCars.Columns.Contains(columnName))
        {
            dgvCars.Columns[columnName].HeaderText = headerText;
        }
    }

    private void SetVisibleIfExists(string columnName, bool visible)
    {
        if (dgvCars.Columns.Contains(columnName))
        {
            dgvCars.Columns[columnName].Visible = visible;
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var statusText = cmbStatus.SelectedItem?.ToString() ?? "All";
        var statusFilter = string.Equals(statusText, "All Status", StringComparison.OrdinalIgnoreCase)
            ? "All"
            : statusText;

        dgvCars.DataSource = db.SearchVehicles(txtSearch.Text, statusFilter);
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void dgvCars_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        var hasSelection = dgvCars.SelectedRows.Count > 0;
        if (btnEdit != null)
        {
            btnEdit.Enabled = hasSelection;
        }

        if (btnDelete != null)
        {
            btnDelete.Enabled = hasSelection;
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvCars.SelectedRows.Count == 0)
        {
            return;
        }

        var vehicleIdValue = dgvCars.SelectedRows[0].Cells["VehicleID"].Value;
        if (vehicleIdValue == null || !int.TryParse(vehicleIdValue.ToString(), out var vehicleId))
        {
            return;
        }

        using var form = new VehicleEditForm(vehicleId);
        form.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvCars.SelectedRows.Count == 0)
        {
            return;
        }

        var vehicleIdValue = dgvCars.SelectedRows[0].Cells["VehicleID"].Value;
        if (vehicleIdValue == null || !int.TryParse(vehicleIdValue.ToString(), out var vehicleId))
        {
            return;
        }

        var result = MessageBox.Show(
            "Delete this vehicle?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            db.DeleteVehicle(vehicleId);
        }
    }

    private void btnAddVehicle_Click(object sender, EventArgs e)
    {
        using var form = new VehicleEditForm(0);
        form.ShowDialog();
    }

    private void BtnAddFamily_Click(object? sender, EventArgs e)
    {
        using var form = new FamilyForm();
        var res = form.ShowDialog();
        if (res == DialogResult.OK)
        {
            RefreshCars();
        }
    }
}
