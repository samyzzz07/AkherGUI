using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class CustomerCarsControl : UserControl
{
    private readonly CustomerPortalDB db = new CustomerPortalDB();

    public CustomerCarsControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvCars);
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
        Load += CustomerCarsControl_Load;
    }

    private void CustomerCarsControl_Load(object? sender, EventArgs e)
    {
        LoadAvailableCars();
    }

    private void LoadAvailableCars()
    {
        dgvCars.DataSource = db.GetAvailableCars();
        ApplyGridConfiguration();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadAvailableCars);
            return;
        }

        LoadAvailableCars();
    }

    private void DgvCars_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        ApplyGridConfiguration();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvCars.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("Family", "Model");
        SetHeaderIfExists("VType", "Type");
        SetHeaderIfExists("VYear", "Year");
        SetHeaderIfExists("DailyRate", "Rate/day");
        SetHeaderIfExists("Mileage", "Mileage");

        SetVisibleIfExists("Family", true);
        SetVisibleIfExists("VType", true);
        SetVisibleIfExists("VYear", true);
        SetVisibleIfExists("DailyRate", true);
        SetVisibleIfExists("Mileage", true);

        foreach (DataGridViewColumn column in dgvCars.Columns)
        {
            if (column.Name is "Family" or "VType" or "VYear" or "DailyRate" or "Mileage")
            {
                continue;
            }

            column.Visible = false;
        }
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvCars.Columns.Contains(columnName))
        {
            dgvCars.Columns[columnName].HeaderText = headerText;
        }
    }

    private void SetVisibleIfExists(string columnName, bool visible)
    {
        if (dgvCars.Columns.Contains(columnName))
        {
            dgvCars.Columns[columnName].Visible = visible;
        }
    }

    private void CustomerCarsControl_Resize(object? sender, EventArgs e)
    {
        pnlCard.Invalidate();
    }

    private void CardPanel_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var pen = new Pen(AppTheme.CardBorder);
        var rectangle = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
        e.Graphics.DrawRectangle(pen, rectangle);
    }
}