using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class DashboardControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblPageTitle;
    private Label lblPageSub;
    private Panel pnlKPI;
    private Panel pnlCard1;
    private Panel pnlCard2;
    private Panel pnlCard3;
    private Panel pnlCard4;
    private Panel pnlCard1Accent;
    private Panel pnlCard2Accent;
    private Panel pnlCard3Accent;
    private Panel pnlCard4Accent;
    private Label lblFleetTitle;
    private Label lblFleet;
    private Label lblFleetDelta;
    private Label lblAvailableTitle;
    private Label lblAvailable;
    private Label lblAvailableDelta;
    private Label lblRentalsTitle;
    private Label lblActiveRentals;
    private Label lblRentalsDelta;
    private Label lblRevenueTitle;
    private Label lblRevenue;
    private Label lblRevenueDelta;
    private Panel pnlMain;
    private Panel pnlLeft;
    private Panel pnlRight;
    private Label lblRecentTitle;
    private DataGridView dgvRecent;
    private Panel pnlFleetStatus;
    private Label lblFleetStatusTitle;
    private DataGridView dgvFleetStatus;
    private Panel pnlTopVehicles;
    private Label lblTopVehiclesTitle;
    private Panel pnlBars;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlTopBar = new Panel();
        lblPageTitle = new Label();
        lblPageSub = new Label();
        pnlKPI = new Panel();
        pnlCard1 = new Panel();
        pnlCard1Accent = new Panel();
        lblFleetTitle = new Label();
        lblFleet = new Label();
        lblFleetDelta = new Label();
        pnlCard2 = new Panel();
        pnlCard2Accent = new Panel();
        lblAvailableTitle = new Label();
        lblAvailable = new Label();
        lblAvailableDelta = new Label();
        pnlCard3 = new Panel();
        pnlCard3Accent = new Panel();
        lblRentalsTitle = new Label();
        lblActiveRentals = new Label();
        lblRentalsDelta = new Label();
        pnlCard4 = new Panel();
        pnlCard4Accent = new Panel();
        lblRevenueTitle = new Label();
        lblRevenue = new Label();
        lblRevenueDelta = new Label();
        pnlMain = new Panel();
        pnlLeft = new Panel();
        lblRecentTitle = new Label();
        dgvRecent = new DataGridView();
        pnlRight = new Panel();
        pnlFleetStatus = new Panel();
        lblFleetStatusTitle = new Label();
        dgvFleetStatus = new DataGridView();
        pnlTopVehicles = new Panel();
        lblTopVehiclesTitle = new Label();
        pnlBars = new Panel();
        pnlTopBar.SuspendLayout();
        pnlKPI.SuspendLayout();
        pnlCard1.SuspendLayout();
        pnlCard2.SuspendLayout();
        pnlCard3.SuspendLayout();
        pnlCard4.SuspendLayout();
        pnlMain.SuspendLayout();
        pnlLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
        pnlRight.SuspendLayout();
        pnlFleetStatus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFleetStatus).BeginInit();
        pnlTopVehicles.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(lblPageSub);
        pnlTopBar.Controls.Add(lblPageTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 80);
        pnlTopBar.TabIndex = 0;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lblPageTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblPageTitle.Location = new Point(28, 16);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(141, 37);
        lblPageTitle.TabIndex = 0;
        lblPageTitle.Text = "Dashboard";
        // 
        // lblPageSub
        // 
        lblPageSub.AutoSize = true;
        lblPageSub.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
        lblPageSub.ForeColor = Color.FromArgb(0, 210, 190);
        lblPageSub.Location = new Point(30, 52);
        lblPageSub.Name = "lblPageSub";
        lblPageSub.Size = new Size(159, 20);
        lblPageSub.TabIndex = 1;
        lblPageSub.Text = "Spring 2026 · Live data";
        // 
        // pnlKPI
        // 
        pnlKPI.BackColor = Color.FromArgb(15, 15, 22);
        pnlKPI.Controls.Add(pnlCard4);
        pnlKPI.Controls.Add(pnlCard3);
        pnlKPI.Controls.Add(pnlCard2);
        pnlKPI.Controls.Add(pnlCard1);
        pnlKPI.Dock = DockStyle.Top;
        pnlKPI.Location = new Point(0, 80);
        pnlKPI.Name = "pnlKPI";
        pnlKPI.Padding = new Padding(24, 16, 24, 16);
        pnlKPI.Size = new Size(1103, 150);
        pnlKPI.TabIndex = 1;
        // 
        // pnlCard1
        // 
        pnlCard1.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard1.Controls.Add(lblFleetDelta);
        pnlCard1.Controls.Add(lblFleet);
        pnlCard1.Controls.Add(lblFleetTitle);
        pnlCard1.Controls.Add(pnlCard1Accent);
        pnlCard1.Location = new Point(24, 16);
        pnlCard1.Name = "pnlCard1";
        pnlCard1.Size = new Size(220, 110);
        pnlCard1.TabIndex = 0;
        // 
        // pnlCard1Accent
        // 
        pnlCard1Accent.BackColor = Color.FromArgb(0, 210, 190);
        pnlCard1Accent.Dock = DockStyle.Left;
        pnlCard1Accent.Location = new Point(0, 0);
        pnlCard1Accent.Name = "pnlCard1Accent";
        pnlCard1Accent.Size = new Size(3, 110);
        pnlCard1Accent.TabIndex = 0;
        // 
        // lblFleetTitle
        // 
        lblFleetTitle.AutoSize = true;
        lblFleetTitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        lblFleetTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblFleetTitle.Location = new Point(8, 8);
        lblFleetTitle.Name = "lblFleetTitle";
        lblFleetTitle.Size = new Size(75, 14);
        lblFleetTitle.TabIndex = 1;
        lblFleetTitle.Text = "TOTAL FLEET";
        // 
        // lblFleet
        // 
        lblFleet.AutoSize = true;
        lblFleet.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        lblFleet.ForeColor = Color.FromArgb(230, 230, 230);
        lblFleet.Location = new Point(8, 26);
        lblFleet.Name = "lblFleet";
        lblFleet.Size = new Size(46, 47);
        lblFleet.TabIndex = 2;
        lblFleet.Text = "0";
        // 
        // lblFleetDelta
        // 
        lblFleetDelta.AutoSize = true;
        lblFleetDelta.Font = new Font("Segoe UI", 8F, GraphicsUnit.Point);
        lblFleetDelta.ForeColor = Color.FromArgb(0, 210, 190);
        lblFleetDelta.Location = new Point(8, 80);
        lblFleetDelta.Name = "lblFleetDelta";
        lblFleetDelta.Size = new Size(35, 16);
        lblFleetDelta.TabIndex = 3;
        lblFleetDelta.Text = "+0%";
        // 
        // pnlCard2
        // 
        pnlCard2.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard2.Controls.Add(lblAvailableDelta);
        pnlCard2.Controls.Add(lblAvailable);
        pnlCard2.Controls.Add(lblAvailableTitle);
        pnlCard2.Controls.Add(pnlCard2Accent);
        pnlCard2.Location = new Point(272, 16);
        pnlCard2.Name = "pnlCard2";
        pnlCard2.Size = new Size(220, 110);
        pnlCard2.TabIndex = 1;
        // 
        // pnlCard2Accent
        // 
        pnlCard2Accent.BackColor = Color.FromArgb(0, 210, 190);
        pnlCard2Accent.Dock = DockStyle.Left;
        pnlCard2Accent.Location = new Point(0, 0);
        pnlCard2Accent.Name = "pnlCard2Accent";
        pnlCard2Accent.Size = new Size(3, 110);
        pnlCard2Accent.TabIndex = 0;
        // 
        // lblAvailableTitle
        // 
        lblAvailableTitle.AutoSize = true;
        lblAvailableTitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        lblAvailableTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblAvailableTitle.Location = new Point(8, 8);
        lblAvailableTitle.Name = "lblAvailableTitle";
        lblAvailableTitle.Size = new Size(64, 14);
        lblAvailableTitle.TabIndex = 1;
        lblAvailableTitle.Text = "AVAILABLE";
        // 
        // lblAvailable
        // 
        lblAvailable.AutoSize = true;
        lblAvailable.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        lblAvailable.ForeColor = Color.FromArgb(230, 230, 230);
        lblAvailable.Location = new Point(8, 26);
        lblAvailable.Name = "lblAvailable";
        lblAvailable.Size = new Size(46, 47);
        lblAvailable.TabIndex = 2;
        lblAvailable.Text = "0";
        // 
        // lblAvailableDelta
        // 
        lblAvailableDelta.AutoSize = true;
        lblAvailableDelta.Font = new Font("Segoe UI", 8F, GraphicsUnit.Point);
        lblAvailableDelta.ForeColor = Color.FromArgb(0, 210, 190);
        lblAvailableDelta.Location = new Point(8, 80);
        lblAvailableDelta.Name = "lblAvailableDelta";
        lblAvailableDelta.Size = new Size(35, 16);
        lblAvailableDelta.TabIndex = 3;
        lblAvailableDelta.Text = "+0%";
        // 
        // pnlCard3
        // 
        pnlCard3.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard3.Controls.Add(lblRentalsDelta);
        pnlCard3.Controls.Add(lblActiveRentals);
        pnlCard3.Controls.Add(lblRentalsTitle);
        pnlCard3.Controls.Add(pnlCard3Accent);
        pnlCard3.Location = new Point(520, 16);
        pnlCard3.Name = "pnlCard3";
        pnlCard3.Size = new Size(220, 110);
        pnlCard3.TabIndex = 2;
        // 
        // pnlCard3Accent
        // 
        pnlCard3Accent.BackColor = Color.FromArgb(0, 210, 190);
        pnlCard3Accent.Dock = DockStyle.Left;
        pnlCard3Accent.Location = new Point(0, 0);
        pnlCard3Accent.Name = "pnlCard3Accent";
        pnlCard3Accent.Size = new Size(3, 110);
        pnlCard3Accent.TabIndex = 0;
        // 
        // lblRentalsTitle
        // 
        lblRentalsTitle.AutoSize = true;
        lblRentalsTitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        lblRentalsTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblRentalsTitle.Location = new Point(8, 8);
        lblRentalsTitle.Name = "lblRentalsTitle";
        lblRentalsTitle.Size = new Size(97, 14);
        lblRentalsTitle.TabIndex = 1;
        lblRentalsTitle.Text = "ACTIVE RENTALS";
        // 
        // lblActiveRentals
        // 
        lblActiveRentals.AutoSize = true;
        lblActiveRentals.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        lblActiveRentals.ForeColor = Color.FromArgb(230, 230, 230);
        lblActiveRentals.Location = new Point(8, 26);
        lblActiveRentals.Name = "lblActiveRentals";
        lblActiveRentals.Size = new Size(46, 47);
        lblActiveRentals.TabIndex = 2;
        lblActiveRentals.Text = "0";
        // 
        // lblRentalsDelta
        // 
        lblRentalsDelta.AutoSize = true;
        lblRentalsDelta.Font = new Font("Segoe UI", 8F, GraphicsUnit.Point);
        lblRentalsDelta.ForeColor = Color.FromArgb(0, 210, 190);
        lblRentalsDelta.Location = new Point(8, 80);
        lblRentalsDelta.Name = "lblRentalsDelta";
        lblRentalsDelta.Size = new Size(35, 16);
        lblRentalsDelta.TabIndex = 3;
        lblRentalsDelta.Text = "+0%";
        // 
        // pnlCard4
        // 
        pnlCard4.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard4.Controls.Add(lblRevenueDelta);
        pnlCard4.Controls.Add(lblRevenue);
        pnlCard4.Controls.Add(lblRevenueTitle);
        pnlCard4.Controls.Add(pnlCard4Accent);
        pnlCard4.Location = new Point(768, 16);
        pnlCard4.Name = "pnlCard4";
        pnlCard4.Size = new Size(220, 110);
        pnlCard4.TabIndex = 3;
        // 
        // pnlCard4Accent
        // 
        pnlCard4Accent.BackColor = Color.FromArgb(0, 210, 190);
        pnlCard4Accent.Dock = DockStyle.Left;
        pnlCard4Accent.Location = new Point(0, 0);
        pnlCard4Accent.Name = "pnlCard4Accent";
        pnlCard4Accent.Size = new Size(3, 110);
        pnlCard4Accent.TabIndex = 0;
        // 
        // lblRevenueTitle
        // 
        lblRevenueTitle.AutoSize = true;
        lblRevenueTitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        lblRevenueTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblRevenueTitle.Location = new Point(8, 8);
        lblRevenueTitle.Name = "lblRevenueTitle";
        lblRevenueTitle.Size = new Size(116, 14);
        lblRevenueTitle.TabIndex = 1;
        lblRevenueTitle.Text = "MONTHLY REVENUE";
        // 
        // lblRevenue
        // 
        lblRevenue.AutoSize = true;
        lblRevenue.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        lblRevenue.ForeColor = Color.FromArgb(230, 230, 230);
        lblRevenue.Location = new Point(8, 26);
        lblRevenue.Name = "lblRevenue";
        lblRevenue.Size = new Size(46, 47);
        lblRevenue.TabIndex = 2;
        lblRevenue.Text = "0";
        // 
        // lblRevenueDelta
        // 
        lblRevenueDelta.AutoSize = true;
        lblRevenueDelta.Font = new Font("Segoe UI", 8F, GraphicsUnit.Point);
        lblRevenueDelta.ForeColor = Color.FromArgb(0, 210, 190);
        lblRevenueDelta.Location = new Point(8, 80);
        lblRevenueDelta.Name = "lblRevenueDelta";
        lblRevenueDelta.Size = new Size(35, 16);
        lblRevenueDelta.TabIndex = 3;
        lblRevenueDelta.Text = "+0%";
        // 
        // pnlMain
        // 
        pnlMain.BackColor = Color.FromArgb(15, 15, 22);
        pnlMain.Controls.Add(pnlRight);
        pnlMain.Controls.Add(pnlLeft);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 230);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new Padding(24, 16, 24, 20);
        pnlMain.Size = new Size(1103, 677);
        pnlMain.TabIndex = 2;
        // 
        // pnlLeft
        // 
        pnlLeft.BackColor = Color.FromArgb(15, 15, 22);
        pnlLeft.Controls.Add(dgvRecent);
        pnlLeft.Controls.Add(lblRecentTitle);
        pnlLeft.Dock = DockStyle.Left;
        pnlLeft.Location = new Point(24, 16);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new Size(580, 641);
        pnlLeft.TabIndex = 0;
        // 
        // lblRecentTitle
        // 
        lblRecentTitle.BackColor = Color.FromArgb(22, 22, 32);
        lblRecentTitle.Dock = DockStyle.Top;
        lblRecentTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblRecentTitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblRecentTitle.Location = new Point(0, 0);
        lblRecentTitle.Name = "lblRecentTitle";
        lblRecentTitle.Size = new Size(580, 44);
        lblRecentTitle.TabIndex = 0;
        lblRecentTitle.Text = "Recent Rentals";
        lblRecentTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblRecentTitle.Padding = new Padding(16, 0, 0, 0);
        // 
        // dgvRecent
        // 
        dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRecent.Dock = DockStyle.Fill;
        dgvRecent.Location = new Point(0, 44);
        dgvRecent.Name = "dgvRecent";
        dgvRecent.RowHeadersWidth = 51;
        dgvRecent.Size = new Size(580, 597);
        dgvRecent.TabIndex = 1;
        // 
        // pnlRight
        // 
        pnlRight.BackColor = Color.FromArgb(15, 15, 22);
        pnlRight.Controls.Add(pnlTopVehicles);
        pnlRight.Controls.Add(pnlFleetStatus);
        pnlRight.Dock = DockStyle.Fill;
        pnlRight.Location = new Point(604, 16);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new Size(475, 641);
        pnlRight.TabIndex = 1;
        // 
        // pnlFleetStatus
        // 
        pnlFleetStatus.BackColor = Color.FromArgb(15, 15, 22);
        pnlFleetStatus.Controls.Add(dgvFleetStatus);
        pnlFleetStatus.Controls.Add(lblFleetStatusTitle);
        pnlFleetStatus.Dock = DockStyle.Top;
        pnlFleetStatus.Location = new Point(0, 0);
        pnlFleetStatus.Name = "pnlFleetStatus";
        pnlFleetStatus.Size = new Size(475, 220);
        pnlFleetStatus.TabIndex = 0;
        // 
        // lblFleetStatusTitle
        // 
        lblFleetStatusTitle.BackColor = Color.FromArgb(22, 22, 32);
        lblFleetStatusTitle.Dock = DockStyle.Top;
        lblFleetStatusTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblFleetStatusTitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblFleetStatusTitle.Location = new Point(0, 0);
        lblFleetStatusTitle.Name = "lblFleetStatusTitle";
        lblFleetStatusTitle.Size = new Size(475, 44);
        lblFleetStatusTitle.TabIndex = 0;
        lblFleetStatusTitle.Text = "Fleet Status";
        lblFleetStatusTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblFleetStatusTitle.Padding = new Padding(16, 0, 0, 0);
        // 
        // dgvFleetStatus
        // 
        dgvFleetStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFleetStatus.Dock = DockStyle.Fill;
        dgvFleetStatus.Location = new Point(0, 44);
        dgvFleetStatus.Name = "dgvFleetStatus";
        dgvFleetStatus.RowHeadersWidth = 51;
        dgvFleetStatus.Size = new Size(475, 176);
        dgvFleetStatus.TabIndex = 1;
        // 
        // pnlTopVehicles
        // 
        pnlTopVehicles.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopVehicles.Controls.Add(pnlBars);
        pnlTopVehicles.Controls.Add(lblTopVehiclesTitle);
        pnlTopVehicles.Dock = DockStyle.Fill;
        pnlTopVehicles.Location = new Point(0, 220);
        pnlTopVehicles.Name = "pnlTopVehicles";
        pnlTopVehicles.Size = new Size(475, 421);
        pnlTopVehicles.TabIndex = 1;
        // 
        // lblTopVehiclesTitle
        // 
        lblTopVehiclesTitle.BackColor = Color.FromArgb(22, 22, 32);
        lblTopVehiclesTitle.Dock = DockStyle.Top;
        lblTopVehiclesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblTopVehiclesTitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblTopVehiclesTitle.Location = new Point(0, 0);
        lblTopVehiclesTitle.Name = "lblTopVehiclesTitle";
        lblTopVehiclesTitle.Size = new Size(475, 44);
        lblTopVehiclesTitle.TabIndex = 0;
        lblTopVehiclesTitle.Text = "Top Vehicles";
        lblTopVehiclesTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblTopVehiclesTitle.Padding = new Padding(16, 0, 0, 0);
        // 
        // pnlBars
        // 
        pnlBars.BackColor = Color.FromArgb(22, 22, 32);
        pnlBars.Dock = DockStyle.Fill;
        pnlBars.AutoScroll = true;
        pnlBars.Location = new Point(0, 44);
        pnlBars.Name = "pnlBars";
        pnlBars.Size = new Size(475, 377);
        pnlBars.TabIndex = 1;
        // 
        // DashboardControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlMain);
        Controls.Add(pnlKPI);
        Controls.Add(pnlTopBar);
        Name = "DashboardControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlKPI.ResumeLayout(false);
        pnlCard1.ResumeLayout(false);
        pnlCard1.PerformLayout();
        pnlCard2.ResumeLayout(false);
        pnlCard2.PerformLayout();
        pnlCard3.ResumeLayout(false);
        pnlCard3.PerformLayout();
        pnlCard4.ResumeLayout(false);
        pnlCard4.PerformLayout();
        pnlMain.ResumeLayout(false);
        pnlLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
        pnlRight.ResumeLayout(false);
        pnlFleetStatus.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvFleetStatus).EndInit();
        pnlTopVehicles.ResumeLayout(false);
        ResumeLayout(false);

        AppTheme.StyleDataGridView(dgvRecent);
        AppTheme.StyleDataGridView(dgvFleetStatus);
    }
}
