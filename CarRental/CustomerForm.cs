using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CarRental.DB;
using FontAwesome.Sharp;

namespace CarRental;

public partial class CustomerForm : Form
{
    private readonly int _ssn;
    private readonly string _customerName;
    private readonly CustomerHomeControl _homeControl;
    private readonly CustomerRentalBookingControl _bookingControl;
    private readonly CustomerRentalsControl _rentalsControl;
    private readonly CustomerPaymentsControl _paymentsControl;

    private Button? _activeNavButton;

    public CustomerForm(int ssn)
    {
        _ssn = ssn;
        _customerName = LoadCustomerName(ssn);

        InitializeComponent();

        lblCustomerName.Text = string.IsNullOrWhiteSpace(_customerName) ? $"Customer #{_ssn}" : _customerName;

        _homeControl = new CustomerHomeControl(_ssn, _customerName);
        _bookingControl = new CustomerRentalBookingControl(_ssn);
        _rentalsControl = new CustomerRentalsControl(_ssn);
        _paymentsControl = new CustomerPaymentsControl(_ssn);

        btnNavHome.Click += btnNavHome_Click;
        btnNavCars.Click += btnNavCars_Click;
        btnNavRentals.Click += btnNavRentals_Click;
        btnNavPayments.Click += btnNavPayments_Click;

        LogoutButtonHelper.AddLogoutButton(this);
        Load += CustomerForm_Load;
    }

    private void CustomerForm_Load(object? sender, EventArgs e)
    {
        ShowPanel(_homeControl, btnNavHome);
    }

    private static string LoadCustomerName(int ssn)
    {
        try
        {
            var db = new CustomersDB();
            var table = db.GetCustomerBySSN(ssn);

            if (table.Rows.Count == 0)
            {
                return string.Empty;
            }

            var row = table.Rows[0];
            return GetFirstValue(row, "CName", "CustomerName", "Name");
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string GetFirstValue(DataRow row, params string[] columnNames)
    {
        foreach (var columnName in columnNames)
        {
            if (!row.Table.Columns.Contains(columnName))
            {
                continue;
            }

            var value = row[columnName]?.ToString();
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value.Trim();
            }
        }

        return string.Empty;
    }

    private static string GetInitials(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "C";
        }

        var parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 1)
        {
            return parts[0].Substring(0, 1).ToUpperInvariant();
        }

        return string.Concat(parts[0][0], parts[^1][0]).ToUpperInvariant();
    }

    private void ShowPanel(UserControl panel, Button activeBtn)
    {
        pnlContent.Controls.Clear();
        panel.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(panel);

        ResetNavButtons();
        _activeNavButton = activeBtn;
        SetActiveButton(activeBtn);

        pnlTopNav.Invalidate();
        activeBtn.Invalidate();
    }

    private void ResetNavButtons()
    {
        foreach (Control control in pnlTopNav.Controls)
        {
            if (control is IconButton iconButton)
            {
                iconButton.BackColor = Color.FromArgb(10, 10, 15);
                iconButton.ForeColor = Color.FromArgb(80, 80, 100);
                iconButton.IconColor = Color.FromArgb(80, 80, 100);
                iconButton.Invalidate();
            }
        }
    }

    private void SetActiveButton(Button button)
    {
        button.BackColor = Color.FromArgb(10, 10, 15);
        button.ForeColor = Color.FromArgb(0, 210, 190);

        if (button is IconButton iconButton)
        {
            iconButton.IconColor = Color.FromArgb(0, 210, 190);
        }
    }

    private void btnNavHome_Click(object? sender, EventArgs e) => ShowPanel(_homeControl, btnNavHome);
    private void btnNavCars_Click(object? sender, EventArgs e) => ShowPanel(_bookingControl, btnNavCars);
    private void btnNavRentals_Click(object? sender, EventArgs e) => ShowPanel(_rentalsControl, btnNavRentals);
    private void btnNavPayments_Click(object? sender, EventArgs e) => ShowPanel(_paymentsControl, btnNavPayments);

    private void NavButton_Paint(object? sender, PaintEventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        if (!ReferenceEquals(button, _activeNavButton))
        {
            return;
        }

        using var pen = new Pen(Color.FromArgb(0, 210, 190), 2);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.DrawLine(pen, 6, button.Height - 2, button.Width - 6, button.Height - 2);
    }

    private void PnlTopNav_Paint(object? sender, PaintEventArgs e)
    {
        using var pen = new Pen(Color.FromArgb(0, 210, 190), 1);
        e.Graphics.DrawLine(pen, 0, pnlTopNav.Height - 1, pnlTopNav.Width, pnlTopNav.Height - 1);
    }

    private void PnlAvatar_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var brush = new SolidBrush(Color.FromArgb(0, 210, 190));
        e.Graphics.FillEllipse(brush, 0, 0, pnlAvatar.Width - 1, pnlAvatar.Height - 1);

        var initials = GetInitials(_customerName);
        using var font = new Font("Segoe UI", 9F, FontStyle.Bold);
        var textSize = e.Graphics.MeasureString(initials, font);
        using var textBrush = new SolidBrush(Color.White);
        e.Graphics.DrawString(
            initials,
            font,
            textBrush,
            (pnlAvatar.Width - textSize.Width) / 2,
            (pnlAvatar.Height - textSize.Height) / 2 - 1);
    }
}