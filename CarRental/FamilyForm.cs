using System;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class FamilyForm : Form
{
    private CarsDB db = new CarsDB();

    public FamilyForm()
    {
        InitializeComponent();
    }

    private void BtnSave_Click(object? sender, EventArgs e)
    {
        var family = txtFamily.Text?.Trim();
        var brand = txtBrand.Text?.Trim();
        if (string.IsNullOrWhiteSpace(family))
        {
            MessageBox.Show("Please enter the vehicle family.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            db.InsertFamily(family, brand ?? string.Empty);
            MessageBox.Show("Family inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inserting family: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
