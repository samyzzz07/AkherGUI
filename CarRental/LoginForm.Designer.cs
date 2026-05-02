namespace CarRental;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.PictureBox picLogo;
    private System.Windows.Forms.Label lblAppName;
    private System.Windows.Forms.Label lblAppSub;
    private System.Windows.Forms.Panel pnlLoginFields;
    private System.Windows.Forms.Label lblSsn;
    private System.Windows.Forms.TextBox txtSSN;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnSignUp;
    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblSubText;
    private System.Windows.Forms.Panel pnlCard1;
    private System.Windows.Forms.Panel pnlCard2;
    private System.Windows.Forms.Panel pnlCard3;
    private FontAwesome.Sharp.IconPictureBox pnlIcon1;
    private FontAwesome.Sharp.IconPictureBox pnlIcon2;
    private FontAwesome.Sharp.IconPictureBox pnlIcon3;
    private System.Windows.Forms.Label lblCard1Title;
    private System.Windows.Forms.Label lblCard1Sub;
    private System.Windows.Forms.Label lblCard2Title;
    private System.Windows.Forms.Label lblCard2Sub;
    private System.Windows.Forms.Label lblCard3Title;
    private System.Windows.Forms.Label lblCard3Sub;

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
        pnlLeft = new Panel();
        picLogo = new PictureBox();
        pnlLoginFields = new Panel();
        btnSignUp = new Button();
        btnLogin = new Button();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtSSN = new TextBox();
        lblSsn = new Label();
        lblAppSub = new Label();
        lblAppName = new Label();
        pnlRight = new Panel();
        pnlCard3 = new Panel();
        lblCard3Sub = new Label();
        lblCard3Title = new Label();
        pnlIcon3 = new FontAwesome.Sharp.IconPictureBox();
        pnlCard2 = new Panel();
        lblCard2Sub = new Label();
        lblCard2Title = new Label();
        pnlIcon2 = new FontAwesome.Sharp.IconPictureBox();
        pnlCard1 = new Panel();
        lblCard1Sub = new Label();
        lblCard1Title = new Label();
        pnlIcon1 = new FontAwesome.Sharp.IconPictureBox();
        lblSubText = new Label();
        lblWelcome = new Label();
        pnlLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlLoginFields.SuspendLayout();
        pnlRight.SuspendLayout();
        pnlCard3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon3).BeginInit();
        pnlCard2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon2).BeginInit();
        pnlCard1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon1).BeginInit();
        SuspendLayout();
        // 
        // pnlLeft
        // 
        pnlLeft.BackColor = Color.FromArgb(1, 5, 16);
        pnlLeft.Controls.Add(picLogo);
        pnlLeft.Controls.Add(pnlLoginFields);
        pnlLeft.Controls.Add(lblAppSub);
        pnlLeft.Controls.Add(lblAppName);
        pnlLeft.Dock = DockStyle.Left;
        pnlLeft.Location = new Point(0, 0);
        pnlLeft.Margin = new Padding(3, 4, 3, 4);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new Size(320, 613);
        pnlLeft.TabIndex = 0;
        // 
        // picLogo
        // 
        picLogo.BackColor = Color.Transparent;
        picLogo.BackgroundImageLayout = ImageLayout.None;
        picLogo.Image = Properties.Resources.ChatGPT_Image_May_2__2026__10_58_53_PM;
        picLogo.Location = new Point(105, 40);
        picLogo.Margin = new Padding(3, 4, 3, 4);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(98, 95);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // pnlLoginFields
        // 
        pnlLoginFields.AutoSize = true;
        pnlLoginFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        pnlLoginFields.Controls.Add(btnSignUp);
        pnlLoginFields.Controls.Add(btnLogin);
        pnlLoginFields.Controls.Add(txtPassword);
        pnlLoginFields.Controls.Add(lblPassword);
        pnlLoginFields.Controls.Add(txtSSN);
        pnlLoginFields.Controls.Add(lblSsn);
        pnlLoginFields.Location = new Point(34, 243);
        pnlLoginFields.Margin = new Padding(3, 4, 3, 4);
        pnlLoginFields.Name = "pnlLoginFields";
        pnlLoginFields.Size = new Size(254, 251);
        pnlLoginFields.TabIndex = 3;
        // 
        // btnSignUp
        // 
        btnSignUp.AutoSize = true;
        btnSignUp.BackColor = Color.Transparent;
        btnSignUp.FlatAppearance.BorderSize = 0;
        btnSignUp.FlatStyle = FlatStyle.Flat;
        btnSignUp.Font = new Font("Segoe UI", 9F);
        btnSignUp.ForeColor = Color.FromArgb(0, 210, 190);
        btnSignUp.Location = new Point(0, 218);
        btnSignUp.Name = "btnSignUp";
        btnSignUp.Size = new Size(229, 30);
        btnSignUp.TabIndex = 5;
        btnSignUp.Text = "Don't have an account? Sign Up";
        btnSignUp.UseVisualStyleBackColor = false;
        btnSignUp.Click += btnSignUp_Click;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(0, 210, 190);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLogin.ForeColor = Color.FromArgb(10, 10, 15);
        btnLogin.Location = new Point(0, 157);
        btnLogin.Margin = new Padding(3, 4, 3, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(251, 51);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Sign In";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(22, 22, 32);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.ForeColor = Color.FromArgb(230, 230, 230);
        txtPassword.Location = new Point(0, 104);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(251, 32);
        txtPassword.TabIndex = 3;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 9F);
        lblPassword.ForeColor = Color.FromArgb(0, 210, 190);
        lblPassword.Location = new Point(0, 77);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Password";
        // 
        // txtSSN
        // 
        txtSSN.BackColor = Color.FromArgb(22, 22, 32);
        txtSSN.BorderStyle = BorderStyle.FixedSingle;
        txtSSN.Font = new Font("Segoe UI", 11F);
        txtSSN.ForeColor = Color.FromArgb(230, 230, 230);
        txtSSN.Location = new Point(0, 27);
        txtSSN.Margin = new Padding(3, 4, 3, 4);
        txtSSN.Name = "txtSSN";
        txtSSN.Size = new Size(251, 32);
        txtSSN.TabIndex = 1;
        // 
        // lblSsn
        // 
        lblSsn.AutoSize = true;
        lblSsn.Font = new Font("Segoe UI", 9F);
        lblSsn.ForeColor = Color.FromArgb(0, 210, 190);
        lblSsn.Location = new Point(0, 0);
        lblSsn.Name = "lblSsn";
        lblSsn.Size = new Size(121, 20);
        lblSsn.TabIndex = 0;
        lblSsn.Text = "SSN or Admin ID";
        // 
        // lblAppSub
        // 
        lblAppSub.Font = new Font("Segoe UI", 10F);
        lblAppSub.ForeColor = Color.FromArgb(0, 210, 190);
        lblAppSub.Location = new Point(23, 184);
        lblAppSub.Name = "lblAppSub";
        lblAppSub.Size = new Size(274, 27);
        lblAppSub.TabIndex = 2;
        lblAppSub.Text = "Car Rental Management";
        lblAppSub.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblAppName
        // 
        lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblAppName.ForeColor = Color.FromArgb(230, 230, 230);
        lblAppName.Location = new Point(23, 123);
        lblAppName.Name = "lblAppName";
        lblAppName.Size = new Size(274, 56);
        lblAppName.TabIndex = 1;
        lblAppName.Text = "DriveBase";
        lblAppName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlRight
        // 
        pnlRight.BackColor = Color.FromArgb(15, 15, 22);
        pnlRight.Controls.Add(pnlCard3);
        pnlRight.Controls.Add(pnlCard2);
        pnlRight.Controls.Add(pnlCard1);
        pnlRight.Controls.Add(lblSubText);
        pnlRight.Controls.Add(lblWelcome);
        pnlRight.Dock = DockStyle.Fill;
        pnlRight.Location = new Point(320, 0);
        pnlRight.Margin = new Padding(3, 4, 3, 4);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new Size(480, 613);
        pnlRight.TabIndex = 1;
        // 
        // pnlCard3
        // 
        pnlCard3.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard3.BorderStyle = BorderStyle.FixedSingle;
        pnlCard3.Controls.Add(lblCard3Sub);
        pnlCard3.Controls.Add(lblCard3Title);
        pnlCard3.Controls.Add(pnlIcon3);
        pnlCard3.Location = new Point(34, 347);
        pnlCard3.Margin = new Padding(3, 4, 3, 4);
        pnlCard3.Name = "pnlCard3";
        pnlCard3.Size = new Size(423, 74);
        pnlCard3.TabIndex = 4;
        // 
        // lblCard3Sub
        // 
        lblCard3Sub.AutoSize = true;
        lblCard3Sub.Font = new Font("Segoe UI", 9F);
        lblCard3Sub.ForeColor = Color.FromArgb(130, 130, 150);
        lblCard3Sub.Location = new Point(59, 37);
        lblCard3Sub.Name = "lblCard3Sub";
        lblCard3Sub.Size = new Size(192, 20);
        lblCard3Sub.TabIndex = 2;
        lblCard3Sub.Text = "Settle outstanding balances";
        // 
        // lblCard3Title
        // 
        lblCard3Title.AutoSize = true;
        lblCard3Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCard3Title.ForeColor = Color.FromArgb(230, 230, 230);
        lblCard3Title.Location = new Point(59, 11);
        lblCard3Title.Name = "lblCard3Title";
        lblCard3Title.Size = new Size(139, 20);
        lblCard3Title.TabIndex = 1;
        lblCard3Title.Text = "Pending Payments";
        // 
        // pnlIcon3
        // 
        pnlIcon3.BackColor = Color.FromArgb(0, 40, 38);
        pnlIcon3.ForeColor = Color.FromArgb(0, 210, 190);
        pnlIcon3.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
        pnlIcon3.IconColor = Color.FromArgb(0, 210, 190);
        pnlIcon3.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pnlIcon3.IconSize = 36;
        pnlIcon3.Location = new Point(10, 19);
        pnlIcon3.Name = "pnlIcon3";
        pnlIcon3.Size = new Size(36, 36);
        pnlIcon3.TabIndex = 0;
        pnlIcon3.TabStop = false;
        // 
        // pnlCard2
        // 
        pnlCard2.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard2.BorderStyle = BorderStyle.FixedSingle;
        pnlCard2.Controls.Add(lblCard2Sub);
        pnlCard2.Controls.Add(lblCard2Title);
        pnlCard2.Controls.Add(pnlIcon2);
        pnlCard2.Location = new Point(34, 253);
        pnlCard2.Margin = new Padding(3, 4, 3, 4);
        pnlCard2.Name = "pnlCard2";
        pnlCard2.Size = new Size(423, 74);
        pnlCard2.TabIndex = 3;
        // 
        // lblCard2Sub
        // 
        lblCard2Sub.AutoSize = true;
        lblCard2Sub.Font = new Font("Segoe UI", 9F);
        lblCard2Sub.ForeColor = Color.FromArgb(130, 130, 150);
        lblCard2Sub.Location = new Point(59, 37);
        lblCard2Sub.Name = "lblCard2Sub";
        lblCard2Sub.Size = new Size(168, 20);
        lblCard2Sub.TabIndex = 2;
        lblCard2Sub.Text = "View active & past rentals";
        // 
        // lblCard2Title
        // 
        lblCard2Title.AutoSize = true;
        lblCard2Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCard2Title.ForeColor = Color.FromArgb(230, 230, 230);
        lblCard2Title.Location = new Point(59, 11);
        lblCard2Title.Name = "lblCard2Title";
        lblCard2Title.Size = new Size(87, 20);
        lblCard2Title.TabIndex = 1;
        lblCard2Title.Text = "My Rentals";
        // 
        // pnlIcon2
        // 
        pnlIcon2.BackColor = Color.FromArgb(0, 40, 38);
        pnlIcon2.ForeColor = Color.FromArgb(0, 210, 190);
        pnlIcon2.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
        pnlIcon2.IconColor = Color.FromArgb(0, 210, 190);
        pnlIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pnlIcon2.IconSize = 36;
        pnlIcon2.Location = new Point(10, 19);
        pnlIcon2.Name = "pnlIcon2";
        pnlIcon2.Size = new Size(36, 36);
        pnlIcon2.TabIndex = 0;
        pnlIcon2.TabStop = false;
        // 
        // pnlCard1
        // 
        pnlCard1.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard1.BorderStyle = BorderStyle.FixedSingle;
        pnlCard1.Controls.Add(lblCard1Sub);
        pnlCard1.Controls.Add(lblCard1Title);
        pnlCard1.Controls.Add(pnlIcon1);
        pnlCard1.Location = new Point(34, 160);
        pnlCard1.Margin = new Padding(3, 4, 3, 4);
        pnlCard1.Name = "pnlCard1";
        pnlCard1.Size = new Size(423, 74);
        pnlCard1.TabIndex = 2;
        // 
        // lblCard1Sub
        // 
        lblCard1Sub.AutoSize = true;
        lblCard1Sub.Font = new Font("Segoe UI", 9F);
        lblCard1Sub.ForeColor = Color.FromArgb(130, 130, 150);
        lblCard1Sub.Location = new Point(59, 37);
        lblCard1Sub.Name = "lblCard1Sub";
        lblCard1Sub.Size = new Size(193, 20);
        lblCard1Sub.TabIndex = 2;
        lblCard1Sub.Text = "Browse & book available cars";
        // 
        // lblCard1Title
        // 
        lblCard1Title.AutoSize = true;
        lblCard1Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCard1Title.ForeColor = Color.FromArgb(230, 230, 230);
        lblCard1Title.Location = new Point(59, 11);
        lblCard1Title.Name = "lblCard1Title";
        lblCard1Title.Size = new Size(107, 20);
        lblCard1Title.TabIndex = 1;
        lblCard1Title.Text = "Rent a Vehicle";
        // 
        // pnlIcon1
        // 
        pnlIcon1.BackColor = Color.FromArgb(0, 40, 38);
        pnlIcon1.ForeColor = Color.FromArgb(0, 210, 190);
        pnlIcon1.IconChar = FontAwesome.Sharp.IconChar.Car;
        pnlIcon1.IconColor = Color.FromArgb(0, 210, 190);
        pnlIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pnlIcon1.IconSize = 36;
        pnlIcon1.Location = new Point(10, 19);
        pnlIcon1.Name = "pnlIcon1";
        pnlIcon1.Size = new Size(36, 36);
        pnlIcon1.TabIndex = 0;
        pnlIcon1.TabStop = false;
        // 
        // lblSubText
        // 
        lblSubText.AutoSize = true;
        lblSubText.Font = new Font("Segoe UI", 10F);
        lblSubText.ForeColor = Color.FromArgb(130, 130, 150);
        lblSubText.Location = new Point(34, 91);
        lblSubText.Name = "lblSubText";
        lblSubText.Size = new Size(241, 23);
        lblSubText.TabIndex = 1;
        lblSubText.Text = "Sign in to access your account";
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblWelcome.ForeColor = Color.FromArgb(230, 230, 230);
        lblWelcome.Location = new Point(34, 40);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(203, 37);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Welcome back";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 10, 15);
        ClientSize = new Size(800, 613);
        Controls.Add(pnlRight);
        Controls.Add(pnlLeft);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DriveBase — Car Rental System";
        pnlLeft.ResumeLayout(false);
        pnlLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlLoginFields.ResumeLayout(false);
        pnlLoginFields.PerformLayout();
        pnlRight.ResumeLayout(false);
        pnlRight.PerformLayout();
        pnlCard3.ResumeLayout(false);
        pnlCard3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon3).EndInit();
        pnlCard2.ResumeLayout(false);
        pnlCard2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon2).EndInit();
        pnlCard1.ResumeLayout(false);
        pnlCard1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlIcon1).EndInit();
        ResumeLayout(false);
    }
}