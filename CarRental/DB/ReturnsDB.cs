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
            using var cmd = new SqlCommand(
                @"SELECT RD.RentalID,
                        R.SSN,
                        C.CName AS CustomerName,
                        RD.VehicleID,
                        RD.PaymentID,
                        V.Family AS VehicleModel,
                        V.LicensePlate,
                        V.DailyRate,
                        RD.StartDate,
                        RD.EndDate,
                        DATEDIFF(DAY, CAST(RD.EndDate AS DATE), CAST(GETDATE() AS DATE)) AS DaysOverdue
                 FROM RentalDetails RD
                 INNER JOIN Rental R ON R.RentalID = RD.RentalID
                 INNER JOIN Customer C ON R.SSN = C.SSN
                 INNER JOIN Vehicle V ON V.VehicleID = RD.VehicleID
                 WHERE RD.Status_ = 'Active'
                 ORDER BY RD.EndDate ASC", conn);
            
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
            using var cmd = new SqlCommand(
                "SELECT VehicleID, PaymentID, StartDate, EndDate FROM RentalDetails WHERE RentalID = @RentalID",
                conn);
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

    public void ConfirmReturn(int rentalID, int vehicleID, int? paymentID, int? amount = null)
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
            cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID.HasValue ? paymentID.Value : DBNull.Value;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = amount.HasValue ? amount.Value : DBNull.Value;

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
