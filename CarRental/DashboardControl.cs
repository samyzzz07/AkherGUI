using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class DashboardControl : UserControl
{
    private DashboardDB db = new DashboardDB();

    public DashboardControl()
    {
        InitializeComponent();
        Load += DashboardControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }

    private void DashboardControl_Load(object? sender, EventArgs e)
    {
        LoadDashboard();
    }

    public void LoadDashboard()
    {
        try
        {
            LoadKPIs();
            LoadRecentRentals();
            LoadFleetStatus();
            LoadTopVehicleBars();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadDashboard);
            return;
        }

        LoadDashboard();
    }

    private void LoadKPIs()
    {
        lblFleet.Text = db.GetTotalFleetCount().ToString();
        lblAvailable.Text = db.GetAvailableCarsCount().ToString();
        lblActiveRentals.Text = db.GetActiveRentalsCount().ToString();
        lblRevenue.Text = "$" + db.GetMonthlyRevenue().ToString("N0");
    }

    private void LoadRecentRentals()
    {
        dgvRecent.DataSource = db.GetRecentRentalsDetailed();

        if (dgvRecent.Columns.Count == 0)
        {
            return;
        }

        dgvRecent.Columns["RentalID"].HeaderText = "ID";
        dgvRecent.Columns["CustomerName"].HeaderText = "Customer";
        dgvRecent.Columns["VehicleModel"].HeaderText = "Vehicle";
        dgvRecent.Columns["Status_"].HeaderText = "Status";

        foreach (DataGridViewRow row in dgvRecent.Rows)
        {
            var statusValue = row.Cells["Status_"]?.Value?.ToString() ?? string.Empty;
            var rowFont = new Font(dgvRecent.Font, FontStyle.Bold);

            if (string.Equals(statusValue, "Active", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(6, 95, 70);
                row.DefaultCellStyle.Font = rowFont;
            }
            else if (string.Equals(statusValue, "Overdue", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                row.DefaultCellStyle.Font = rowFont;
            }
            else
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(146, 64, 14);
                row.DefaultCellStyle.Font = rowFont;
            }
        }
    }

    private void LoadFleetStatus()
    {
        dgvFleetStatus.DataSource = db.GetFleetStatusBreakdown();

        if (dgvFleetStatus.Columns.Count == 0)
        {
            return;
        }

        dgvFleetStatus.Columns["Status"].HeaderText = "Status";
        dgvFleetStatus.Columns["Total"].HeaderText = "Count";
        dgvFleetStatus.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private void LoadTopVehicleBars()
    {
        pnlBars.Controls.Clear();
        DataTable dt = db.GetTopVehicles();

        if (dt.Rows.Count == 0)
        {
            return;
        }

        var maxTrips = 0;
        foreach (DataRow row in dt.Rows)
        {
            var trips = Convert.ToInt32(row["TripCount"]);
            if (trips > maxTrips)
            {
                maxTrips = trips;
            }
        }

        if (maxTrips == 0)
        {
            maxTrips = 1;
        }

        foreach (DataRow row in dt.Rows)
        {
            var model = row["Model"]?.ToString() ?? string.Empty;
            var trips = Convert.ToInt32(row["TripCount"]);
            var barWidth = (int)((trips / (double)maxTrips) * 185);

            var rowPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(0, 5, 0, 5)
            };

            var lblModel = new Label
            {
                Width = 85,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = AppTheme.TextSecondary,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point),
                Text = model
            };

            var track = new Panel
            {
                Width = 195,
                Height = 10,
                BackColor = AppTheme.PurpleLight,
                Margin = new Padding(3, 7, 3, 7)
            };

            var fill = new Panel
            {
                Width = barWidth,
                Height = 10,
                BackColor = AppTheme.Accent
            };

            track.Controls.Add(fill);

            var lblTrips = new Label
            {
                Width = 60,
                ForeColor = AppTheme.TextMuted,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point),
                Text = trips + " trips"
            };

            rowPanel.Controls.Add(lblModel);
            rowPanel.Controls.Add(track);
            rowPanel.Controls.Add(lblTrips);

            pnlBars.Controls.Add(rowPanel);
        }
    }
}
