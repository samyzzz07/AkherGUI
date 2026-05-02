using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTitle;
    private Label lblTitle;
    private Panel pnlForm;
    private TableLayoutPanel tblForm;
    private Label lblSSN;
    private TextBox txtSSN;
    private Label lblName;
    private TextBox txtName;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblPhone;
    private TextBox txtPhone;
    private Label lblBirth;
    private DateTimePicker dtpBirth;
    private Label lblDLN;
    private TextBox txtDLN;
    private Label lblHouseNo;
    private TextBox txtHouseNo;
    private Label lblStreet;
    private TextBox txtStreet;
    private Label lblDistrict;
    private TextBox txtDistrict;
    private Label lblCity;
    private TextBox txtCity;
    private Label lblPassword;
    private TextBox txtPassword;
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
        lblSSN = new Label();
        txtSSN = new TextBox();
        lblName = new Label();
        txtName = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblPhone = new Label();
        txtPhone = new TextBox();
        lblBirth = new Label();
        dtpBirth = new DateTimePicker();
        lblDLN = new Label();
        txtDLN = new TextBox();
        lblHouseNo = new Label();
        txtHouseNo = new TextBox();
        lblStreet = new Label();
        txtStreet = new TextBox();
        lblDistrict = new Label();
        txtDistrict = new TextBox();
        lblCity = new Label();
        txtCity = new TextBox();
        txtPassword = new TextBox();
        lblPassword = new Label();
        pnlButtons = new FlowLayoutPanel();
        btnCancel = new Button();
        btnSave = new Button();
        pnlTitle.SuspendLayout();
        pnlForm.SuspendLayout();
        tblForm.SuspendLayout();
        pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTitle
        // 
        pnlTitle.BackColor = Color.FromArgb(45, 27, 105);
        pnlTitle.Controls.Add(lblTitle);
        pnlTitle.Dock = DockStyle.Top;
        pnlTitle.Location = new Point(0, 0);
        pnlTitle.Margin = new Padding(3, 4, 3, 4);
        pnlTitle.Name = "pnlTitle";
        pnlTitle.Size = new Size(571, 67);
        pnlTitle.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(237, 233, 254);
        lblTitle.Location = new Point(18, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(162, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Add Customer";
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(248, 247, 255);
        pnlForm.Controls.Add(tblForm);
        pnlForm.Controls.Add(pnlButtons);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(0, 67);
        pnlForm.Margin = new Padding(3, 4, 3, 4);
        pnlForm.Name = "pnlForm";
        pnlForm.Padding = new Padding(18, 21, 18, 21);
        pnlForm.Size = new Size(571, 706);
        pnlForm.TabIndex = 1;
        // 
        // tblForm
        // 
        tblForm.ColumnCount = 2;
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tblForm.Controls.Add(lblSSN, 0, 0);
        tblForm.Controls.Add(txtSSN, 1, 0);
        tblForm.Controls.Add(lblName, 0, 1);
        tblForm.Controls.Add(txtName, 1, 1);
        tblForm.Controls.Add(lblEmail, 0, 2);
        tblForm.Controls.Add(txtEmail, 1, 2);
        tblForm.Controls.Add(lblPhone, 0, 3);
        tblForm.Controls.Add(txtPhone, 1, 3);
        tblForm.Controls.Add(lblBirth, 0, 4);
        tblForm.Controls.Add(dtpBirth, 1, 4);
        tblForm.Controls.Add(lblDLN, 0, 5);
        tblForm.Controls.Add(txtDLN, 1, 5);
        tblForm.Controls.Add(lblHouseNo, 0, 6);
        tblForm.Controls.Add(txtHouseNo, 1, 6);
        tblForm.Controls.Add(lblStreet, 0, 7);
        tblForm.Controls.Add(txtStreet, 1, 7);
        tblForm.Controls.Add(lblDistrict, 0, 8);
        tblForm.Controls.Add(txtDistrict, 1, 8);
        tblForm.Controls.Add(lblCity, 0, 9);
        tblForm.Controls.Add(txtCity, 1, 9);
        tblForm.Controls.Add(txtPassword, 1, 10);
        tblForm.Controls.Add(lblPassword, 0, 10);
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
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        tblForm.Size = new Size(535, 627);
        tblForm.TabIndex = 0;
        // 
        // lblSSN
        // 
        lblSSN.Dock = DockStyle.Fill;
        lblSSN.Font = new Font("Segoe UI", 9F);
        lblSSN.ForeColor = Color.FromArgb(124, 58, 237);
        lblSSN.Location = new Point(3, 0);
        lblSSN.Name = "lblSSN";
        lblSSN.Padding = new Padding(0, 0, 9, 0);
        lblSSN.Size = new Size(208, 51);
        lblSSN.TabIndex = 0;
        lblSSN.Text = "SSN";
        lblSSN.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtSSN
        // 
        txtSSN.BorderStyle = BorderStyle.FixedSingle;
        txtSSN.Dock = DockStyle.Fill;
        txtSSN.Font = new Font("Segoe UI", 10F);
        txtSSN.Location = new Point(217, 8);
        txtSSN.Margin = new Padding(3, 8, 3, 8);
        txtSSN.Name = "txtSSN";
        txtSSN.Size = new Size(315, 30);
        txtSSN.TabIndex = 1;
        // 
        // lblName
        // 
        lblName.Dock = DockStyle.Fill;
        lblName.Font = new Font("Segoe UI", 9F);
        lblName.ForeColor = Color.FromArgb(124, 58, 237);
        lblName.Location = new Point(3, 51);
        lblName.Name = "lblName";
        lblName.Padding = new Padding(0, 0, 9, 0);
        lblName.Size = new Size(208, 51);
        lblName.TabIndex = 2;
        lblName.Text = "Full Name";
        lblName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtName
        // 
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Dock = DockStyle.Fill;
        txtName.Font = new Font("Segoe UI", 10F);
        txtName.Location = new Point(217, 59);
        txtName.Margin = new Padding(3, 8, 3, 8);
        txtName.Name = "txtName";
        txtName.Size = new Size(315, 30);
        txtName.TabIndex = 3;
        // 
        // lblEmail
        // 
        lblEmail.Dock = DockStyle.Fill;
        lblEmail.Font = new Font("Segoe UI", 9F);
        lblEmail.ForeColor = Color.FromArgb(124, 58, 237);
        lblEmail.Location = new Point(3, 102);
        lblEmail.Name = "lblEmail";
        lblEmail.Padding = new Padding(0, 0, 9, 0);
        lblEmail.Size = new Size(208, 51);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email";
        lblEmail.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtEmail
        // 
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Dock = DockStyle.Fill;
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.Location = new Point(217, 110);
        txtEmail.Margin = new Padding(3, 8, 3, 8);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(315, 30);
        txtEmail.TabIndex = 5;
        // 
        // lblPhone
        // 
        lblPhone.Dock = DockStyle.Fill;
        lblPhone.Font = new Font("Segoe UI", 9F);
        lblPhone.ForeColor = Color.FromArgb(124, 58, 237);
        lblPhone.Location = new Point(3, 153);
        lblPhone.Name = "lblPhone";
        lblPhone.Padding = new Padding(0, 0, 9, 0);
        lblPhone.Size = new Size(208, 51);
        lblPhone.TabIndex = 6;
        lblPhone.Text = "Phone Number";
        lblPhone.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtPhone
        // 
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Dock = DockStyle.Fill;
        txtPhone.Font = new Font("Segoe UI", 10F);
        txtPhone.Location = new Point(217, 161);
        txtPhone.Margin = new Padding(3, 8, 3, 8);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(315, 30);
        txtPhone.TabIndex = 7;
        // 
        // lblBirth
        // 
        lblBirth.Dock = DockStyle.Fill;
        lblBirth.Font = new Font("Segoe UI", 9F);
        lblBirth.ForeColor = Color.FromArgb(124, 58, 237);
        lblBirth.Location = new Point(3, 204);
        lblBirth.Name = "lblBirth";
        lblBirth.Padding = new Padding(0, 0, 9, 0);
        lblBirth.Size = new Size(208, 51);
        lblBirth.TabIndex = 8;
        lblBirth.Text = "Birthdate";
        lblBirth.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dtpBirth
        // 
        dtpBirth.Dock = DockStyle.Fill;
        dtpBirth.Format = DateTimePickerFormat.Short;
        dtpBirth.Location = new Point(217, 212);
        dtpBirth.Margin = new Padding(3, 8, 3, 8);
        dtpBirth.Name = "dtpBirth";
        dtpBirth.Size = new Size(315, 27);
        dtpBirth.TabIndex = 9;
        // 
        // lblDLN
        // 
        lblDLN.Dock = DockStyle.Fill;
        lblDLN.Font = new Font("Segoe UI", 9F);
        lblDLN.ForeColor = Color.FromArgb(124, 58, 237);
        lblDLN.Location = new Point(3, 255);
        lblDLN.Name = "lblDLN";
        lblDLN.Padding = new Padding(0, 0, 9, 0);
        lblDLN.Size = new Size(208, 51);
        lblDLN.TabIndex = 10;
        lblDLN.Text = "Driver License No.";
        lblDLN.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtDLN
        // 
        txtDLN.BorderStyle = BorderStyle.FixedSingle;
        txtDLN.Dock = DockStyle.Fill;
        txtDLN.Font = new Font("Segoe UI", 10F);
        txtDLN.Location = new Point(217, 263);
        txtDLN.Margin = new Padding(3, 8, 3, 8);
        txtDLN.Name = "txtDLN";
        txtDLN.Size = new Size(315, 30);
        txtDLN.TabIndex = 11;
        // 
        // lblHouseNo
        // 
        lblHouseNo.Dock = DockStyle.Fill;
        lblHouseNo.Font = new Font("Segoe UI", 9F);
        lblHouseNo.ForeColor = Color.FromArgb(124, 58, 237);
        lblHouseNo.Location = new Point(3, 306);
        lblHouseNo.Name = "lblHouseNo";
        lblHouseNo.Padding = new Padding(0, 0, 9, 0);
        lblHouseNo.Size = new Size(208, 51);
        lblHouseNo.TabIndex = 12;
        lblHouseNo.Text = "House Number";
        lblHouseNo.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtHouseNo
        // 
        txtHouseNo.BorderStyle = BorderStyle.FixedSingle;
        txtHouseNo.Dock = DockStyle.Fill;
        txtHouseNo.Font = new Font("Segoe UI", 10F);
        txtHouseNo.Location = new Point(217, 314);
        txtHouseNo.Margin = new Padding(3, 8, 3, 8);
        txtHouseNo.Name = "txtHouseNo";
        txtHouseNo.Size = new Size(315, 30);
        txtHouseNo.TabIndex = 13;
        // 
        // lblStreet
        // 
        lblStreet.Dock = DockStyle.Fill;
        lblStreet.Font = new Font("Segoe UI", 9F);
        lblStreet.ForeColor = Color.FromArgb(124, 58, 237);
        lblStreet.Location = new Point(3, 357);
        lblStreet.Name = "lblStreet";
        lblStreet.Padding = new Padding(0, 0, 9, 0);
        lblStreet.Size = new Size(208, 51);
        lblStreet.TabIndex = 14;
        lblStreet.Text = "Street";
        lblStreet.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtStreet
        // 
        txtStreet.BorderStyle = BorderStyle.FixedSingle;
        txtStreet.Dock = DockStyle.Fill;
        txtStreet.Font = new Font("Segoe UI", 10F);
        txtStreet.Location = new Point(217, 365);
        txtStreet.Margin = new Padding(3, 8, 3, 8);
        txtStreet.Name = "txtStreet";
        txtStreet.Size = new Size(315, 30);
        txtStreet.TabIndex = 15;
        // 
        // lblDistrict
        // 
        lblDistrict.Dock = DockStyle.Fill;
        lblDistrict.Font = new Font("Segoe UI", 9F);
        lblDistrict.ForeColor = Color.FromArgb(124, 58, 237);
        lblDistrict.Location = new Point(3, 408);
        lblDistrict.Name = "lblDistrict";
        lblDistrict.Padding = new Padding(0, 0, 9, 0);
        lblDistrict.Size = new Size(208, 51);
        lblDistrict.TabIndex = 16;
        lblDistrict.Text = "District";
        lblDistrict.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtDistrict
        // 
        txtDistrict.BorderStyle = BorderStyle.FixedSingle;
        txtDistrict.Dock = DockStyle.Fill;
        txtDistrict.Font = new Font("Segoe UI", 10F);
        txtDistrict.Location = new Point(217, 416);
        txtDistrict.Margin = new Padding(3, 8, 3, 8);
        txtDistrict.Name = "txtDistrict";
        txtDistrict.Size = new Size(315, 30);
        txtDistrict.TabIndex = 17;
        // 
        // lblCity
        // 
        lblCity.Dock = DockStyle.Fill;
        lblCity.Font = new Font("Segoe UI", 9F);
        lblCity.ForeColor = Color.FromArgb(124, 58, 237);
        lblCity.Location = new Point(3, 459);
        lblCity.Name = "lblCity";
        lblCity.Padding = new Padding(0, 0, 9, 0);
        lblCity.Size = new Size(208, 42);
        lblCity.TabIndex = 18;
        lblCity.Text = "City";
        lblCity.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtCity
        // 
        txtCity.BorderStyle = BorderStyle.FixedSingle;
        txtCity.Dock = DockStyle.Fill;
        txtCity.Font = new Font("Segoe UI", 10F);
        txtCity.Location = new Point(217, 467);
        txtCity.Margin = new Padding(3, 8, 3, 8);
        txtCity.Name = "txtCity";
        txtCity.Size = new Size(315, 30);
        txtCity.TabIndex = 19;
        // 
        // txtPassword
        // 
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 10F);
        txtPassword.Location = new Point(217, 509);
        txtPassword.Margin = new Padding(3, 8, 3, 8);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(315, 30);
        txtPassword.TabIndex = 21;
        // 
        // lblPassword
        // 
        lblPassword.Font = new Font("Segoe UI", 9F);
        lblPassword.ForeColor = Color.FromArgb(124, 58, 237);
        lblPassword.ImageAlign = ContentAlignment.TopCenter;
        lblPassword.Location = new Point(3, 501);
        lblPassword.Name = "lblPassword";
        lblPassword.Padding = new Padding(0, 0, 9, 0);
        lblPassword.Size = new Size(208, 46);
        lblPassword.TabIndex = 20;
        lblPassword.Text = "Password";
        lblPassword.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlButtons
        // 
        pnlButtons.Controls.Add(btnCancel);
        pnlButtons.Controls.Add(btnSave);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.FlowDirection = FlowDirection.RightToLeft;
        pnlButtons.Location = new Point(18, 648);
        pnlButtons.Margin = new Padding(3, 4, 3, 4);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new Size(535, 37);
        pnlButtons.TabIndex = 1;
        pnlButtons.WrapContents = false;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Location = new Point(449, 0);
        btnCancel.Margin = new Padding(3, 0, 0, 0);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 35);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(216, 90, 48);
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(315, 0);
        btnSave.Margin = new Padding(0, 0, 9, 0);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(122, 35);
        btnSave.TabIndex = 0;
        btnSave.Text = "Save Customer";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // CustomerEditForm
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 247, 255);
        CancelButton = btnCancel;
        ClientSize = new Size(571, 773);
        Controls.Add(pnlForm);
        Controls.Add(pnlTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CustomerEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Customer";
        pnlTitle.ResumeLayout(false);
        pnlTitle.PerformLayout();
        pnlForm.ResumeLayout(false);
        tblForm.ResumeLayout(false);
        tblForm.PerformLayout();
        pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }
}
