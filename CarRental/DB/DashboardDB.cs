using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class DashboardDB
{
    public int GetTotalFleetCount()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.GetCarCount()", conn)
            {
                CommandType = CommandType.Text
            };

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            throw;
        }
    }

    public int GetAvailableCarsCount()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.GetAvailableCarsCount()", conn)
            {
                CommandType = CommandType.Text
            };

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            throw;
        }
    }

    public int GetActiveRentalsCount()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.GetActiveRentalsCount()", conn)
            {
                CommandType = CommandType.Text
            };

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            throw;
        }
    }

    public int GetMonthlyRevenue()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.GetMonthlyRevenue()", conn)
            {
                CommandType = CommandType.Text
            };

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            throw;
        }
    }

    public int GetTotalCustomersCount()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT dbo.GetTotalCustomersCount()", conn)
            {
                CommandType = CommandType.Text
            };

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            throw;
        }
    }

    public DataTable GetRecentRentalsDetailed()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetRecentRentalsDetailed(30)", conn)
            {
                CommandType = CommandType.Text
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

    public DataTable GetFleetStatusBreakdown()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetFleetStatusBreakdown()", conn)
            {
                CommandType = CommandType.Text
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

    public DataTable GetTopVehicles()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetTopVehicles()", conn)
            {
                CommandType = CommandType.Text
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
