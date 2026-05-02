using System;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CarRental;

public partial class AdminForm : Form
{
    private readonly DashboardControl _dashboardControl;
    private readonly FleetControl _fleetControl;
    private readonly CustomersControl _customersControl;
    private readonly RentalControl _rentalControl;
    private readonly ReturnsControl _returnsControl;
    private readonly SuppliersControl _suppliersControl;
    private readonly ReportsControl _reportsControl;

    public AdminForm()
    {
        InitializeComponent();
        LogoutButtonHelper.AddLogoutButton(this);

        _dashboardControl = new DashboardControl();
        _fleetControl = new FleetControl();
        _customersControl = new CustomersControl();
        _rentalControl = new RentalControl();
        _returnsControl = new ReturnsControl();
        _suppliersControl = new SuppliersControl();
        _reportsControl = new ReportsControl();
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {
        // Subscribe Paint event handlers for left accent bar effect
        SubscribeButtonPaintEvents();
        ShowPanel(_dashboardControl, btnDashboard);
    }

    private void SubscribeButtonPaintEvents()
    {
        var buttons = new[] { btnDashboard, btnFleet, btnCustomers, btnRentals, btnReturns, btnSuppliers, btnReports };
        foreach (var btn in buttons)
        {
            btn.Paint += IconButton_Paint;
        }
    }

    private void IconButton_Paint(object sender, PaintEventArgs e)
    {
        if (sender is IconButton btn && btn.ForeColor == Color.FromArgb(0, 210, 190))
        {
            // Draw 3px left accent bar for active buttons
            using (Brush brush = new SolidBrush(Color.FromArgb(0, 210, 190)))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 3, btn.Height);
            }
        }
    }

    private void ShowPanel(UserControl panel, Button activeBtn)
    {
        pnlContent.Controls.Clear();
        panel.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(panel);

        // Set all buttons to inactive state
        foreach (Control control in pnlSidebar.Controls)
        {
            if (control is Button btn)
            {
                btn.BackColor = Color.FromArgb(10, 10, 15);
                btn.ForeColor = Color.FromArgb(180, 180, 180);

                if (btn is IconButton iconBtn)
                {
                    iconBtn.IconColor = Color.FromArgb(80, 80, 100);
                }
            }
        }

        // Set active button state
        activeBtn.BackColor = Color.FromArgb(0, 30, 28);
        activeBtn.ForeColor = Color.FromArgb(0, 210, 190);

        if (activeBtn is IconButton activeIcon)
        {
            activeIcon.IconColor = Color.FromArgb(0, 210, 190);
        }

        // Redraw all buttons to update accent bar visibility
        foreach (Control control in pnlSidebar.Controls)
        {
            if (control is IconButton btn)
            {
                btn.Invalidate();
            }
        }

        if (panel is DashboardControl dashboard)
        {
            dashboard.LoadDashboard();
        }
    }

    private void btnDashboard_Click(object sender, EventArgs e) => ShowPanel(_dashboardControl, btnDashboard);
    private void btnFleet_Click(object sender, EventArgs e) => ShowPanel(_fleetControl, btnFleet);
    private void btnCustomers_Click(object sender, EventArgs e) => ShowPanel(_customersControl, btnCustomers);
    private void btnRentals_Click(object sender, EventArgs e) => ShowPanel(_rentalControl, btnRentals);
    private void btnReturns_Click(object sender, EventArgs e) => ShowPanel(_returnsControl, btnReturns);
    private void btnSuppliers_Click(object sender, EventArgs e) => ShowPanel(_suppliersControl, btnSuppliers);
    private void btnReports_Click(object sender, EventArgs e) => ShowPanel(_reportsControl, btnReports);
}
