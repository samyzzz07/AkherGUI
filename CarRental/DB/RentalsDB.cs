using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class RentalsDB
{
    public DataTable GetAvailableVehicles()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetAvailableCars()", conn);
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

    public int CalculateRentalCost(int vehicleID, string startDate, string endDate)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.CalculateRentalCost(@VehicleID, @StartDate, @EndDate)", conn);
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = startDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = endDate;

            conn.Open();
            var result = cmd.ExecuteScalar();
            return result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
        }
        catch
        {
            throw;
        }
    }

    public void CreateRental(int rentalID, int ssn, int vehicleID, int paymentID, string startDate, string endDate, int amount)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertRental", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;
            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;
            cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = startDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = endDate;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = amount;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void CreateRentalWithPayment(int rentalID, int ssn, int vehicleID, int paymentID, string startDate, string endDate, int amount)
    {
        try
        {
            // Non-admin flow: use InsertRental which doesn't require EmployeeID
            CreateRental(rentalID, ssn, vehicleID, paymentID, startDate, endDate, amount);
            ConfirmPayment(rentalID);
        }
        catch
        {
            throw;
        }
    }

    public void CreateRentalWithoutPayment(int rentalID, int ssn, int vehicleID, int paymentID, string startDate, string endDate, int amount)
    {
        try
        {
            // Non-admin flow: use InsertRental which doesn't require EmployeeID
            CreateRental(rentalID, ssn, vehicleID, paymentID, startDate, endDate, amount);
        }
        catch
        {
            throw;
        }
    }

    // Admin overloads that accept an employeeID and record it in RentsOut
    public void CreateRentalWithPayment(int rentalID, int ssn, int vehicleID, int paymentID, string startDate, string endDate, int amount, int employeeID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertRentalWithoutPayment", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;
            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = startDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = endDate;
            cmd.Parameters.Add("@EmployeeID", SqlDbType.VarChar, 10).Value = employeeID.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            ConfirmPayment(rentalID);
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void CreateRentalWithoutPayment(int rentalID, int ssn, int vehicleID, int paymentID, string startDate, string endDate, int amount, int employeeID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertRentalWithoutPayment", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;
            cmd.Parameters.Add("@SSN", SqlDbType.Int).Value = ssn;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = startDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = endDate;
            cmd.Parameters.Add("@EmployeeID", SqlDbType.VarChar, 10).Value = employeeID.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void ConfirmPayment(int rentalID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("ConfirmPayment", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }
}
