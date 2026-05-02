using System;
using System.Data;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;

namespace CarRental;

public partial class VehicleEditForm : Form
{
    private readonly int vehicleId;
    private readonly CarsDB db = new CarsDB();
    private readonly SuppliersDB suppliersDb = new SuppliersDB();

    public VehicleEditForm(int vehicleId)
    {
        InitializeComponent();
        this.vehicleId = vehicleId;
        Text = vehicleId == 0 ? "Add Vehicle" : "Edit Vehicle";
        lblTitle.Text = Text;
        Load += VehicleEditForm_Load;
    }

    private void VehicleEditForm_Load(object sender, EventArgs e)
    {
        if (vehicleId > 0)
        {
            txtVehicleID.Enabled = false;
            lblSupplier.Visible = false;
            cmbSupplier.Visible = false;
            tblForm.RowStyles[11].Height = 0;
            LoadFamilies();
            LoadVehicle();
        }
        else
        {
            txtVehicleID.Enabled = true;
            LoadFamilies();
            LoadSuppliers();
        }
    }

    private void LoadVehicle()
    {
        using var conn = new SqlConnection(DBHelper.ConnStr);
        using var cmd = new SqlCommand("SELECT * FROM dbo.GetAllVehicles() WHERE VehicleID = @id", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = vehicleId;

        conn.Open();
        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
        {
            MessageBox.Show(
                "Vehicle not found.",
                "Load Vehicle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        txtVehicleID.Text = reader["VehicleID"]?.ToString();
        cmbFamily.SelectedValue = reader["Family"]?.ToString();
        cmbType.SelectedItem = reader["VType"]?.ToString();
        nudYear.Value = Convert.ToDecimal(reader["VYear"]);
        cmbStatus.SelectedItem = reader["VStatus"]?.ToString();
        txtColour.Text = reader["Colour"]?.ToString();
        txtOrigin.Text = reader["OriginCountry"]?.ToString();
        txtPlate.Text = reader["LicensePlate"]?.ToString();
        nudRate.Value = Convert.ToDecimal(reader["DailyRate"]);
        nudMileage.Value = Convert.ToDecimal(reader["Mileage"]);
    }

    private void LoadFamilies()
    {
        DataTable table = db.GetAllFamilies();

        if (table.Rows.Count == 0)
        {
            MessageBox.Show(
                "No families found. Please add a family to the database.",
                "Add Vehicle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        cmbFamily.DisplayMember = "VehicleFamily";
        cmbFamily.ValueMember = "VehicleFamily";
        cmbFamily.DataSource = table;
        cmbFamily.SelectedIndex = -1;
    }

    private void LoadSuppliers()
    {
        DataTable table = suppliersDb.GetAllSuppliers();

        if (table.Rows.Count == 0)
        {
            MessageBox.Show(
                "No suppliers found. Add a supplier first.",
                "Add Vehicle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        cmbSupplier.DisplayMember = "SupplierName";
        cmbSupplier.ValueMember = "SupplierID";
        cmbSupplier.DataSource = table;
        cmbSupplier.SelectedIndex = -1;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs(out var vehicleIdValue, out var family, out var type, out var status, out var colour, out var origin, out var plate, out var year, out var rate, out var mileage, out var supplierId))
        {
            return;
        }

        try
        {
            if (vehicleId == 0)
            {
                db.AddVehicle(vehicleIdValue, status, type, family, year, colour, origin, plate, rate, mileage, supplierId);
            }
            else
            {
                db.UpdateVehicle(vehicleId, status, type, family, year, colour, origin, plate, rate, mileage);
            }

            DialogResult = DialogResult.OK;
            Close();
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

    private bool ValidateInputs(
        out int vehicleIdValue,
        out string family,
        out string type,
        out string status,
        out string colour,
        out string origin,
        out string plate,
        out int year,
        out int rate,
        out int mileage,
        out int supplierId)
    {
        vehicleIdValue = 0;
        family = string.Empty;
        type = string.Empty;
        status = string.Empty;
        colour = string.Empty;
        origin = string.Empty;
        plate = string.Empty;
        year = 0;
        rate = 0;
        mileage = 0;
        supplierId = 0;

        if (vehicleId == 0 && !int.TryParse(txtVehicleID.Text.Trim(), out vehicleIdValue))
        {
            MessageBox.Show("Vehicle ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        type = cmbType.SelectedItem?.ToString() ?? string.Empty;
        status = cmbStatus.SelectedItem?.ToString() ?? string.Empty;
        colour = txtColour.Text.Trim();
        origin = txtOrigin.Text.Trim();
        plate = txtPlate.Text.Trim();
        year = (int)nudYear.Value;
        rate = (int)nudRate.Value;
        mileage = (int)nudMileage.Value;

        if (cmbFamily.SelectedValue == null || string.IsNullOrWhiteSpace(cmbFamily.SelectedValue.ToString()))
        {
            MessageBox.Show("Please select a family.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        family = cmbFamily.SelectedValue.ToString() ?? string.Empty;

        if (vehicleId == 0)
        {
            if (cmbSupplier.SelectedValue == null || !int.TryParse(cmbSupplier.SelectedValue.ToString(), out supplierId))
            {
                MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        if (string.IsNullOrWhiteSpace(type) ||
            string.IsNullOrWhiteSpace(status) ||
            string.IsNullOrWhiteSpace(colour) ||
            string.IsNullOrWhiteSpace(origin) ||
            string.IsNullOrWhiteSpace(plate))
        {
            MessageBox.Show("Please fill in all vehicle fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}
