using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class VehicleEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTitle;
    private Label lblTitle;
    private Panel pnlForm;
    private TableLayoutPanel tblForm;
    private Label lblVehicleID;
    private TextBox txtVehicleID;
    private Label lblFamily;
    private ComboBox cmbFamily;
    private Label lblType;
    private ComboBox cmbType;
    private Label lblYear;
    private NumericUpDown nudYear;
    private Label lblStatus;
    private ComboBox cmbStatus;
    private Label lblColour;
    private TextBox txtColour;
    private Label lblOrigin;
    private TextBox txtOrigin;
    private Label lblPlate;
    private TextBox txtPlate;
    private Label lblRate;
    private NumericUpDown nudRate;
    private Label lblMileage;
    private NumericUpDown nudMileage;
    private Label lblSupplier;
    private ComboBox cmbSupplier;
    private FlowLayoutPanel pnlButtons;
    private Button btnCancel;
    private Button btnSave;

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
        pnlTitle = new Panel();
        lblTitle = new Label();
        pnlForm = new Panel();
        tblForm = new TableLayoutPanel();
        lblVehicleID = new Label();
        txtVehicleID = new TextBox();
        lblFamily = new Label();
        cmbFamily = new ComboBox();
        lblType = new Label();
        cmbType = new ComboBox();
        lblYear = new Label();
        nudYear = new NumericUpDown();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        lblColour = new Label();
        txtColour = new TextBox();
        lblOrigin = new Label();
        txtOrigin = new TextBox();
        lblPlate = new Label();
        txtPlate = new TextBox();
        lblRate = new Label();
        nudRate = new NumericUpDown();
        lblMileage = new Label();
        nudMileage = new NumericUpDown();
        cmbSupplier = new ComboBox();
        lblSupplier = new Label();
        pnlButtons = new FlowLayoutPanel();
        btnCancel = new Button();
        btnSave = new Button();
        pnlTitle.SuspendLayout();
        pnlForm.SuspendLayout();
        tblForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudMileage).BeginInit();
        pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTitle
        // 
        pnlTitle.BackColor = Color.FromArgb(0, 210, 190);
        pnlTitle.Controls.Add(lblTitle);
        pnlTitle.Dock = DockStyle.Top;
        pnlTitle.Location = new Point(0, 0);
        pnlTitle.Margin = new Padding(3, 4, 3, 4);
        pnlTitle.Name = "pnlTitle";
        pnlTitle.Size = new Size(549, 67);
        pnlTitle.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(237, 233, 254);
        lblTitle.Location = new Point(18, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(136, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Add Vehicle";
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(15, 15, 22);
        pnlForm.Controls.Add(tblForm);
        pnlForm.Controls.Add(pnlButtons);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(0, 67);
        pnlForm.Margin = new Padding(3, 4, 3, 4);
        pnlForm.Name = "pnlForm";
        pnlForm.Padding = new Padding(18, 21, 18, 21);
        pnlForm.Size = new Size(549, 666);
        pnlForm.TabIndex = 1;
        // 
        // tblForm
        // 
        tblForm.ColumnCount = 2;
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61F));
        tblForm.Controls.Add(lblVehicleID, 0, 0);
        tblForm.Controls.Add(txtVehicleID, 1, 0);
        tblForm.Controls.Add(lblFamily, 0, 1);
        tblForm.Controls.Add(cmbFamily, 1, 1);
        tblForm.Controls.Add(lblType, 0, 2);
        tblForm.Controls.Add(cmbType, 1, 2);
        tblForm.Controls.Add(lblYear, 0, 3);
        tblForm.Controls.Add(nudYear, 1, 3);
        tblForm.Controls.Add(lblStatus, 0, 4);
        tblForm.Controls.Add(cmbStatus, 1, 4);
        tblForm.Controls.Add(lblColour, 0, 5);
        tblForm.Controls.Add(txtColour, 1, 5);
        tblForm.Controls.Add(lblOrigin, 0, 6);
        tblForm.Controls.Add(txtOrigin, 1, 6);
        tblForm.Controls.Add(lblPlate, 0, 7);
        tblForm.Controls.Add(txtPlate, 1, 7);
        tblForm.Controls.Add(lblRate, 0, 8);
        tblForm.Controls.Add(nudRate, 1, 8);
        tblForm.Controls.Add(lblMileage, 0, 9);
        tblForm.Controls.Add(nudMileage, 1, 9);
        tblForm.Controls.Add(cmbSupplier, 1, 10);
        tblForm.Controls.Add(lblSupplier, 0, 10);
        tblForm.Dock = DockStyle.Fill;
        tblForm.Location = new Point(18, 21);
        tblForm.Margin = new Padding(3, 4, 3, 4);
        tblForm.Name = "tblForm";
        tblForm.RowCount = 11;
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        tblForm.Size = new Size(513, 581);
        tblForm.TabIndex = 0;
        // 
        // lblVehicleID
        // 
        lblVehicleID.Dock = DockStyle.Fill;
        lblVehicleID.Font = new Font("Segoe UI", 9F);
        lblVehicleID.ForeColor = Color.FromArgb(0, 210, 190);
        lblVehicleID.Location = new Point(3, 0);
        lblVehicleID.Name = "lblVehicleID";
        lblVehicleID.Padding = new Padding(0, 0, 9, 0);
        lblVehicleID.Size = new Size(194, 51);
        lblVehicleID.TabIndex = 0;
        lblVehicleID.Text = "Vehicle ID";
        lblVehicleID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtVehicleID
        // 
        txtVehicleID.BackColor = Color.FromArgb(15, 15, 22);
        txtVehicleID.BorderStyle = BorderStyle.FixedSingle;
        txtVehicleID.Dock = DockStyle.Fill;
        txtVehicleID.Font = new Font("Segoe UI", 10F);
        txtVehicleID.ForeColor = SystemColors.Window;
        txtVehicleID.Location = new Point(203, 8);
        txtVehicleID.Margin = new Padding(3, 8, 3, 8);
        txtVehicleID.Name = "txtVehicleID";
        txtVehicleID.Size = new Size(307, 30);
        txtVehicleID.TabIndex = 1;
        // 
        // lblFamily
        // 
        lblFamily.Dock = DockStyle.Fill;
        lblFamily.Font = new Font("Segoe UI", 9F);
        lblFamily.ForeColor = Color.FromArgb(0, 210, 190);
        lblFamily.Location = new Point(3, 51);
        lblFamily.Name = "lblFamily";
        lblFamily.Padding = new Padding(0, 0, 9, 0);
        lblFamily.Size = new Size(194, 51);
        lblFamily.TabIndex = 2;
        lblFamily.Text = "Family (Model)";
        lblFamily.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cmbFamily
        // 
        cmbFamily.BackColor = Color.FromArgb(15, 15, 22);
        cmbFamily.Dock = DockStyle.Fill;
        cmbFamily.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFamily.FlatStyle = FlatStyle.Flat;
        cmbFamily.Font = new Font("Segoe UI", 10F);
        cmbFamily.ForeColor = SystemColors.Window;
        cmbFamily.FormattingEnabled = true;
        cmbFamily.Location = new Point(203, 59);
        cmbFamily.Margin = new Padding(3, 8, 3, 8);
        cmbFamily.Name = "cmbFamily";
        cmbFamily.Size = new Size(307, 31);
        cmbFamily.TabIndex = 3;
        // 
        // lblType
        // 
        lblType.Dock = DockStyle.Fill;
        lblType.Font = new Font("Segoe UI", 9F);
        lblType.ForeColor = Color.FromArgb(0, 210, 190);
        lblType.Location = new Point(3, 102);
        lblType.Name = "lblType";
        lblType.Padding = new Padding(0, 0, 9, 0);
        lblType.Size = new Size(194, 51);
        lblType.TabIndex = 4;
        lblType.Text = "Type";
        lblType.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cmbType
        // 
        cmbType.BackColor = Color.FromArgb(15, 15, 22);
        cmbType.Dock = DockStyle.Fill;
        cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbType.FlatStyle = FlatStyle.Flat;
        cmbType.Font = new Font("Segoe UI", 10F);
        cmbType.ForeColor = SystemColors.Window;
        cmbType.FormattingEnabled = true;
        cmbType.Items.AddRange(new object[] { "Sedan", "SUV", "Luxury", "Truck" });
        cmbType.Location = new Point(203, 110);
        cmbType.Margin = new Padding(3, 8, 3, 8);
        cmbType.Name = "cmbType";
        cmbType.Size = new Size(307, 31);
        cmbType.TabIndex = 5;
        // 
        // lblYear
        // 
        lblYear.Dock = DockStyle.Fill;
        lblYear.Font = new Font("Segoe UI", 9F);
        lblYear.ForeColor = Color.FromArgb(0, 210, 190);
        lblYear.Location = new Point(3, 153);
        lblYear.Name = "lblYear";
        lblYear.Padding = new Padding(0, 0, 9, 0);
        lblYear.Size = new Size(194, 51);
        lblYear.TabIndex = 6;
        lblYear.Text = "Year";
        lblYear.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudYear
        // 
        nudYear.BackColor = Color.FromArgb(15, 15, 22);
        nudYear.BorderStyle = BorderStyle.FixedSingle;
        nudYear.Dock = DockStyle.Fill;
        nudYear.Font = new Font("Segoe UI", 10F);
        nudYear.ForeColor = SystemColors.Window;
        nudYear.Location = new Point(203, 161);
        nudYear.Margin = new Padding(3, 8, 3, 8);
        nudYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
        nudYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
        nudYear.Name = "nudYear";
        nudYear.Size = new Size(307, 30);
        nudYear.TabIndex = 7;
        nudYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
        // 
        // lblStatus
        // 
        lblStatus.Dock = DockStyle.Fill;
        lblStatus.Font = new Font("Segoe UI", 9F);
        lblStatus.ForeColor = Color.FromArgb(0, 210, 190);
        lblStatus.Location = new Point(3, 204);
        lblStatus.Name = "lblStatus";
        lblStatus.Padding = new Padding(0, 0, 9, 0);
        lblStatus.Size = new Size(194, 51);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Status";
        lblStatus.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cmbStatus
        // 
        cmbStatus.BackColor = Color.FromArgb(15, 15, 22);
        cmbStatus.Dock = DockStyle.Fill;
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FlatStyle = FlatStyle.Flat;
        cmbStatus.Font = new Font("Segoe UI", 10F);
        cmbStatus.ForeColor = SystemColors.Window;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Items.AddRange(new object[] { "Available", "Rented", "Maintenance" });
        cmbStatus.Location = new Point(203, 212);
        cmbStatus.Margin = new Padding(3, 8, 3, 8);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(307, 31);
        cmbStatus.TabIndex = 9;
        // 
        // lblColour
        // 
        lblColour.BackColor = Color.FromArgb(15, 15, 22);
        lblColour.Dock = DockStyle.Fill;
        lblColour.Font = new Font("Segoe UI", 9F);
        lblColour.ForeColor = Color.FromArgb(0, 210, 190);
        lblColour.Location = new Point(3, 255);
        lblColour.Name = "lblColour";
        lblColour.Padding = new Padding(0, 0, 9, 0);
        lblColour.Size = new Size(194, 51);
        lblColour.TabIndex = 10;
        lblColour.Text = "Colour";
        lblColour.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtColour
        // 
        txtColour.BackColor = Color.FromArgb(15, 15, 22);
        txtColour.BorderStyle = BorderStyle.FixedSingle;
        txtColour.Dock = DockStyle.Fill;
        txtColour.Font = new Font("Segoe UI", 10F);
        txtColour.ForeColor = SystemColors.Window;
        txtColour.Location = new Point(203, 263);
        txtColour.Margin = new Padding(3, 8, 3, 8);
        txtColour.Name = "txtColour";
        txtColour.Size = new Size(307, 30);
        txtColour.TabIndex = 11;
        // 
        // lblOrigin
        // 
        lblOrigin.BackColor = Color.FromArgb(15, 15, 22);
        lblOrigin.Dock = DockStyle.Fill;
        lblOrigin.Font = new Font("Segoe UI", 9F);
        lblOrigin.ForeColor = Color.FromArgb(0, 210, 190);
        lblOrigin.Location = new Point(3, 306);
        lblOrigin.Name = "lblOrigin";
        lblOrigin.Padding = new Padding(0, 0, 9, 0);
        lblOrigin.Size = new Size(194, 51);
        lblOrigin.TabIndex = 12;
        lblOrigin.Text = "Origin Country";
        lblOrigin.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtOrigin
        // 
        txtOrigin.BackColor = Color.FromArgb(15, 15, 22);
        txtOrigin.BorderStyle = BorderStyle.FixedSingle;
        txtOrigin.Dock = DockStyle.Fill;
        txtOrigin.Font = new Font("Segoe UI", 10F);
        txtOrigin.ForeColor = SystemColors.Window;
        txtOrigin.Location = new Point(203, 314);
        txtOrigin.Margin = new Padding(3, 8, 3, 8);
        txtOrigin.Name = "txtOrigin";
        txtOrigin.Size = new Size(307, 30);
        txtOrigin.TabIndex = 13;
        // 
        // lblPlate
        // 
        lblPlate.BackColor = Color.FromArgb(15, 15, 22);
        lblPlate.Dock = DockStyle.Fill;
        lblPlate.Font = new Font("Segoe UI", 9F);
        lblPlate.ForeColor = Color.FromArgb(0, 210, 190);
        lblPlate.Location = new Point(3, 357);
        lblPlate.Name = "lblPlate";
        lblPlate.Padding = new Padding(0, 0, 9, 0);
        lblPlate.Size = new Size(194, 51);
        lblPlate.TabIndex = 14;
        lblPlate.Text = "License Plate";
        lblPlate.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtPlate
        // 
        txtPlate.BackColor = Color.FromArgb(15, 15, 22);
        txtPlate.BorderStyle = BorderStyle.FixedSingle;
        txtPlate.Dock = DockStyle.Fill;
        txtPlate.Font = new Font("Segoe UI", 10F);
        txtPlate.ForeColor = SystemColors.Window;
        txtPlate.Location = new Point(203, 365);
        txtPlate.Margin = new Padding(3, 8, 3, 8);
        txtPlate.Name = "txtPlate";
        txtPlate.Size = new Size(307, 30);
        txtPlate.TabIndex = 15;
        // 
        // lblRate
        // 
        lblRate.Dock = DockStyle.Fill;
        lblRate.Font = new Font("Segoe UI", 9F);
        lblRate.ForeColor = Color.FromArgb(0, 210, 190);
        lblRate.Location = new Point(3, 408);
        lblRate.Name = "lblRate";
        lblRate.Padding = new Padding(0, 0, 9, 0);
        lblRate.Size = new Size(194, 51);
        lblRate.TabIndex = 16;
        lblRate.Text = "Daily Rate ($)";
        lblRate.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRate
        // 
        nudRate.BackColor = Color.FromArgb(15, 15, 22);
        nudRate.BorderStyle = BorderStyle.FixedSingle;
        nudRate.Dock = DockStyle.Fill;
        nudRate.Font = new Font("Segoe UI", 10F);
        nudRate.ForeColor = SystemColors.Window;
        nudRate.Location = new Point(203, 416);
        nudRate.Margin = new Padding(3, 8, 3, 8);
        nudRate.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudRate.Name = "nudRate";
        nudRate.Size = new Size(307, 30);
        nudRate.TabIndex = 17;
        // 
        // lblMileage
        // 
        lblMileage.Font = new Font("Segoe UI", 9F);
        lblMileage.ForeColor = Color.FromArgb(0, 210, 190);
        lblMileage.Location = new Point(3, 459);
        lblMileage.Name = "lblMileage";
        lblMileage.Padding = new Padding(0, 0, 9, 0);
        lblMileage.Size = new Size(194, 44);
        lblMileage.TabIndex = 18;
        lblMileage.Text = "Mileage (km)";
        lblMileage.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudMileage
        // 
        nudMileage.BackColor = Color.FromArgb(15, 15, 22);
        nudMileage.BorderStyle = BorderStyle.FixedSingle;
        nudMileage.Dock = DockStyle.Fill;
        nudMileage.Font = new Font("Segoe UI", 10F);
        nudMileage.ForeColor = SystemColors.Window;
        nudMileage.Location = new Point(203, 467);
        nudMileage.Margin = new Padding(3, 8, 3, 8);
        nudMileage.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        nudMileage.Name = "nudMileage";
        nudMileage.Size = new Size(307, 30);
        nudMileage.TabIndex = 19;
        // 
        // cmbSupplier
        // 
        cmbSupplier.BackColor = Color.FromArgb(15, 15, 22);
        cmbSupplier.Dock = DockStyle.Fill;
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSupplier.FlatStyle = FlatStyle.Flat;
        cmbSupplier.Font = new Font("Segoe UI", 10F);
        cmbSupplier.ForeColor = SystemColors.Window;
        cmbSupplier.FormattingEnabled = true;
        cmbSupplier.Location = new Point(203, 511);
        cmbSupplier.Margin = new Padding(3, 8, 3, 8);
        cmbSupplier.Name = "cmbSupplier";
        cmbSupplier.Size = new Size(307, 31);
        cmbSupplier.TabIndex = 21;
        // 
        // lblSupplier
        // 
        lblSupplier.Dock = DockStyle.Top;
        lblSupplier.Font = new Font("Segoe UI", 9F);
        lblSupplier.ForeColor = Color.FromArgb(0, 210, 190);
        lblSupplier.Location = new Point(3, 503);
        lblSupplier.Name = "lblSupplier";
        lblSupplier.Padding = new Padding(0, 0, 9, 0);
        lblSupplier.Size = new Size(194, 50);
        lblSupplier.TabIndex = 20;
        lblSupplier.Text = "Supplier";
        lblSupplier.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlButtons
        // 
        pnlButtons.BackColor = Color.FromArgb(15, 15, 22);
        pnlButtons.Controls.Add(btnCancel);
        pnlButtons.Controls.Add(btnSave);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.FlowDirection = FlowDirection.RightToLeft;
        pnlButtons.Location = new Point(18, 602);
        pnlButtons.Margin = new Padding(3, 4, 3, 4);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new Size(513, 43);
        pnlButtons.TabIndex = 1;
        pnlButtons.WrapContents = false;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.FromArgb(0, 210, 190);
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.ForeColor = Color.FromArgb(15, 15, 22);
        btnCancel.Location = new Point(427, 4);
        btnCancel.Margin = new Padding(3, 4, 0, 4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 35);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(0, 210, 190);
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = Color.FromArgb(15, 15, 22);
        btnSave.Location = new Point(292, 4);
        btnSave.Margin = new Padding(0, 4, 9, 4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(123, 35);
        btnSave.TabIndex = 0;
        btnSave.Text = "Save Vehicle";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // VehicleEditForm
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 247, 255);
        CancelButton = btnCancel;
        ClientSize = new Size(549, 733);
        Controls.Add(pnlForm);
        Controls.Add(pnlTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "VehicleEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Vehicle";
        pnlTitle.ResumeLayout(false);
        pnlTitle.PerformLayout();
        pnlForm.ResumeLayout(false);
        tblForm.ResumeLayout(false);
        tblForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRate).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudMileage).EndInit();
        pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }
}
