using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CarRental;

partial class AdminForm
{
    private IContainer components = null;
    private Panel pnlSidebar;
    private Panel pnlSidebarBorder;
    private Panel pnlBrand;
    private Label lblBrandName;
    private Label lblBrandSub;
    private Panel pnlSeparator;
    private Label lblOverview;
    private IconButton btnDashboard;
    private Label lblManagement;
    private IconButton btnFleet;
    private IconButton btnCustomers;
    private IconButton btnRentals;
    private IconButton btnReturns;
    private IconButton btnSuppliers;
    private Label lblAnalytics;
    private IconButton btnReports;
    private Panel pnlSidebarBottom;
    private Label lblVersion;
    private Panel pnlContent;

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
        this.components = new Container();
        this.pnlSidebar = new Panel();
        this.pnlSidebarBottom = new Panel();
        this.lblVersion = new Label();
        this.pnlBrand = new Panel();
        this.lblBrandSub = new Label();
        this.lblBrandName = new Label();
        this.pnlSeparator = new Panel();
        this.btnReports = new IconButton();
        this.lblAnalytics = new Label();
        this.btnSuppliers = new IconButton();
        this.btnReturns = new IconButton();
        this.btnRentals = new IconButton();
        this.btnCustomers = new IconButton();
        this.btnFleet = new IconButton();
        this.lblManagement = new Label();
        this.btnDashboard = new IconButton();
        this.lblOverview = new Label();
        this.pnlSidebarBorder = new Panel();
        this.pnlContent = new Panel();
        this.pnlSidebar.SuspendLayout();
        this.pnlSidebarBottom.SuspendLayout();
        this.pnlBrand.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlSidebar
        // 
        this.pnlSidebar.BackColor = Color.FromArgb(10, 10, 15);
        this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);
        this.pnlSidebar.Controls.Add(this.btnReports);
        this.pnlSidebar.Controls.Add(this.lblAnalytics);
        this.pnlSidebar.Controls.Add(this.btnSuppliers);
        this.pnlSidebar.Controls.Add(this.btnReturns);
        this.pnlSidebar.Controls.Add(this.btnRentals);
        this.pnlSidebar.Controls.Add(this.btnCustomers);
        this.pnlSidebar.Controls.Add(this.btnFleet);
        this.pnlSidebar.Controls.Add(this.lblManagement);
        this.pnlSidebar.Controls.Add(this.btnDashboard);
        this.pnlSidebar.Controls.Add(this.lblOverview);
        this.pnlSidebar.Controls.Add(this.pnlSeparator);
        this.pnlSidebar.Controls.Add(this.pnlBrand);
        this.pnlSidebar.Controls.Add(this.pnlSidebarBorder);
        this.pnlSidebar.Dock = DockStyle.Left;
        this.pnlSidebar.Location = new Point(0, 0);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Size = new Size(240, 720);
        this.pnlSidebar.TabIndex = 0;
        // 
        // pnlSidebarBorder
        // 
        this.pnlSidebarBorder.BackColor = Color.FromArgb(0, 210, 190);
        this.pnlSidebarBorder.Dock = DockStyle.Right;
        this.pnlSidebarBorder.Location = new Point(239, 0);
        this.pnlSidebarBorder.Name = "pnlSidebarBorder";
        this.pnlSidebarBorder.Size = new Size(1, 720);
        this.pnlSidebarBorder.TabIndex = 11;
        // 
        // pnlBrand
        // 
        this.pnlBrand.BackColor = Color.FromArgb(10, 10, 15);
        this.pnlBrand.Controls.Add(this.lblBrandSub);
        this.pnlBrand.Controls.Add(this.lblBrandName);
        this.pnlBrand.Dock = DockStyle.Top;
        this.pnlBrand.Location = new Point(0, 0);
        this.pnlBrand.Name = "pnlBrand";
        this.pnlBrand.Size = new Size(239, 100);
        this.pnlBrand.TabIndex = 0;
        // 
        // lblBrandName
        // 
        this.lblBrandName.AutoSize = true;
        this.lblBrandName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        this.lblBrandName.ForeColor = Color.FromArgb(0, 210, 190);
        this.lblBrandName.Location = new Point(20, 28);
        this.lblBrandName.Name = "lblBrandName";
        this.lblBrandName.Size = new Size(95, 25);
        this.lblBrandName.TabIndex = 0;
        this.lblBrandName.Text = "DriveBase";
        // 
        // lblBrandSub
        // 
        this.lblBrandSub.AutoSize = true;
        this.lblBrandSub.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        this.lblBrandSub.ForeColor = Color.FromArgb(80, 80, 100);
        this.lblBrandSub.Location = new Point(22, 58);
        this.lblBrandSub.Name = "lblBrandSub";
        this.lblBrandSub.Size = new Size(91, 13);
        this.lblBrandSub.TabIndex = 1;
        this.lblBrandSub.Text = "Admin Panel";
        // 
        // pnlSeparator
        // 
        this.pnlSeparator.BackColor = Color.FromArgb(30, 30, 45);
        this.pnlSeparator.Dock = DockStyle.Top;
        this.pnlSeparator.Location = new Point(0, 100);
        this.pnlSeparator.Name = "pnlSeparator";
        this.pnlSeparator.Size = new Size(239, 1);
        this.pnlSeparator.TabIndex = 12;
        // 
        // lblOverview
        // 
        this.lblOverview.Dock = DockStyle.Top;
        this.lblOverview.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        this.lblOverview.ForeColor = Color.FromArgb(0, 210, 190);
        this.lblOverview.Location = new Point(0, 101);
        this.lblOverview.Name = "lblOverview";
        this.lblOverview.Padding = new Padding(20, 10, 0, 0);
        this.lblOverview.Size = new Size(239, 30);
        this.lblOverview.TabIndex = 1;
        this.lblOverview.Text = "OVERVIEW";
        // 
        // btnDashboard
        // 
        this.btnDashboard.BackColor = Color.FromArgb(10, 10, 15);
        this.btnDashboard.Dock = DockStyle.Top;
        this.btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnDashboard.FlatAppearance.BorderSize = 0;
        this.btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnDashboard.FlatStyle = FlatStyle.Flat;
        this.btnDashboard.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnDashboard.IconChar = IconChar.TableColumns;
        this.btnDashboard.IconColor = Color.FromArgb(80, 80, 100);
        this.btnDashboard.IconFont = IconFont.Auto;
        this.btnDashboard.IconSize = 20;
        this.btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnDashboard.Location = new Point(0, 131);
        this.btnDashboard.Name = "btnDashboard";
        this.btnDashboard.Padding = new Padding(20, 0, 0, 0);
        this.btnDashboard.Size = new Size(239, 52);
        this.btnDashboard.TabIndex = 2;
        this.btnDashboard.Text = " Dashboard";
        this.btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        this.btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnDashboard.UseVisualStyleBackColor = false;
        this.btnDashboard.Font = new Font("Segoe UI", 10F);
        this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
        // 
        // lblManagement
        // 
        this.lblManagement.Dock = DockStyle.Top;
        this.lblManagement.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        this.lblManagement.ForeColor = Color.FromArgb(0, 210, 190);
        this.lblManagement.Location = new Point(0, 183);
        this.lblManagement.Name = "lblManagement";
        this.lblManagement.Padding = new Padding(20, 10, 0, 0);
        this.lblManagement.Size = new Size(239, 30);
        this.lblManagement.TabIndex = 3;
        this.lblManagement.Text = "MANAGEMENT";
        // 
        // btnFleet
        // 
        this.btnFleet.BackColor = Color.FromArgb(10, 10, 15);
        this.btnFleet.Dock = DockStyle.Top;
        this.btnFleet.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnFleet.FlatAppearance.BorderSize = 0;
        this.btnFleet.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnFleet.FlatStyle = FlatStyle.Flat;
        this.btnFleet.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnFleet.IconChar = IconChar.Car;
        this.btnFleet.IconColor = Color.FromArgb(80, 80, 100);
        this.btnFleet.IconFont = IconFont.Auto;
        this.btnFleet.IconSize = 20;
        this.btnFleet.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnFleet.Location = new Point(0, 213);
        this.btnFleet.Name = "btnFleet";
        this.btnFleet.Padding = new Padding(20, 0, 0, 0);
        this.btnFleet.Size = new Size(239, 52);
        this.btnFleet.TabIndex = 4;
        this.btnFleet.Text = " Fleet / Cars";
        this.btnFleet.TextAlign = ContentAlignment.MiddleLeft;
        this.btnFleet.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnFleet.UseVisualStyleBackColor = false;
        this.btnFleet.Font = new Font("Segoe UI", 10F);
        this.btnFleet.Click += new System.EventHandler(this.btnFleet_Click);
        // 
        // btnCustomers
        // 
        this.btnCustomers.BackColor = Color.FromArgb(10, 10, 15);
        this.btnCustomers.Dock = DockStyle.Top;
        this.btnCustomers.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnCustomers.FlatAppearance.BorderSize = 0;
        this.btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnCustomers.FlatStyle = FlatStyle.Flat;
        this.btnCustomers.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnCustomers.IconChar = IconChar.Users;
        this.btnCustomers.IconColor = Color.FromArgb(80, 80, 100);
        this.btnCustomers.IconFont = IconFont.Auto;
        this.btnCustomers.IconSize = 20;
        this.btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnCustomers.Location = new Point(0, 265);
        this.btnCustomers.Name = "btnCustomers";
        this.btnCustomers.Padding = new Padding(20, 0, 0, 0);
        this.btnCustomers.Size = new Size(239, 52);
        this.btnCustomers.TabIndex = 5;
        this.btnCustomers.Text = " Customers";
        this.btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
        this.btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnCustomers.UseVisualStyleBackColor = false;
        this.btnCustomers.Font = new Font("Segoe UI", 10F);
        this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
        // 
        // btnRentals
        // 
        this.btnRentals.BackColor = Color.FromArgb(10, 10, 15);
        this.btnRentals.Dock = DockStyle.Top;
        this.btnRentals.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnRentals.FlatAppearance.BorderSize = 0;
        this.btnRentals.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnRentals.FlatStyle = FlatStyle.Flat;
        this.btnRentals.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnRentals.IconChar = IconChar.CalendarPlus;
        this.btnRentals.IconColor = Color.FromArgb(80, 80, 100);
        this.btnRentals.IconFont = IconFont.Auto;
        this.btnRentals.IconSize = 20;
        this.btnRentals.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnRentals.Location = new Point(0, 317);
        this.btnRentals.Name = "btnRentals";
        this.btnRentals.Padding = new Padding(20, 0, 0, 0);
        this.btnRentals.Size = new Size(239, 52);
        this.btnRentals.TabIndex = 6;
        this.btnRentals.Text = " New Rental";
        this.btnRentals.TextAlign = ContentAlignment.MiddleLeft;
        this.btnRentals.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnRentals.UseVisualStyleBackColor = false;
        this.btnRentals.Font = new Font("Segoe UI", 10F);
        this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
        // 
        // btnReturns
        // 
        this.btnReturns.BackColor = Color.FromArgb(10, 10, 15);
        this.btnReturns.Dock = DockStyle.Top;
        this.btnReturns.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnReturns.FlatAppearance.BorderSize = 0;
        this.btnReturns.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnReturns.FlatStyle = FlatStyle.Flat;
        this.btnReturns.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnReturns.IconChar = IconChar.RotateLeft;
        this.btnReturns.IconColor = Color.FromArgb(80, 80, 100);
        this.btnReturns.IconFont = IconFont.Auto;
        this.btnReturns.IconSize = 20;
        this.btnReturns.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnReturns.Location = new Point(0, 369);
        this.btnReturns.Name = "btnReturns";
        this.btnReturns.Padding = new Padding(20, 0, 0, 0);
        this.btnReturns.Size = new Size(239, 52);
        this.btnReturns.TabIndex = 7;
        this.btnReturns.Text = " Returns";
        this.btnReturns.TextAlign = ContentAlignment.MiddleLeft;
        this.btnReturns.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnReturns.UseVisualStyleBackColor = false;
        this.btnReturns.Font = new Font("Segoe UI", 10F);
        this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
        // 
        // btnSuppliers
        // 
        this.btnSuppliers.BackColor = Color.FromArgb(10, 10, 15);
        this.btnSuppliers.Dock = DockStyle.Top;
        this.btnSuppliers.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnSuppliers.FlatAppearance.BorderSize = 0;
        this.btnSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnSuppliers.FlatStyle = FlatStyle.Flat;
        this.btnSuppliers.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnSuppliers.IconChar = IconChar.Truck;
        this.btnSuppliers.IconColor = Color.FromArgb(80, 80, 100);
        this.btnSuppliers.IconFont = IconFont.Auto;
        this.btnSuppliers.IconSize = 20;
        this.btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnSuppliers.Location = new Point(0, 421);
        this.btnSuppliers.Name = "btnSuppliers";
        this.btnSuppliers.Padding = new Padding(20, 0, 0, 0);
        this.btnSuppliers.Size = new Size(239, 52);
        this.btnSuppliers.TabIndex = 8;
        this.btnSuppliers.Text = " Suppliers";
        this.btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
        this.btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnSuppliers.UseVisualStyleBackColor = false;
        this.btnSuppliers.Font = new Font("Segoe UI", 10F);
        this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
        // 
        // lblAnalytics
        // 
        this.lblAnalytics.Dock = DockStyle.Top;
        this.lblAnalytics.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
        this.lblAnalytics.ForeColor = Color.FromArgb(0, 210, 190);
        this.lblAnalytics.Location = new Point(0, 473);
        this.lblAnalytics.Name = "lblAnalytics";
        this.lblAnalytics.Padding = new Padding(20, 10, 0, 0);
        this.lblAnalytics.Size = new Size(239, 30);
        this.lblAnalytics.TabIndex = 9;
        this.lblAnalytics.Text = "ANALYTICS";
        // 
        // btnReports
        // 
        this.btnReports.BackColor = Color.FromArgb(10, 10, 15);
        this.btnReports.Dock = DockStyle.Top;
        this.btnReports.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        this.btnReports.FlatAppearance.BorderSize = 0;
        this.btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 35, 32);
        this.btnReports.FlatStyle = FlatStyle.Flat;
        this.btnReports.ForeColor = Color.FromArgb(180, 180, 180);
        this.btnReports.IconChar = IconChar.ChartBar;
        this.btnReports.IconColor = Color.FromArgb(80, 80, 100);
        this.btnReports.IconFont = IconFont.Auto;
        this.btnReports.IconSize = 20;
        this.btnReports.ImageAlign = ContentAlignment.MiddleLeft;
        this.btnReports.Location = new Point(0, 503);
        this.btnReports.Name = "btnReports";
        this.btnReports.Padding = new Padding(20, 0, 0, 0);
        this.btnReports.Size = new Size(239, 52);
        this.btnReports.TabIndex = 10;
        this.btnReports.Text = " Reports";
        this.btnReports.TextAlign = ContentAlignment.MiddleLeft;
        this.btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        this.btnReports.UseVisualStyleBackColor = false;
        this.btnReports.Font = new Font("Segoe UI", 10F);
        this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
        // 
        // pnlSidebarBottom
        // 
        this.pnlSidebarBottom.BackColor = Color.FromArgb(10, 10, 15);
        this.pnlSidebarBottom.Controls.Add(this.lblVersion);
        this.pnlSidebarBottom.Dock = DockStyle.Bottom;
        this.pnlSidebarBottom.Location = new Point(0, 660);
        this.pnlSidebarBottom.Name = "pnlSidebarBottom";
        this.pnlSidebarBottom.Size = new Size(239, 60);
        this.pnlSidebarBottom.TabIndex = 13;
        // 
        // lblVersion
        // 
        this.lblVersion.AutoSize = false;
        this.lblVersion.Font = new Font("Segoe UI", 8F);
        this.lblVersion.ForeColor = Color.FromArgb(50, 50, 70);
        this.lblVersion.Location = new Point(0, 20);
        this.lblVersion.Name = "lblVersion";
        this.lblVersion.Size = new Size(239, 20);
        this.lblVersion.TabIndex = 0;
        this.lblVersion.Text = "v1.0";
        this.lblVersion.TextAlign = ContentAlignment.TopCenter;
        // 
        // pnlContent
        // 
        this.pnlContent.BackColor = Color.FromArgb(15, 15, 22);
        this.pnlContent.Dock = DockStyle.Fill;
        this.pnlContent.Location = new Point(240, 0);
        this.pnlContent.Name = "pnlContent";
        this.pnlContent.Size = new Size(1040, 720);
        this.pnlContent.TabIndex = 1;
        // 
        // AdminForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(15, 15, 22);
        this.ClientSize = new Size(1280, 720);
        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.pnlSidebar);
        this.Name = "AdminForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "DriveBase — Admin";
        this.Load += new System.EventHandler(this.AdminForm_Load);
        this.pnlSidebar.ResumeLayout(false);
        this.pnlSidebarBottom.ResumeLayout(false);
        this.pnlBrand.ResumeLayout(false);
        this.pnlBrand.PerformLayout();
        this.ResumeLayout(false);
    }
}
