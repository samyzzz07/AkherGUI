using System;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;

namespace CarRental;

public partial class SignUpForm : Form
{
    private readonly CustomersDB db = new CustomersDB();

    public SignUpForm()
    {
        InitializeComponent();
        btnSave.Click += BtnSave_Click;
    }


    private void BtnSave_Click(object sender, EventArgs e)
    {
        // Validate SSN
        if (!int.TryParse(txtSSN.Text.Trim(), out var ssn))
        {
            MessageBox.Show(
                "SSN must be numeric.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Validate Phone
        if (!int.TryParse(txtPhone.Text.Trim(), out var phone))
        {
            MessageBox.Show(
                "Phone must be numeric.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Validate Driver License Number
        if (!int.TryParse(txtDLN.Text.Trim(), out var dlNumber))
        {
            MessageBox.Show(
                "Driver License number must be numeric.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Validate House Number
        if (!int.TryParse(txtHouseNo.Text.Trim(), out var houseNo))
        {
            MessageBox.Show(
                "House Number must be numeric.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Validate required text fields
        var name = txtName.Text.Trim();
        var email = txtEmail.Text.Trim();
        var street = txtStreet.Text.Trim();
        var district = txtDistrict.Text.Trim();
        var city = txtCity.Text.Trim();
        var password = txtPassword.Text;
        var confirmPassword = txtConfirmPassword.Text;

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show(
                "Full Name is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(email))
        {
            MessageBox.Show(
                "Email is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(street))
        {
            MessageBox.Show(
                "Street is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(district))
        {
            MessageBox.Show(
                "District is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(city))
        {
            MessageBox.Show(
                "City is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            MessageBox.Show(
                "Password is required.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Validate password match
        if (password != confirmPassword)
        {
            MessageBox.Show(
                "Passwords do not match.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            db.AddCustomer(ssn, phone, name, dtpBirth.Value.Date, email, dlNumber, houseNo, street, district, city, password);

            MessageBox.Show(
                "Account created successfully! You can now log in.",
                "Sign Up Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"An error occurred: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
