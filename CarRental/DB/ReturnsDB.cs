using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class ReturnsDB
{
    public DataTable GetPendingReturns()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetPendingReturns()", conn);
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

    public DataTable GetRentalDetails(int rentalID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT VehicleID, PaymentID FROM dbo.Rental WHERE RentalID = @RentalID", conn);
            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;

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

    public void ConfirmReturn(int rentalID, int vehicleID, int paymentID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("ConfirmReturn", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@RentalID", SqlDbType.Int).Value = rentalID;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;

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
