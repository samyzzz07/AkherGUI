using System;
using System.Data;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;
namespace CarRental;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();

    }

    public void ResetForLogout()
    {
        txtSSN.Clear();
        txtPassword.Clear();
        txtSSN.Focus();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtSSN.Text.Trim(), out var ssn))
        {
            MessageBox.Show(
                "Please enter a valid numeric SSN or Admin ID.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var password = txtPassword.Text;

        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("ValidateLogin", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

            conn.Open();
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show(
                    "Invalid credentials",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var role = reader["Role"]?.ToString();

            if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                var adminForm = new AdminForm();
                adminForm.Show();
                Hide();
                return;
            }

            if (string.Equals(role, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                var customerForm = new CustomerForm(ssn);
                customerForm.Show();
                Hide();
                return;
            }

            MessageBox.Show(
                "Invalid credentials",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        var signUpForm = new SignUpForm();
        signUpForm.ShowDialog();
    }
}
