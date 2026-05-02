using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class SignUpForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTitle;
    private Label lblTitle;
    private TableLayoutPanel tlpForm;
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
    private Label lblConfirmPassword;
    private Button btnSave;
    private TextBox txtConfirmPassword;

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
        tlpForm = new TableLayoutPanel();
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
        lblPassword = new Label();
        txtPassword = new TextBox();
        txtConfirmPassword = new TextBox();
        lblConfirmPassword = new Label();
        btnSave = new Button();
        pnlTitle.SuspendLayout();
        tlpForm.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTitle
        // 
        pnlTitle.BackColor = Color.FromArgb(0, 210, 190);
        pnlTitle.Controls.Add(lblTitle);
        pnlTitle.Dock = DockStyle.Top;
        pnlTitle.Location = new Point(0, 0);
        pnlTitle.Name = "pnlTitle";
        pnlTitle.Padding = new Padding(16);
        pnlTitle.Size = new Size(571, 60);
        pnlTitle.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(237, 233, 254);
        lblTitle.Location = new Point(16, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(172, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Create Account";
        // 
        // tlpForm
        // 
        tlpForm.BackColor = Color.FromArgb(15, 15, 22);
        tlpForm.ColumnCount = 2;
        tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tlpForm.Controls.Add(lblSSN, 0, 0);
        tlpForm.Controls.Add(txtSSN, 1, 0);
        tlpForm.Controls.Add(lblName, 0, 1);
        tlpForm.Controls.Add(txtName, 1, 1);
        tlpForm.Controls.Add(lblEmail, 0, 2);
        tlpForm.Controls.Add(txtEmail, 1, 2);
        tlpForm.Controls.Add(lblPhone, 0, 3);
        tlpForm.Controls.Add(txtPhone, 1, 3);
        tlpForm.Controls.Add(lblBirth, 0, 4);
        tlpForm.Controls.Add(dtpBirth, 1, 4);
        tlpForm.Controls.Add(lblDLN, 0, 5);
        tlpForm.Controls.Add(txtDLN, 1, 5);
        tlpForm.Controls.Add(lblHouseNo, 0, 6);
        tlpForm.Controls.Add(txtHouseNo, 1, 6);
        tlpForm.Controls.Add(lblStreet, 0, 7);
        tlpForm.Controls.Add(txtStreet, 1, 7);
        tlpForm.Controls.Add(lblDistrict, 0, 8);
        tlpForm.Controls.Add(txtDistrict, 1, 8);
        tlpForm.Controls.Add(lblCity, 0, 9);
        tlpForm.Controls.Add(txtCity, 1, 9);
        tlpForm.Controls.Add(lblPassword, 0, 10);
        tlpForm.Controls.Add(txtPassword, 1, 10);
        tlpForm.Controls.Add(txtConfirmPassword, 1, 11);
        tlpForm.Controls.Add(lblConfirmPassword, 0, 11);
        tlpForm.Controls.Add(btnSave, 1, 12);
        tlpForm.Dock = DockStyle.Fill;
        tlpForm.Location = new Point(0, 60);
        tlpForm.Name = "tlpForm";
        tlpForm.Padding = new Padding(16);
        tlpForm.RowCount = 13;
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 191F));
        tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
        tlpForm.Size = new Size(571, 820);
        tlpForm.TabIndex = 1;
        // 
        // lblSSN
        // 
        lblSSN.AutoSize = true;
        lblSSN.Dock = DockStyle.Fill;
        lblSSN.Font = new Font("Segoe UI", 9F);
        lblSSN.ForeColor = Color.FromArgb(0, 210, 190);
        lblSSN.Location = new Point(19, 16);
        lblSSN.Name = "lblSSN";
        lblSSN.Size = new Size(209, 50);
        lblSSN.TabIndex = 0;
        lblSSN.Text = "SSN";
        lblSSN.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtSSN
        // 
        txtSSN.BackColor = Color.FromArgb(15, 15, 22);
        txtSSN.BorderStyle = BorderStyle.FixedSingle;
        txtSSN.Dock = DockStyle.Fill;
        txtSSN.Font = new Font("Segoe UI", 9F);
        txtSSN.ForeColor = SystemColors.Window;
        txtSSN.Location = new Point(234, 19);
        txtSSN.Name = "txtSSN";
        txtSSN.Size = new Size(318, 27);
        txtSSN.TabIndex = 1;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Dock = DockStyle.Fill;
        lblName.Font = new Font("Segoe UI", 9F);
        lblName.ForeColor = Color.FromArgb(0, 210, 190);
        lblName.Location = new Point(19, 66);
        lblName.Name = "lblName";
        lblName.Size = new Size(209, 50);
        lblName.TabIndex = 2;
        lblName.Text = "Full Name";
        lblName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtName
        // 
        txtName.BackColor = Color.FromArgb(15, 15, 22);
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Dock = DockStyle.Fill;
        txtName.Font = new Font("Segoe UI", 9F);
        txtName.ForeColor = SystemColors.Window;
        txtName.Location = new Point(234, 69);
        txtName.Name = "txtName";
        txtName.Size = new Size(318, 27);
        txtName.TabIndex = 3;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Dock = DockStyle.Fill;
        lblEmail.Font = new Font("Segoe UI", 9F);
        lblEmail.ForeColor = Color.FromArgb(0, 210, 190);
        lblEmail.Location = new Point(19, 116);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(209, 50);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email";
        lblEmail.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtEmail
        // 
        txtEmail.BackColor = Color.FromArgb(15, 15, 22);
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Dock = DockStyle.Fill;
        txtEmail.Font = new Font("Segoe UI", 9F);
        txtEmail.ForeColor = SystemColors.Window;
        txtEmail.Location = new Point(234, 119);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(318, 27);
        txtEmail.TabIndex = 5;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Dock = DockStyle.Fill;
        lblPhone.Font = new Font("Segoe UI", 9F);
        lblPhone.ForeColor = Color.FromArgb(0, 210, 190);
        lblPhone.Location = new Point(19, 166);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(209, 50);
        lblPhone.TabIndex = 6;
        lblPhone.Text = "Phone Number";
        lblPhone.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtPhone
        // 
        txtPhone.BackColor = Color.FromArgb(15, 15, 22);
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Dock = DockStyle.Fill;
        txtPhone.Font = new Font("Segoe UI", 9F);
        txtPhone.ForeColor = Color.White;
        txtPhone.Location = new Point(234, 169);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(318, 27);
        txtPhone.TabIndex = 7;
        // 
        // lblBirth
        // 
        lblBirth.AutoSize = true;
        lblBirth.Dock = DockStyle.Fill;
        lblBirth.Font = new Font("Segoe UI", 9F);
        lblBirth.ForeColor = Color.FromArgb(0, 210, 190);
        lblBirth.Location = new Point(19, 216);
        lblBirth.Name = "lblBirth";
        lblBirth.Size = new Size(209, 50);
        lblBirth.TabIndex = 8;
        lblBirth.Text = "Birthdate";
        lblBirth.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dtpBirth
        // 
        dtpBirth.CalendarMonthBackground = SystemColors.HighlightText;
        dtpBirth.Dock = DockStyle.Fill;
        dtpBirth.Format = DateTimePickerFormat.Short;
        dtpBirth.Location = new Point(234, 219);
        dtpBirth.Name = "dtpBirth";
        dtpBirth.Size = new Size(318, 27);
        dtpBirth.TabIndex = 9;
        // 
        // lblDLN
        // 
        lblDLN.AutoSize = true;
        lblDLN.Dock = DockStyle.Fill;
        lblDLN.Font = new Font("Segoe UI", 9F);
        lblDLN.ForeColor = Color.FromArgb(0, 210, 190);
        lblDLN.Location = new Point(19, 266);
        lblDLN.Name = "lblDLN";
        lblDLN.Size = new Size(209, 50);
        lblDLN.TabIndex = 10;
        lblDLN.Text = "Driver License No.";
        lblDLN.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDLN
        // 
        txtDLN.BackColor = Color.FromArgb(15, 15, 22);
        txtDLN.BorderStyle = BorderStyle.FixedSingle;
        txtDLN.Dock = DockStyle.Fill;
        txtDLN.Font = new Font("Segoe UI", 9F);
        txtDLN.ForeColor = SystemColors.Window;
        txtDLN.Location = new Point(234, 269);
        txtDLN.Name = "txtDLN";
        txtDLN.Size = new Size(318, 27);
        txtDLN.TabIndex = 11;
        // 
        // lblHouseNo
        // 
        lblHouseNo.AutoSize = true;
        lblHouseNo.Dock = DockStyle.Fill;
        lblHouseNo.Font = new Font("Segoe UI", 9F);
        lblHouseNo.ForeColor = Color.FromArgb(0, 210, 190);
        lblHouseNo.Location = new Point(19, 316);
        lblHouseNo.Name = "lblHouseNo";
        lblHouseNo.Size = new Size(209, 50);
        lblHouseNo.TabIndex = 12;
        lblHouseNo.Text = "House Number";
        lblHouseNo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtHouseNo
        // 
        txtHouseNo.BackColor = Color.FromArgb(15, 15, 22);
        txtHouseNo.BorderStyle = BorderStyle.FixedSingle;
        txtHouseNo.Dock = DockStyle.Fill;
        txtHouseNo.Font = new Font("Segoe UI", 9F);
        txtHouseNo.ForeColor = SystemColors.Window;
        txtHouseNo.Location = new Point(234, 319);
        txtHouseNo.Name = "txtHouseNo";
        txtHouseNo.Size = new Size(318, 27);
        txtHouseNo.TabIndex = 13;
        // 
        // lblStreet
        // 
        lblStreet.AutoSize = true;
        lblStreet.Dock = DockStyle.Fill;
        lblStreet.Font = new Font("Segoe UI", 9F);
        lblStreet.ForeColor = Color.FromArgb(0, 210, 190);
        lblStreet.Location = new Point(19, 366);
        lblStreet.Name = "lblStreet";
        lblStreet.Size = new Size(209, 50);
        lblStreet.TabIndex = 14;
        lblStreet.Text = "Street";
        lblStreet.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtStreet
        // 
        txtStreet.BackColor = Color.FromArgb(15, 15, 22);
        txtStreet.BorderStyle = BorderStyle.FixedSingle;
        txtStreet.Dock = DockStyle.Fill;
        txtStreet.Font = new Font("Segoe UI", 9F);
        txtStreet.ForeColor = SystemColors.Window;
        txtStreet.Location = new Point(234, 369);
        txtStreet.Name = "txtStreet";
        txtStreet.Size = new Size(318, 27);
        txtStreet.TabIndex = 15;
        // 
        // lblDistrict
        // 
        lblDistrict.AutoSize = true;
        lblDistrict.Dock = DockStyle.Fill;
        lblDistrict.Font = new Font("Segoe UI", 9F);
        lblDistrict.ForeColor = Color.FromArgb(0, 210, 190);
        lblDistrict.Location = new Point(19, 416);
        lblDistrict.Name = "lblDistrict";
        lblDistrict.Size = new Size(209, 50);
        lblDistrict.TabIndex = 16;
        lblDistrict.Text = "District";
        lblDistrict.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtDistrict
        // 
        txtDistrict.BackColor = Color.FromArgb(15, 15, 22);
        txtDistrict.BorderStyle = BorderStyle.FixedSingle;
        txtDistrict.Dock = DockStyle.Fill;
        txtDistrict.Font = new Font("Segoe UI", 9F);
        txtDistrict.ForeColor = SystemColors.Window;
        txtDistrict.Location = new Point(234, 419);
        txtDistrict.Name = "txtDistrict";
        txtDistrict.Size = new Size(318, 27);
        txtDistrict.TabIndex = 17;
        // 
        // lblCity
        // 
        lblCity.AutoSize = true;
        lblCity.Dock = DockStyle.Fill;
        lblCity.Font = new Font("Segoe UI", 9F);
        lblCity.ForeColor = Color.FromArgb(0, 210, 190);
        lblCity.Location = new Point(19, 466);
        lblCity.Name = "lblCity";
        lblCity.Size = new Size(209, 50);
        lblCity.TabIndex = 18;
        lblCity.Text = "City";
        lblCity.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtCity
        // 
        txtCity.BackColor = Color.FromArgb(15, 15, 22);
        txtCity.BorderStyle = BorderStyle.FixedSingle;
        txtCity.Dock = DockStyle.Fill;
        txtCity.Font = new Font("Segoe UI", 9F);
        txtCity.ForeColor = SystemColors.Window;
        txtCity.Location = new Point(234, 469);
        txtCity.Name = "txtCity";
        txtCity.Size = new Size(318, 27);
        txtCity.TabIndex = 19;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Dock = DockStyle.Fill;
        lblPassword.Font = new Font("Segoe UI", 9F);
        lblPassword.ForeColor = Color.FromArgb(0, 210, 190);
        lblPassword.Location = new Point(19, 516);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(209, 50);
        lblPassword.TabIndex = 20;
        lblPassword.Text = "Password";
        lblPassword.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(15, 15, 22);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Dock = DockStyle.Fill;
        txtPassword.Font = new Font("Segoe UI", 9F);
        txtPassword.ForeColor = SystemColors.Window;
        txtPassword.Location = new Point(234, 519);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(318, 27);
        txtPassword.TabIndex = 21;
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.BackColor = Color.FromArgb(15, 15, 22);
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
        txtConfirmPassword.Dock = DockStyle.Fill;
        txtConfirmPassword.Font = new Font("Segoe UI", 9F);
        txtConfirmPassword.ForeColor = SystemColors.Window;
        txtConfirmPassword.Location = new Point(234, 569);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.PasswordChar = '*';
        txtConfirmPassword.Size = new Size(318, 27);
        txtConfirmPassword.TabIndex = 23;
        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.Dock = DockStyle.Top;
        lblConfirmPassword.Font = new Font("Segoe UI", 9F);
        lblConfirmPassword.ForeColor = Color.FromArgb(0, 210, 190);
        lblConfirmPassword.Location = new Point(19, 566);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new Size(209, 30);
        lblConfirmPassword.TabIndex = 22;
        lblConfirmPassword.Text = "Confirm Password";
        lblConfirmPassword.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(0, 210, 190);
        btnSave.Dock = DockStyle.Right;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.FromArgb(10, 10, 15);
        btnSave.Location = new Point(402, 760);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(150, 41);
        btnSave.TabIndex = 24;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        // 
        // SignUpForm
        // 
        ClientSize = new Size(571, 880);
        Controls.Add(tlpForm);
        Controls.Add(pnlTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SignUpForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Sign Up";
        pnlTitle.ResumeLayout(false);
        pnlTitle.PerformLayout();
        tlpForm.ResumeLayout(false);
        tlpForm.PerformLayout();
        ResumeLayout(false);
    }
}
