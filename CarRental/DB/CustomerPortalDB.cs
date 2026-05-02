using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class CustomerPortalDB
{
    public DataTable GetAvailableCars()
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

    public DataTable GetCustomerRentals(int ssn)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetCustomerRentals(@SSN)", conn);
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

    public DataTable GetPendingPayments(int ssn)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand(
                "SELECT R.RentalID, P.* FROM Payment P JOIN RentalDetails RD ON P.PaymentID = RD.PaymentID JOIN Rental R ON RD.RentalID = R.RentalID WHERE P.Status_ = 0 AND R.SSN = @SSN",
                conn);
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
            return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }
        catch
        {
            throw;
        }
    }

    public DataTable GetStoreLocations()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetStoreLocations()", conn);
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
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertRentalWithPayment", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
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
            ConfirmPayment(rentalID);
            DataRefreshNotifier.NotifyDataChanged();
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
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertRentalWithPayment", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
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

    public void DeleteRental(int rentalID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("DeleteRental", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
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

    public void ConfirmPayment(int rentalID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("ConfirmPayment", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
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