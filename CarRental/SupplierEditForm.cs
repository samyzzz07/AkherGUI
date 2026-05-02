using System;
using System.Data;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class SupplierEditForm : Form
{
    private readonly int supplierID;
    private readonly SuppliersDB db = new SuppliersDB();

    public SupplierEditForm(int supplierID)
    {
        InitializeComponent();
        this.supplierID = supplierID;
        Text = supplierID == 0 ? "Add Supplier" : "Edit Supplier";
        lblTitle.Text = Text;
        Load += SupplierEditForm_Load;
    }

    private void SupplierEditForm_Load(object sender, EventArgs e)
    {
        if (supplierID > 0)
        {
            txtSupplierID.Enabled = false;
            LoadSupplier();
        }
        else
        {
            txtSupplierID.Enabled = true;
        }
    }

    private void LoadSupplier()
    {
        DataTable table = db.GetAllSuppliers();
        foreach (DataRow row in table.Rows)
        {
            if (Convert.ToInt32(row["SupplierID"]) != supplierID)
            {
                continue;
            }

            txtSupplierID.Text = row["SupplierID"]?.ToString();
            txtSupplierName.Text = row["SupplierName"]?.ToString();
            nudInStock.Value = Convert.ToDecimal(row["VehicleInStock"]);
            return;
        }

        MessageBox.Show(
            "Supplier not found.",
            "Load Supplier",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs(out var id, out var name, out var stock))
        {
            return;
        }

        try
        {
            if (supplierID == 0)
            {
                db.AddSupplier(id, name, stock);
            }
            else
            {
                db.UpdateSupplier(supplierID, name, stock);
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

    private bool ValidateInputs(out int id, out string name, out int stock)
    {
        id = 0;
        name = string.Empty;
        stock = 0;

        if (supplierID == 0 && !int.TryParse(txtSupplierID.Text.Trim(), out id))
        {
            MessageBox.Show("Supplier ID is required and must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        name = txtSupplierName.Text.Trim();
        stock = (int)nudInStock.Value;

        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show("Please fill in all supplier fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}
