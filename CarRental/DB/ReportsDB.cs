using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class ReportsDB
{
    public DataTable GetRevenueByType(int month, int year)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetRevenueByType(@Month, @Year)", conn);
            cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;

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

    public DataTable GetFleetUtilization()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetAllVehicles()", conn);
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

    public DataTable GetOverdueReport()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetOverdueReport()", conn);
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

    public DataTable GetDailyRentalReport()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("GetDailyRentalReport", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
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
