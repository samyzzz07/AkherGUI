using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class CustomersDB
{
    public DataTable GetAllCustomers()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetAllCustomers()", conn);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            return table;
        }
        catch
        {
            throw;
        }
    }

    public DataTable SearchCustomers(string search)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand(
                "SELECT * FROM dbo.GetAllCustomers() WHERE CName LIKE @s OR Email LIKE @s OR CAST(SSN AS VARCHAR) LIKE @s",
                conn);
            cmd.Parameters.Add("@s", SqlDbType.VarChar).Value = "%" + search + "%";

            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            return table;
        }
        catch
        {
            throw;
        }
    }

    public void AddCustomer(
        int ssn,
        int phone,
        string cName,
        DateTime birthdate,
        string email,
        int dlNumber,
        int houseNo,
        string street,
        string district,
        string city,
        string password)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertCustomer", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = phone;
            cmd.Parameters.Add("@CName", SqlDbType.VarChar).Value = cName;
            cmd.Parameters.Add("@Birthdate", SqlDbType.DateTime).Value = birthdate;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@DriversLicenseNumber", SqlDbType.Int).Value = dlNumber;
            cmd.Parameters.Add("@HouseNumber", SqlDbType.Int).Value = houseNo;
            cmd.Parameters.Add("@Street", SqlDbType.VarChar).Value = street;
            cmd.Parameters.Add("@District", SqlDbType.VarChar).Value = district;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = city;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void UpdateCustomer(
        int ssn,
        int phone,
        string cName,
        DateTime birthdate,
        string email,
        int dlNumber,
        int houseNo,
        string street,
        string district,
        string city)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("UpdateCustomer", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = phone;
            cmd.Parameters.Add("@CName", SqlDbType.VarChar).Value = cName;
            cmd.Parameters.Add("@Birthdate", SqlDbType.DateTime).Value = birthdate;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@DriversLicenseNumber", SqlDbType.Int).Value = dlNumber;
            cmd.Parameters.Add("@HouseNo", SqlDbType.Int).Value = houseNo;
            cmd.Parameters.Add("@Street", SqlDbType.VarChar).Value = street;
            cmd.Parameters.Add("@District", SqlDbType.VarChar).Value = district;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = city;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void DeleteCustomer(int ssn)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("DeleteCustomer", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch (SqlException ex)
        {
            if (ex.Message.Contains("active rentals", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Cannot delete customer with active rentals.",
                    "Delete Customer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            throw;
        }
        catch
        {
            throw;
        }
    }

    public DataTable GetCustomerBySSN(int ssn)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("GetCustomerBySSN", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            return table;
        }
        catch
        {
            throw;
        }
    }
}
