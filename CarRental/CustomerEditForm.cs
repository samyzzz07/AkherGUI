using System;
using System.Data;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class CustomerEditForm : Form
{
    private readonly int ssn;
    private readonly CustomersDB db = new CustomersDB();

    public CustomerEditForm(int ssn)
    {
        InitializeComponent();
        this.ssn = ssn;
        Text = ssn == 0 ? "Add Customer" : "Edit Customer";
        lblTitle.Text = Text;
        Load += CustomerEditForm_Load;
    }

    private void CustomerEditForm_Load(object sender, EventArgs e)
    {
        if (ssn > 0)
        {
            txtSSN.Enabled = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            LoadCustomer();
        }
        else
        {
            txtSSN.Enabled = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
        }
    }

    private void LoadCustomer()
    {
        DataTable table = db.GetCustomerBySSN(ssn);

        if (table.Rows.Count == 0)
        {
            MessageBox.Show(
                "Customer not found.",
                "Load Customer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        DataRow row = table.Rows[0];

        txtSSN.Text = row["SSN"]?.ToString();
        txtName.Text = row["CName"]?.ToString();
        txtEmail.Text = row["Email"]?.ToString();
        txtPhone.Text = row["PhoneNumber"]?.ToString();
        dtpBirth.Value = Convert.ToDateTime(row["Birthdate"]);
        txtDLN.Text = row["DriversLicenseNumber"]?.ToString();
        txtHouseNo.Text = row["HouseNumber"]?.ToString();
        txtStreet.Text = row["Street"]?.ToString();
        txtDistrict.Text = row["District"]?.ToString();
        txtCity.Text = row["City"]?.ToString();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs(out var customerSsn, out var phone, out var name, out var birthdate, out var email, out var dlNumber, out var houseNo, out var street, out var district, out var city, out var password))
        {
            return;
        }

        try
        {
            if (ssn == 0)
            {
                db.AddCustomer(customerSsn, phone, name, birthdate, email, dlNumber, houseNo, street, district, city, password);
            }
            else
            {
                db.UpdateCustomer(ssn, phone, name, birthdate, email, dlNumber, houseNo, street, district, city);
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
        out int customerSsn,
        out int phone,
        out string name,
        out DateTime birthdate,
        out string email,
        out int dlNumber,
        out int houseNo,
        out string street,
        out string district,
        out string city,
        out string password)
    {
        customerSsn = 0;
        phone = 0;
        name = string.Empty;
        birthdate = DateTime.Today;
        email = string.Empty;
        dlNumber = 0;
        houseNo = 0;
        street = string.Empty;
        district = string.Empty;
        city = string.Empty;
        password = string.Empty;

        if (ssn == 0 && !int.TryParse(txtSSN.Text.Trim(), out customerSsn))
        {
            MessageBox.Show("SSN is required and must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(txtPhone.Text.Trim(), out phone) ||
            !int.TryParse(txtDLN.Text.Trim(), out dlNumber) ||
            !int.TryParse(txtHouseNo.Text.Trim(), out houseNo))
        {
            MessageBox.Show("Phone number, driver license number, and house number must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        name = txtName.Text.Trim();
        email = txtEmail.Text.Trim();
        birthdate = dtpBirth.Value.Date;
        street = txtStreet.Text.Trim();
        district = txtDistrict.Text.Trim();
        city = txtCity.Text.Trim();
        password = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(street) ||
            string.IsNullOrWhiteSpace(district) ||
            string.IsNullOrWhiteSpace(city) ||
            (ssn == 0 && string.IsNullOrWhiteSpace(password)))
        {
            MessageBox.Show("Please fill in all customer fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (ssn == 0 && txtSSN.Text.Trim().Length == 0)
        {
            MessageBox.Show("SSN is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}
