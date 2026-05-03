using System.Configuration;

namespace CarRental.DB;

public static class DBHelper
{
    public static string ConnStr = ConfigurationManager.ConnectionStrings["CarRentalDB"].ConnectionString;
}
