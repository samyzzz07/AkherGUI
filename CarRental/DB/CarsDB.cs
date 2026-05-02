using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class CarsDB
{
    public DataTable GetAllVehicles()
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

    public DataTable SearchVehicles(string search, string statusFilter)
    {
        try
        {
            var hasSearch = !string.IsNullOrWhiteSpace(search);
            var hasStatus = !string.IsNullOrWhiteSpace(statusFilter)
                && !string.Equals(statusFilter, "All", StringComparison.OrdinalIgnoreCase);

            if (!hasSearch && !hasStatus)
            {
                return GetAllVehicles();
            }

            using var conn = new SqlConnection(DBHelper.ConnStr);
            var sql = "SELECT * FROM dbo.GetAllVehicles() WHERE 1=1";

            if (hasSearch)
            {
                sql += " AND (Family LIKE @search OR VType LIKE @search OR LicensePlate LIKE @search)";
            }

            if (hasStatus)
            {
                sql += " AND VStatus = @status";
            }

            using var cmd = new SqlCommand(sql, conn);

            if (hasSearch)
            {
                cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = "%" + search.Trim() + "%";
            }

            if (hasStatus)
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = statusFilter.Trim();
            }

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

    public void AddVehicle(
        int vehicleID,
        string vStatus,
        string vType,
        string family,
        int vYear,
        string colour,
        string originCountry,
        string licensePlate,
        int dailyRate,
        int mileage,
        int supplierid)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertVehicle", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@VStatus", SqlDbType.VarChar).Value = vStatus;
            cmd.Parameters.Add("@VType", SqlDbType.VarChar).Value = vType;
            cmd.Parameters.Add("@Family", SqlDbType.VarChar).Value = family;
            cmd.Parameters.Add("@VYear", SqlDbType.Int).Value = vYear;
            cmd.Parameters.Add("@Colour", SqlDbType.VarChar).Value = colour;
            cmd.Parameters.Add("@OriginCountry", SqlDbType.VarChar).Value = originCountry;
            cmd.Parameters.Add("@LicensePlate", SqlDbType.VarChar).Value = licensePlate;
            cmd.Parameters.Add("@DailyRate", SqlDbType.Int).Value = dailyRate;
            cmd.Parameters.Add("@Mileage", SqlDbType.Int).Value = mileage;
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierid;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void UpdateVehicle(
        int vehicleID,
        string vStatus,
        string vType,
        string family,
        int vYear,
        string colour,
        string originCountry,
        string licensePlate,
        int dailyRate,
        int mileage)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("UpdateVehicle", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;
            cmd.Parameters.Add("@VStatus", SqlDbType.VarChar).Value = vStatus;
            cmd.Parameters.Add("@VType", SqlDbType.VarChar).Value = vType;
            cmd.Parameters.Add("@Family", SqlDbType.VarChar).Value = family;
            cmd.Parameters.Add("@VYear", SqlDbType.Int).Value = vYear;
            cmd.Parameters.Add("@Colour", SqlDbType.VarChar).Value = colour;
            cmd.Parameters.Add("@OriginCountry", SqlDbType.VarChar).Value = originCountry;
            cmd.Parameters.Add("@LicensePlate", SqlDbType.VarChar).Value = licensePlate;
            cmd.Parameters.Add("@DailyRate", SqlDbType.Int).Value = dailyRate;
            cmd.Parameters.Add("@Mileage", SqlDbType.Int).Value = mileage;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void DeleteVehicle(int vehicleID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("DeleteVehicle", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = vehicleID;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch (SqlException ex)
        {
            if (ex.Message.Contains("active rentals", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Cannot delete vehicle with active rentals.",
                    "Delete Vehicle",
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

    public DataTable GetAllFamilies()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT VehicleFamily, BrandName FROM Family ORDER BY BrandName", conn);
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

    public void InsertFamily(string vehicleFamily, string brandName)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertFamily", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@VehicleFamily", SqlDbType.VarChar).Value = vehicleFamily;
            cmd.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = brandName;

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
