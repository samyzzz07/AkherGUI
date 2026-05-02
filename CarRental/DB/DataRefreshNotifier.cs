using System;

namespace CarRental.DB;

public static class DataRefreshNotifier
{
    public static event Action? DataChanged;

    public static void NotifyDataChanged()
    {
        DataChanged?.Invoke();
    }
}