using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class CustomerHomeControl : UserControl
{
    private readonly int ssn;
    private readonly string customerName;
    private readonly CustomerPortalDB db = new CustomerPortalDB();

    public CustomerHomeControl(int ssn, string customerName)
    {
        this.ssn = ssn;
        this.customerName = string.IsNullOrWhiteSpace(customerName) ? $"Customer #{ssn}" : customerName.Trim();
        
        InitializeComponent();
        
        lblTitle.Text = $"Welcome, {this.customerName}!";
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
        Load += CustomerHomeControl_Load;
    }

    private void CustomerHomeControl_Load(object? sender, EventArgs e)
    {
        try
        {
            LoadSummary();
        }
        catch
        {
            lblActiveRentalsValue.Text = "0";
            lblPendingPaymentsValue.Text = "0";
            lblAvailableCarsValue.Text = "0";
        }
    }

    private void LoadSummary()
    {
        var rentalsTable = db.GetCustomerRentals(ssn);
        var activeRentals = 0;

        foreach (DataRow row in rentalsTable.Rows)
        {
            var status = row.Table.Columns.Contains("Status_") ? row["Status_"]?.ToString() : string.Empty;
            if (string.Equals(status, "Active", StringComparison.OrdinalIgnoreCase))
            {
                activeRentals++;
            }
        }

        var pendingPayments = db.GetPendingPayments(ssn).Rows.Count;
        var availableCars = db.GetAvailableCars().Rows.Count;

        lblActiveRentalsValue.Text = activeRentals.ToString();
        lblPendingPaymentsValue.Text = pendingPayments.ToString();
        lblAvailableCarsValue.Text = availableCars.ToString();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadSummary);
            return;
        }

        LoadSummary();
    }

    private static void CardPanel_Paint(object? sender, PaintEventArgs e)
    {
        if (sender is not Panel panel)
        {
            return;
        }

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var pen = new Pen(AppTheme.CardBorder);
        var rectangle = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
        e.Graphics.DrawRectangle(pen, rectangle);
    }
}