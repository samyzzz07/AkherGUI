using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CarRental.DB;

public class SuppliersDB
{
    public DataTable GetAllSuppliers()
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("SELECT * FROM dbo.GetAllSuppliers()", conn);
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

    public void AddSupplier(int supplierID, string supplierName, int vehicleInStock)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("InsertSupplier", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierID;
            cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplierName;
            cmd.Parameters.Add("@VehicleInStock", SqlDbType.Int).Value = vehicleInStock;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void UpdateSupplier(int supplierID, string supplierName, int vehicleInStock)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("UpdateSupplier", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierID;
            cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplierName;
            cmd.Parameters.Add("@VehicleInStock", SqlDbType.Int).Value = vehicleInStock;

            conn.Open();
            cmd.ExecuteNonQuery();
            DataRefreshNotifier.NotifyDataChanged();
        }
        catch
        {
            throw;
        }
    }

    public void DeleteSupplier(int supplierID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("DeleteSupplier", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = supplierID;

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
