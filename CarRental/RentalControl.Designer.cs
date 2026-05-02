using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class RentalControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblTitle;
    private Label lblSubtitle;
    private Panel pnlMain;
    private Panel pnlActions;
    private Button btnSelect;
    private Panel pnlLeft;
    private Panel pnlCustomer;
    private Label lblCustomerSection;
    private Label lblSSN;
    private TextBox txtSSN;
    private Button btnLookup;
    private Label lblCustomerName;
    private TextBox txtCustomerName;
    private Label lblStartDate;
    private DateTimePicker dtpStart;
    private Label lblEndDate;
    private DateTimePicker dtpEnd;
    private Panel pnlVehicles;
    private Label lblVehiclesSection;
    private DataGridView dgvAvailable;
    private Panel pnlRight;
    private Panel pnlSummary;
    private Label lblSummaryTitle;
    private Label lblVehicleVal;
    private Label lblDurationTitle;
    private Label lblDurationVal;
    private Label lblRateTitle;
    private Label lblRateVal;
    private Label lblSubtotalTitle;
    private Label lblSubtotalVal;
    private Label lblTaxTitle;
    private Label lblTaxVal;
    private Panel pnlSeparator;
    private Label lblTotal;
    private Button btnConfirm;
    private CheckBox chkReserveWithoutPayment;

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
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlMain = new Panel();
        pnlRight = new Panel();
        pnlSummary = new Panel();
        btnConfirm = new Button();
        chkReserveWithoutPayment = new CheckBox();
        lblTotal = new Label();
        pnlSeparator = new Panel();
        lblTaxVal = new Label();
        lblTaxTitle = new Label();
        lblSubtotalVal = new Label();
        lblSubtotalTitle = new Label();
        lblRateVal = new Label();
        lblRateTitle = new Label();
        lblDurationVal = new Label();
        lblDurationTitle = new Label();
        lblVehicleVal = new Label();
        lblSummaryTitle = new Label();
        pnlLeft = new Panel();
        pnlVehicles = new Panel();
        dgvAvailable = new DataGridView();
        lblVehiclesSection = new Label();
        pnlActions = new Panel();
        btnSelect = new Button();
        pnlCustomer = new Panel();
        lblEndDate = new Label();
        dtpEnd = new DateTimePicker();
        lblStartDate = new Label();
        dtpStart = new DateTimePicker();
        txtCustomerName = new TextBox();
        lblCustomerName = new Label();
        btnLookup = new Button();
        txtSSN = new TextBox();
        lblCustomerSection = new Label();
        pnlTopBar.SuspendLayout();
        pnlMain.SuspendLayout();
        pnlRight.SuspendLayout();
        pnlSummary.SuspendLayout();
        pnlLeft.SuspendLayout();
        pnlVehicles.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
        pnlActions.SuspendLayout();
        pnlCustomer.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(lblSubtitle);
        pnlTopBar.Controls.Add(lblTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 80);
        pnlTopBar.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblSubtitle.Location = new Point(30, 52);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(179, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Complete all fields below";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(28, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "New Rental";
        // 
        // pnlMain
        // 
        pnlMain.BackColor = Color.FromArgb(15, 15, 22);
        pnlMain.Controls.Add(pnlRight);
        pnlMain.Controls.Add(pnlLeft);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 80);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new Padding(24, 20, 24, 20);
        pnlMain.Size = new Size(1103, 827);
        pnlMain.TabIndex = 1;
        // 
        // pnlRight
        // 
        pnlRight.BackColor = Color.FromArgb(15, 15, 22);
        pnlRight.Controls.Add(pnlSummary);
        pnlRight.Dock = DockStyle.Fill;
        pnlRight.Location = new Point(684, 20);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new Size(395, 787);
        pnlRight.TabIndex = 1;
        // 
        // pnlSummary
        // 
        pnlSummary.BackColor = Color.FromArgb(10, 10, 15);
        pnlSummary.Controls.Add(btnConfirm);
        pnlSummary.Controls.Add(chkReserveWithoutPayment);
        pnlSummary.Controls.Add(lblTotal);
        pnlSummary.Controls.Add(pnlSeparator);
        pnlSummary.Controls.Add(lblTaxVal);
        pnlSummary.Controls.Add(lblTaxTitle);
        pnlSummary.Controls.Add(lblSubtotalVal);
        pnlSummary.Controls.Add(lblSubtotalTitle);
        pnlSummary.Controls.Add(lblRateVal);
        pnlSummary.Controls.Add(lblRateTitle);
        pnlSummary.Controls.Add(lblDurationVal);
        pnlSummary.Controls.Add(lblDurationTitle);
        pnlSummary.Controls.Add(lblVehicleVal);
        pnlSummary.Controls.Add(lblSummaryTitle);
        pnlSummary.Dock = DockStyle.Top;
        pnlSummary.Location = new Point(0, 0);
        pnlSummary.Name = "pnlSummary";
        pnlSummary.Padding = new Padding(24);
        pnlSummary.Size = new Size(395, 420);
        pnlSummary.TabIndex = 0;
        pnlSummary.Paint += pnlSummary_Paint;
        // 
        // btnConfirm
        // 
        btnConfirm.BackColor = Color.FromArgb(0, 210, 190);
        btnConfirm.Dock = DockStyle.Bottom;
        btnConfirm.FlatAppearance.BorderSize = 0;
        btnConfirm.FlatStyle = FlatStyle.Flat;
        btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnConfirm.ForeColor = Color.FromArgb(10, 10, 15);
        btnConfirm.Location = new Point(24, 348);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(347, 48);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Confirm Rental";
        btnConfirm.UseVisualStyleBackColor = false;
        btnConfirm.Click += btnConfirm_Click;
        // 
        // chkReserveWithoutPayment
        // 
        chkReserveWithoutPayment.AutoSize = true;
        chkReserveWithoutPayment.ForeColor = Color.FromArgb(230, 230, 230);
        chkReserveWithoutPayment.Location = new Point(24, 305);
        chkReserveWithoutPayment.Name = "chkReserveWithoutPayment";
        chkReserveWithoutPayment.Size = new Size(200, 24);
        chkReserveWithoutPayment.TabIndex = 12;
        chkReserveWithoutPayment.Text = "Reserve without payment";
        chkReserveWithoutPayment.UseVisualStyleBackColor = true;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(0, 210, 190);
        lblTotal.Location = new Point(24, 230);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(49, 37);
        lblTotal.TabIndex = 11;
        lblTotal.Text = "$0";
        // 
        // pnlSeparator
        // 
        pnlSeparator.BackColor = Color.FromArgb(30, 30, 45);
        pnlSeparator.Location = new Point(24, 210);
        pnlSeparator.Name = "pnlSeparator";
        pnlSeparator.Size = new Size(347, 1);
        pnlSeparator.TabIndex = 10;
        // 
        // lblTaxVal
        // 
        lblTaxVal.AutoSize = true;
        lblTaxVal.Font = new Font("Segoe UI", 8.5F);
        lblTaxVal.ForeColor = Color.FromArgb(220, 220, 220);
        lblTaxVal.Location = new Point(347, 180);
        lblTaxVal.Name = "lblTaxVal";
        lblTaxVal.Size = new Size(25, 20);
        lblTaxVal.TabIndex = 9;
        lblTaxVal.Text = "$0";
        lblTaxVal.TextAlign = ContentAlignment.TopRight;
        // 
        // lblTaxTitle
        // 
        lblTaxTitle.AutoSize = true;
        lblTaxTitle.Font = new Font("Segoe UI", 8.5F);
        lblTaxTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblTaxTitle.Location = new Point(24, 180);
        lblTaxTitle.Name = "lblTaxTitle";
        lblTaxTitle.Size = new Size(72, 20);
        lblTaxTitle.TabIndex = 8;
        lblTaxTitle.Text = "Tax (14%)";
        // 
        // lblSubtotalVal
        // 
        lblSubtotalVal.AutoSize = true;
        lblSubtotalVal.Font = new Font("Segoe UI", 8.5F);
        lblSubtotalVal.ForeColor = Color.FromArgb(220, 220, 220);
        lblSubtotalVal.Location = new Point(347, 150);
        lblSubtotalVal.Name = "lblSubtotalVal";
        lblSubtotalVal.Size = new Size(25, 20);
        lblSubtotalVal.TabIndex = 7;
        lblSubtotalVal.Text = "$0";
        lblSubtotalVal.TextAlign = ContentAlignment.TopRight;
        // 
        // lblSubtotalTitle
        // 
        lblSubtotalTitle.AutoSize = true;
        lblSubtotalTitle.Font = new Font("Segoe UI", 8.5F);
        lblSubtotalTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblSubtotalTitle.Location = new Point(24, 150);
        lblSubtotalTitle.Name = "lblSubtotalTitle";
        lblSubtotalTitle.Size = new Size(65, 20);
        lblSubtotalTitle.TabIndex = 6;
        lblSubtotalTitle.Text = "Subtotal";
        // 
        // lblRateVal
        // 
        lblRateVal.AutoSize = true;
        lblRateVal.Font = new Font("Segoe UI", 8.5F);
        lblRateVal.ForeColor = Color.FromArgb(220, 220, 220);
        lblRateVal.Location = new Point(347, 120);
        lblRateVal.Name = "lblRateVal";
        lblRateVal.Size = new Size(25, 20);
        lblRateVal.TabIndex = 5;
        lblRateVal.Text = "$0";
        lblRateVal.TextAlign = ContentAlignment.TopRight;
        // 
        // lblRateTitle
        // 
        lblRateTitle.AutoSize = true;
        lblRateTitle.Font = new Font("Segoe UI", 8.5F);
        lblRateTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblRateTitle.Location = new Point(24, 120);
        lblRateTitle.Name = "lblRateTitle";
        lblRateTitle.Size = new Size(39, 20);
        lblRateTitle.TabIndex = 4;
        lblRateTitle.Text = "Rate";
        // 
        // lblDurationVal
        // 
        lblDurationVal.AutoSize = true;
        lblDurationVal.Font = new Font("Segoe UI", 8.5F);
        lblDurationVal.ForeColor = Color.FromArgb(220, 220, 220);
        lblDurationVal.Location = new Point(347, 90);
        lblDurationVal.Name = "lblDurationVal";
        lblDurationVal.Size = new Size(51, 20);
        lblDurationVal.TabIndex = 3;
        lblDurationVal.Text = "0 days";
        lblDurationVal.TextAlign = ContentAlignment.TopRight;
        // 
        // lblDurationTitle
        // 
        lblDurationTitle.AutoSize = true;
        lblDurationTitle.Font = new Font("Segoe UI", 8.5F);
        lblDurationTitle.ForeColor = Color.FromArgb(80, 80, 100);
        lblDurationTitle.Location = new Point(24, 90);
        lblDurationTitle.Name = "lblDurationTitle";
        lblDurationTitle.Size = new Size(67, 20);
        lblDurationTitle.TabIndex = 2;
        lblDurationTitle.Text = "Duration";
        // 
        // lblVehicleVal
        // 
        lblVehicleVal.AutoSize = true;
        lblVehicleVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblVehicleVal.ForeColor = Color.FromArgb(0, 210, 190);
        lblVehicleVal.Location = new Point(24, 50);
        lblVehicleVal.Name = "lblVehicleVal";
        lblVehicleVal.Size = new Size(197, 28);
        lblVehicleVal.TabIndex = 1;
        lblVehicleVal.Text = "No vehicle selected";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblSummaryTitle.Location = new Point(24, 24);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(150, 19);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "BOOKING SUMMARY";
        // 
        // pnlLeft
        // 
        pnlLeft.BackColor = Color.FromArgb(15, 15, 22);
        pnlLeft.Controls.Add(pnlVehicles);
        pnlLeft.Controls.Add(pnlActions);
        pnlLeft.Controls.Add(pnlCustomer);
        pnlLeft.Dock = DockStyle.Left;
        pnlLeft.Location = new Point(24, 20);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new Size(660, 787);
        pnlLeft.TabIndex = 0;
        // 
        // pnlVehicles
        // 
        pnlVehicles.BackColor = Color.FromArgb(22, 22, 32);
        pnlVehicles.Controls.Add(dgvAvailable);
        pnlVehicles.Controls.Add(lblVehiclesSection);
        pnlVehicles.Dock = DockStyle.Fill;
        pnlVehicles.Location = new Point(0, 270);
        pnlVehicles.Name = "pnlVehicles";
        pnlVehicles.Padding = new Padding(20, 16, 20, 16);
        pnlVehicles.Size = new Size(660, 517);
        pnlVehicles.TabIndex = 1;
        // 
        // dgvAvailable
        // 
        dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAvailable.Location = new Point(20, 45);
        dgvAvailable.Name = "dgvAvailable";
        dgvAvailable.RowHeadersWidth = 51;
        dgvAvailable.Size = new Size(620, 523);
        dgvAvailable.TabIndex = 1;
        dgvAvailable.CellClick += dgvAvailable_CellClick;
        // 
        // lblVehiclesSection
        // 
        lblVehiclesSection.AutoSize = true;
        lblVehiclesSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblVehiclesSection.ForeColor = Color.FromArgb(0, 210, 190);
        lblVehiclesSection.Location = new Point(20, 16);
        lblVehiclesSection.Name = "lblVehiclesSection";
        lblVehiclesSection.Size = new Size(113, 19);
        lblVehiclesSection.TabIndex = 0;
        lblVehiclesSection.Text = "SELECT VEHICLE";
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.FromArgb(22, 22, 32);
        pnlActions.Controls.Add(btnSelect);
        pnlActions.Dock = DockStyle.Top;
        pnlActions.Location = new Point(0, 200);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(20, 16, 20, 16);
        pnlActions.Size = new Size(660, 70);
        pnlActions.TabIndex = 2;
        // 
        // btnSelect
        // 
        btnSelect.BackColor = Color.FromArgb(0, 210, 190);
        btnSelect.Enabled = false;
        btnSelect.FlatAppearance.BorderSize = 0;
        btnSelect.FlatStyle = FlatStyle.Flat;
        btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSelect.ForeColor = Color.FromArgb(15, 15, 22);
        btnSelect.Location = new Point(20, 16);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(150, 40);
        btnSelect.TabIndex = 0;
        btnSelect.Text = "✓ Select Vehicle";
        btnSelect.UseVisualStyleBackColor = false;
        btnSelect.Click += btnSelect_Click;
        // 
        // pnlCustomer
        // 
        pnlCustomer.BackColor = Color.FromArgb(22, 22, 32);
        pnlCustomer.Controls.Add(lblEndDate);
        pnlCustomer.Controls.Add(dtpEnd);
        pnlCustomer.Controls.Add(lblStartDate);
        pnlCustomer.Controls.Add(dtpStart);
        pnlCustomer.Controls.Add(txtCustomerName);
        pnlCustomer.Controls.Add(lblCustomerName);
        pnlCustomer.Controls.Add(btnLookup);
        pnlCustomer.Controls.Add(txtSSN);
        pnlCustomer.Controls.Add(lblCustomerSection);
        pnlCustomer.Dock = DockStyle.Top;
        pnlCustomer.Location = new Point(0, 0);
        pnlCustomer.Name = "pnlCustomer";
        pnlCustomer.Padding = new Padding(20, 16, 20, 16);
        pnlCustomer.Size = new Size(660, 200);
        pnlCustomer.TabIndex = 0;
        // 
        // lblEndDate
        // 
        lblEndDate.AutoSize = true;
        lblEndDate.Font = new Font("Segoe UI", 8F);
        lblEndDate.ForeColor = Color.FromArgb(80, 80, 100);
        lblEndDate.Location = new Point(420, 142);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new Size(65, 19);
        lblEndDate.TabIndex = 7;
        lblEndDate.Text = "End Date";
        // 
        // dtpEnd
        // 
        dtpEnd.BackColor = Color.FromArgb(22, 22, 32);
        dtpEnd.Font = new Font("Segoe UI", 9F);
        dtpEnd.ForeColor = Color.FromArgb(220, 220, 220);
        dtpEnd.Format = DateTimePickerFormat.Short;
        dtpEnd.Location = new Point(420, 160);
        dtpEnd.Name = "dtpEnd";
        dtpEnd.MinDate = DateTime.Today.AddDays(1);
        dtpEnd.Size = new Size(220, 27);
        dtpEnd.TabIndex = 8;
        dtpEnd.Value = DateTime.Today.AddDays(1);
        dtpEnd.ValueChanged += dtpEnd_ValueChanged;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Font = new Font("Segoe UI", 8F);
        lblStartDate.ForeColor = Color.FromArgb(80, 80, 100);
        lblStartDate.Location = new Point(20, 142);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(71, 19);
        lblStartDate.TabIndex = 5;
        lblStartDate.Text = "Start Date";
        // 
        // dtpStart
        // 
        dtpStart.BackColor = Color.FromArgb(22, 22, 32);
        dtpStart.CalendarMonthBackground = Color.White;
        dtpStart.Font = new Font("Segoe UI", 9F);
        dtpStart.ForeColor = Color.FromArgb(220, 220, 220);
        dtpStart.Format = DateTimePickerFormat.Short;
        dtpStart.Location = new Point(20, 160);
        dtpStart.Name = "dtpStart";
        dtpStart.MinDate = DateTime.Today;
        dtpStart.Size = new Size(220, 27);
        dtpStart.TabIndex = 6;
        dtpStart.Value = DateTime.Today;
        dtpStart.ValueChanged += dtpStart_ValueChanged;
        // 
        // txtCustomerName
        // 
        txtCustomerName.BackColor = Color.FromArgb(22, 22, 32);
        txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
        txtCustomerName.Font = new Font("Segoe UI", 9F);
        txtCustomerName.ForeColor = Color.FromArgb(220, 220, 220);
        txtCustomerName.Location = new Point(20, 104);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.ReadOnly = true;
        txtCustomerName.Size = new Size(620, 27);
        txtCustomerName.TabIndex = 4;
        // 
        // lblCustomerName
        // 
        lblCustomerName.AutoSize = true;
        lblCustomerName.Font = new Font("Segoe UI", 8F);
        lblCustomerName.ForeColor = Color.FromArgb(80, 80, 100);
        lblCustomerName.Location = new Point(20, 86);
        lblCustomerName.Name = "lblCustomerName";
        lblCustomerName.Size = new Size(70, 19);
        lblCustomerName.TabIndex = 3;
        lblCustomerName.Text = "Full Name";
        // 
        // btnLookup
        // 
        btnLookup.BackColor = Color.FromArgb(0, 210, 190);
        btnLookup.FlatAppearance.BorderSize = 0;
        btnLookup.FlatStyle = FlatStyle.Flat;
        btnLookup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLookup.ForeColor = Color.FromArgb(10, 10, 15);
        btnLookup.Location = new Point(230, 48);
        btnLookup.Name = "btnLookup";
        btnLookup.Size = new Size(90, 34);
        btnLookup.TabIndex = 2;
        btnLookup.Text = "Find";
        btnLookup.UseVisualStyleBackColor = false;
        btnLookup.Click += btnLookup_Click;
        // 
        // txtSSN
        // 
        txtSSN.BackColor = Color.FromArgb(22, 22, 32);
        txtSSN.BorderStyle = BorderStyle.FixedSingle;
        txtSSN.Font = new Font("Segoe UI", 9F);
        txtSSN.ForeColor = Color.FromArgb(220, 220, 220);
        txtSSN.Location = new Point(20, 48);
        txtSSN.Name = "txtSSN";
        txtSSN.Size = new Size(200, 27);
        txtSSN.TabIndex = 1;
        // 
        // lblCustomerSection
        // 
        lblCustomerSection.AutoSize = true;
        lblCustomerSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblCustomerSection.ForeColor = Color.FromArgb(0, 210, 190);
        lblCustomerSection.Location = new Point(20, 16);
        lblCustomerSection.Name = "lblCustomerSection";
        lblCustomerSection.Size = new Size(140, 19);
        lblCustomerSection.TabIndex = 0;
        lblCustomerSection.Text = "CUSTOMER DETAILS";
        // 
        // RentalControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlMain);
        Controls.Add(pnlTopBar);
        Name = "RentalControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlMain.ResumeLayout(false);
        pnlRight.ResumeLayout(false);
        pnlSummary.ResumeLayout(false);
        pnlSummary.PerformLayout();
        pnlLeft.ResumeLayout(false);
        pnlVehicles.ResumeLayout(false);
        pnlVehicles.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
        pnlActions.ResumeLayout(false);
        pnlCustomer.ResumeLayout(false);
        pnlCustomer.PerformLayout();
        ResumeLayout(false);
    }
}
