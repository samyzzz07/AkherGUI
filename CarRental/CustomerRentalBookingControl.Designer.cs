using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerRentalBookingControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Panel pnlMain;
    private Panel pnlRight;
    private Panel pnlSummary;
    private Button btnConfirm;
    private CheckBox chkReserveWithoutPayment;
    private Label lblTotal;
    private Panel pnlSeparator;
    private Label lblTaxVal;
    private Label lblTaxTitle;
    private Label lblSubtotalVal;
    private Label lblSubtotalTitle;
    private Label lblRateVal;
    private Label lblRateTitle;
    private Label lblDurationVal;
    private Label lblDurationTitle;
    private Label lblVehicleVal;
    private Label lblSummaryTitle;
    private Panel pnlLeft;
    private Panel pnlVehicles;
    private Label lblVehiclesSection;
    private DataGridView dgvAvailable;
    private Panel pnlDatePickers;
    private Label lblEndDate;
    private DateTimePicker dtpEnd;
    private Label lblStore;
    private ComboBox cmbStoreLocations;
    private Label lblStartDate;
    private DateTimePicker dtpStart;
    private Panel pnlActions;
    private Button btnSelect;

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
        label1 = new Label();
        pnlActions = new Panel();
        btnSelect = new Button();
        pnlVehicles = new Panel();
        lblVehiclesSection = new Label();
        pnlDatePickers = new Panel();
        dgvAvailable = new DataGridView();
        lblStore = new Label();
        cmbStoreLocations = new ComboBox();
        lblEndDate = new Label();
        dtpEnd = new DateTimePicker();
        lblStartDate = new Label();
        dtpStart = new DateTimePicker();
        pnlMain.SuspendLayout();
        pnlRight.SuspendLayout();
        pnlSummary.SuspendLayout();
        pnlLeft.SuspendLayout();
        pnlActions.SuspendLayout();
        pnlVehicles.SuspendLayout();
        pnlDatePickers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(32, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(263, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Book a Rental";
        // 
        // pnlMain
        // 
        pnlMain.BackColor = Color.FromArgb(15, 15, 22);
        pnlMain.Controls.Add(pnlRight);
        pnlMain.Controls.Add(pnlLeft);
        pnlMain.Controls.Add(lblTitle);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 0);
        pnlMain.Margin = new Padding(3, 4, 3, 4);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new Padding(16, 19, 16, 19);
        pnlMain.Size = new Size(1103, 834);
        pnlMain.TabIndex = 0;
        // 
        // pnlRight
        // 
        pnlRight.BackColor = Color.FromArgb(15, 15, 22);
        pnlRight.Controls.Add(pnlSummary);
        pnlRight.Dock = DockStyle.Right;
        pnlRight.Location = new Point(669, 19);
        pnlRight.Margin = new Padding(3, 4, 3, 4);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new Size(418, 796);
        pnlRight.TabIndex = 1;
        // 
        // pnlSummary
        // 
        pnlSummary.Anchor = AnchorStyles.Top;
        pnlSummary.BackColor = Color.FromArgb(15, 15, 22);
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
        pnlSummary.Location = new Point(9, 0);
        pnlSummary.Margin = new Padding(3, 4, 3, 4);
        pnlSummary.Name = "pnlSummary";
        pnlSummary.Padding = new Padding(18, 21, 18, 21);
        pnlSummary.Size = new Size(409, 422);
        pnlSummary.TabIndex = 0;
        pnlSummary.Paint += pnlSummary_Paint;
        // 
        // btnConfirm
        // 
        btnConfirm.BackColor = Color.FromArgb(0, 210, 190);
        btnConfirm.Dock = DockStyle.Bottom;
        btnConfirm.FlatAppearance.BorderSize = 0;
        btnConfirm.FlatStyle = FlatStyle.Flat;
        btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnConfirm.ForeColor = Color.FromArgb(10, 10, 15);
        btnConfirm.Location = new Point(18, 365);
        btnConfirm.Margin = new Padding(3, 4, 3, 4);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(373, 36);
        btnConfirm.TabIndex = 12;
        btnConfirm.Text = "Confirm Rental";
        btnConfirm.UseVisualStyleBackColor = false;
        btnConfirm.Click += btnConfirm_Click;
        // 
        // chkReserveWithoutPayment
        // 
        chkReserveWithoutPayment.AutoSize = true;
        chkReserveWithoutPayment.ForeColor = Color.FromArgb(230, 230, 230);
        chkReserveWithoutPayment.Location = new Point(18, 330);
        chkReserveWithoutPayment.Name = "chkReserveWithoutPayment";
        chkReserveWithoutPayment.Size = new Size(198, 24);
        chkReserveWithoutPayment.TabIndex = 13;
        chkReserveWithoutPayment.Text = "Reserve without payment";
        chkReserveWithoutPayment.UseVisualStyleBackColor = true;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(0, 210, 190);
        lblTotal.Location = new Point(18, 280);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(42, 32);
        lblTotal.TabIndex = 11;
        lblTotal.Text = "$0";
        // 
        // pnlSeparator
        // 
        pnlSeparator.BackColor = Color.FromArgb(60, 0, 210, 190);
        pnlSeparator.Location = new Point(18, 261);
        pnlSeparator.Margin = new Padding(3, 4, 3, 4);
        pnlSeparator.Name = "pnlSeparator";
        pnlSeparator.Size = new Size(394, 1);
        pnlSeparator.TabIndex = 10;
        // 
        // lblTaxVal
        // 
        lblTaxVal.AutoSize = true;
        lblTaxVal.ForeColor = Color.FromArgb(230, 230, 230);
        lblTaxVal.Location = new Point(343, 221);
        lblTaxVal.Name = "lblTaxVal";
        lblTaxVal.Size = new Size(25, 20);
        lblTaxVal.TabIndex = 9;
        lblTaxVal.Text = "$0";
        lblTaxVal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblTaxTitle
        // 
        lblTaxTitle.AutoSize = true;
        lblTaxTitle.ForeColor = Color.FromArgb(130, 130, 150);
        lblTaxTitle.Location = new Point(18, 221);
        lblTaxTitle.Name = "lblTaxTitle";
        lblTaxTitle.Size = new Size(72, 20);
        lblTaxTitle.TabIndex = 8;
        lblTaxTitle.Text = "Tax (14%)";
        // 
        // lblSubtotalVal
        // 
        lblSubtotalVal.AutoSize = true;
        lblSubtotalVal.ForeColor = Color.FromArgb(230, 230, 230);
        lblSubtotalVal.Location = new Point(343, 185);
        lblSubtotalVal.Name = "lblSubtotalVal";
        lblSubtotalVal.Size = new Size(25, 20);
        lblSubtotalVal.TabIndex = 7;
        lblSubtotalVal.Text = "$0";
        lblSubtotalVal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblSubtotalTitle
        // 
        lblSubtotalTitle.AutoSize = true;
        lblSubtotalTitle.ForeColor = Color.FromArgb(130, 130, 150);
        lblSubtotalTitle.Location = new Point(18, 185);
        lblSubtotalTitle.Name = "lblSubtotalTitle";
        lblSubtotalTitle.Size = new Size(65, 20);
        lblSubtotalTitle.TabIndex = 6;
        lblSubtotalTitle.Text = "Subtotal";
        // 
        // lblRateVal
        // 
        lblRateVal.AutoSize = true;
        lblRateVal.ForeColor = Color.FromArgb(230, 230, 230);
        lblRateVal.Location = new Point(343, 149);
        lblRateVal.Name = "lblRateVal";
        lblRateVal.Size = new Size(25, 20);
        lblRateVal.TabIndex = 5;
        lblRateVal.Text = "$0";
        lblRateVal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblRateTitle
        // 
        lblRateTitle.AutoSize = true;
        lblRateTitle.ForeColor = Color.FromArgb(130, 130, 150);
        lblRateTitle.Location = new Point(18, 149);
        lblRateTitle.Name = "lblRateTitle";
        lblRateTitle.Size = new Size(39, 20);
        lblRateTitle.TabIndex = 4;
        lblRateTitle.Text = "Rate";
        // 
        // lblDurationVal
        // 
        lblDurationVal.AutoSize = true;
        lblDurationVal.ForeColor = Color.FromArgb(230, 230, 230);
        lblDurationVal.Location = new Point(343, 113);
        lblDurationVal.Name = "lblDurationVal";
        lblDurationVal.Size = new Size(51, 20);
        lblDurationVal.TabIndex = 3;
        lblDurationVal.Text = "0 days";
        lblDurationVal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblDurationTitle
        // 
        lblDurationTitle.AutoSize = true;
        lblDurationTitle.ForeColor = Color.FromArgb(130, 130, 150);
        lblDurationTitle.Location = new Point(18, 113);
        lblDurationTitle.Name = "lblDurationTitle";
        lblDurationTitle.Size = new Size(67, 20);
        lblDurationTitle.TabIndex = 2;
        lblDurationTitle.Text = "Duration";
        // 
        // lblVehicleVal
        // 
        lblVehicleVal.AutoSize = true;
        lblVehicleVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblVehicleVal.ForeColor = Color.FromArgb(0, 210, 190);
        lblVehicleVal.Location = new Point(18, 60);
        lblVehicleVal.Name = "lblVehicleVal";
        lblVehicleVal.Size = new Size(180, 25);
        lblVehicleVal.TabIndex = 1;
        lblVehicleVal.Text = "No vehicle selected";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSummaryTitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblSummaryTitle.Location = new Point(18, 21);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new Size(127, 20);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "COST SUMMARY";
        // 
        // pnlLeft
        // 
        pnlLeft.BackColor = Color.FromArgb(15, 15, 22);
        pnlLeft.Controls.Add(label1);
        pnlLeft.Controls.Add(pnlActions);
        pnlLeft.Controls.Add(pnlVehicles);
        pnlLeft.Dock = DockStyle.Left;
        pnlLeft.Location = new Point(16, 19);
        pnlLeft.Margin = new Padding(3, 4, 3, 4);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Padding = new Padding(0, 100, 11, 0);
        pnlLeft.Size = new Size(647, 796);
        pnlLeft.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        label1.ForeColor = Color.White;
        label1.Location = new Point(16, 21);
        label1.Name = "label1";
        label1.Size = new Size(299, 64);
        label1.TabIndex = 4;
        label1.Text = "Make A Rental ";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.FromArgb(22, 22, 32);
        pnlActions.Controls.Add(btnSelect);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(0, 742);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(8);
        pnlActions.Size = new Size(636, 54);
        pnlActions.TabIndex = 2;
        // 
        // btnSelect
        // 
        btnSelect.BackColor = Color.FromArgb(0, 210, 190);
        btnSelect.Enabled = false;
        btnSelect.FlatStyle = FlatStyle.Flat;
        btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSelect.ForeColor = Color.FromArgb(10, 10, 15);
        btnSelect.Location = new Point(8, 0);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(150, 44);
        btnSelect.TabIndex = 0;
        btnSelect.Text = "✓ Select Vehicle";
        btnSelect.UseVisualStyleBackColor = false;
        btnSelect.Click += btnSelect_Click;
        // 
        // pnlVehicles
        // 
        pnlVehicles.BackColor = Color.FromArgb(22, 22, 32);
        pnlVehicles.Controls.Add(lblVehiclesSection);
        pnlVehicles.Controls.Add(pnlDatePickers);
        pnlVehicles.Location = new Point(3, 90);
        pnlVehicles.Margin = new Padding(3, 4, 3, 4);
        pnlVehicles.Name = "pnlVehicles";
        pnlVehicles.Padding = new Padding(16, 19, 16, 19);
        pnlVehicles.Size = new Size(636, 696);
        pnlVehicles.TabIndex = 1;
        // 
        // lblVehiclesSection
        // 
        lblVehiclesSection.AutoSize = true;
        lblVehiclesSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblVehiclesSection.ForeColor = Color.FromArgb(0, 210, 190);
        lblVehiclesSection.Location = new Point(16, 13);
        lblVehiclesSection.Name = "lblVehiclesSection";
        lblVehiclesSection.Size = new Size(113, 19);
        lblVehiclesSection.TabIndex = 0;
        lblVehiclesSection.Text = "SELECT VEHICLE";
        // 
        // pnlDatePickers
        // 
        pnlDatePickers.BackColor = Color.FromArgb(22, 22, 32);
        pnlDatePickers.Controls.Add(dgvAvailable);
        pnlDatePickers.Controls.Add(lblStore);
        pnlDatePickers.Controls.Add(cmbStoreLocations);
        pnlDatePickers.Controls.Add(lblEndDate);
        pnlDatePickers.Controls.Add(dtpEnd);
        pnlDatePickers.Controls.Add(lblStartDate);
        pnlDatePickers.Controls.Add(dtpStart);
        pnlDatePickers.Location = new Point(0, 59);
        pnlDatePickers.Margin = new Padding(3, 4, 3, 4);
        pnlDatePickers.Name = "pnlDatePickers";
        pnlDatePickers.Padding = new Padding(16, 19, 16, 19);
        pnlDatePickers.Size = new Size(636, 647);
        pnlDatePickers.TabIndex = 3;
        // 
        // dgvAvailable
        // 
        dgvAvailable.BackgroundColor = Color.FromArgb(22, 22, 32);
        dgvAvailable.BorderStyle = BorderStyle.None;
        dgvAvailable.ColumnHeadersHeight = 38;
        dgvAvailable.EnableHeadersVisualStyles = false;
        dgvAvailable.GridColor = Color.FromArgb(30, 30, 45);
        dgvAvailable.Location = new Point(16, 132);
        dgvAvailable.Margin = new Padding(3, 4, 3, 4);
        dgvAvailable.Name = "dgvAvailable";
        dgvAvailable.RowHeadersVisible = false;
        dgvAvailable.RowHeadersWidth = 51;
        dgvAvailable.RowTemplate.Height = 40;
        dgvAvailable.Size = new Size(595, 454);
        dgvAvailable.TabIndex = 1;
        dgvAvailable.CellClick += dgvAvailable_CellClick;
        dgvAvailable.SelectionChanged += dgvAvailable_SelectionChanged;
        // 
        // lblEndDate
        // 
        lblEndDate.AutoSize = true;
        lblEndDate.Font = new Font("Segoe UI", 9F);
        lblEndDate.ForeColor = Color.FromArgb(130, 130, 150);
        lblEndDate.Location = new Point(313, 13);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new Size(70, 20);
        lblEndDate.TabIndex = 8;
        lblEndDate.Text = "End Date";
        // 
        // lblStore
        // 
        lblStore.AutoSize = true;
        lblStore.Font = new Font("Segoe UI", 9F);
        lblStore.ForeColor = Color.FromArgb(130, 130, 150);
        lblStore.Location = new Point(16, 68);
        lblStore.Name = "lblStore";
        lblStore.Size = new Size(44, 20);
        lblStore.TabIndex = 5;
        lblStore.Text = "Store";
        // 
        // cmbStoreLocations
        // 
        cmbStoreLocations.BackColor = Color.FromArgb(22, 22, 32);
        cmbStoreLocations.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStoreLocations.Font = new Font("Segoe UI", 9F);
        cmbStoreLocations.ForeColor = Color.FromArgb(220, 220, 220);
        cmbStoreLocations.FormattingEnabled = true;
        cmbStoreLocations.Location = new Point(16, 91);
        cmbStoreLocations.Name = "cmbStoreLocations";
        cmbStoreLocations.Size = new Size(238, 27);
        cmbStoreLocations.TabIndex = 6;
        // 
        // dtpEnd
        // 
        dtpEnd.BackColor = Color.FromArgb(22, 22, 32);
        dtpEnd.CalendarForeColor = Color.FromArgb(230, 230, 230);
        dtpEnd.CalendarMonthBackground = Color.FromArgb(22, 22, 32);
        dtpEnd.CalendarTitleBackColor = Color.FromArgb(10, 10, 15);
        dtpEnd.CalendarTitleForeColor = Color.FromArgb(230, 230, 230);
        dtpEnd.ForeColor = Color.FromArgb(230, 230, 230);
        dtpEnd.Format = DateTimePickerFormat.Short;
        dtpEnd.Location = new Point(313, 37);
        dtpEnd.Margin = new Padding(3, 4, 3, 4);
        dtpEnd.MinDate = new DateTime(2026, 5, 4, 0, 0, 0, 0);
        dtpEnd.Name = "dtpEnd";
        dtpEnd.Size = new Size(247, 27);
        dtpEnd.TabIndex = 9;
        dtpEnd.Value = new DateTime(2026, 5, 4, 0, 0, 0, 0);
        dtpEnd.ValueChanged += dtpEnd_ValueChanged;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Font = new Font("Segoe UI", 9F);
        lblStartDate.ForeColor = Color.FromArgb(130, 130, 150);
        lblStartDate.Location = new Point(16, 13);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(76, 20);
        lblStartDate.TabIndex = 6;
        lblStartDate.Text = "Start Date";
        // 
        // dtpStart
        // 
        dtpStart.BackColor = Color.FromArgb(22, 22, 32);
        dtpStart.CalendarForeColor = Color.FromArgb(230, 230, 230);
        dtpStart.CalendarMonthBackground = Color.FromArgb(22, 22, 32);
        dtpStart.CalendarTitleBackColor = Color.FromArgb(10, 10, 15);
        dtpStart.CalendarTitleForeColor = Color.FromArgb(230, 230, 230);
        dtpStart.ForeColor = Color.FromArgb(230, 230, 230);
        dtpStart.Format = DateTimePickerFormat.Short;
        dtpStart.Location = new Point(16, 37);
        dtpStart.Margin = new Padding(3, 4, 3, 4);
        dtpStart.MinDate = new DateTime(2026, 5, 3, 0, 0, 0, 0);
        dtpStart.Name = "dtpStart";
        dtpStart.Size = new Size(238, 27);
        dtpStart.TabIndex = 7;
        dtpStart.Value = new DateTime(2026, 5, 3, 0, 0, 0, 0);
        dtpStart.ValueChanged += dtpStart_ValueChanged;
        // 
        // CustomerRentalBookingControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 247, 255);
        Controls.Add(pnlMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "CustomerRentalBookingControl";
        Size = new Size(1103, 834);
        pnlMain.ResumeLayout(false);
        pnlMain.PerformLayout();
        pnlRight.ResumeLayout(false);
        pnlSummary.ResumeLayout(false);
        pnlSummary.PerformLayout();
        pnlLeft.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        pnlVehicles.ResumeLayout(false);
        pnlVehicles.PerformLayout();
        pnlDatePickers.ResumeLayout(false);
        pnlDatePickers.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
        ResumeLayout(false);
    }

    private Label label1;
}
