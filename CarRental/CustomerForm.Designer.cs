using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopNav;
    private Panel pnlContent;
    private Label lblBrand;
    private IconButton btnNavHome;
    private IconButton btnNavCars;
    private IconButton btnNavRentals;
    private IconButton btnNavPayments;
    private Panel pnlCustomerInfo;
    private Panel pnlAvatar;
    private Label lblCustomerName;

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
        pnlTopNav = new Panel();
        pnlCustomerInfo = new Panel();
        lblCustomerName = new Label();
        pnlAvatar = new Panel();
        btnNavHome = new IconButton();
        lblBrand = new Label();
        btnNavCars = new IconButton();
        btnNavRentals = new IconButton();
        btnNavPayments = new IconButton();
        pnlContent = new Panel();
        pnlTopNav.SuspendLayout();
        pnlCustomerInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTopNav
        // 
        pnlTopNav.BackColor = Color.FromArgb(10, 10, 15);
        pnlTopNav.Controls.Add(pnlCustomerInfo);
        pnlTopNav.Controls.Add(btnNavHome);
        pnlTopNav.Controls.Add(lblBrand);
        pnlTopNav.Controls.Add(btnNavCars);
        pnlTopNav.Controls.Add(btnNavRentals);
        pnlTopNav.Controls.Add(btnNavPayments);
        pnlTopNav.Dock = DockStyle.Top;
        pnlTopNav.Location = new Point(0, 0);
        pnlTopNav.Name = "pnlTopNav";
        pnlTopNav.Size = new Size(1000, 50);
        pnlTopNav.TabIndex = 0;
        pnlTopNav.Paint += PnlTopNav_Paint;
        // 
        // pnlCustomerInfo
        // 
        pnlCustomerInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pnlCustomerInfo.BackColor = Color.FromArgb(10, 10, 15);
        pnlCustomerInfo.Controls.Add(lblCustomerName);
        pnlCustomerInfo.Controls.Add(pnlAvatar);
        pnlCustomerInfo.Location = new Point(770, 0);
        pnlCustomerInfo.Name = "pnlCustomerInfo";
        pnlCustomerInfo.Size = new Size(220, 50);
        pnlCustomerInfo.TabIndex = 5;
        // 
        // lblCustomerName
        // 
        lblCustomerName.AutoEllipsis = true;
        lblCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblCustomerName.ForeColor = Color.FromArgb(220, 220, 220);
        lblCustomerName.Location = new Point(54, 8);
        lblCustomerName.Name = "lblCustomerName";
        lblCustomerName.Size = new Size(154, 34);
        lblCustomerName.TabIndex = 1;
        lblCustomerName.Text = "Customer";
        lblCustomerName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlAvatar
        // 
        pnlAvatar.BackColor = Color.FromArgb(0, 210, 190);
        pnlAvatar.Location = new Point(12, 10);
        pnlAvatar.Name = "pnlAvatar";
        pnlAvatar.Size = new Size(30, 30);
        pnlAvatar.TabIndex = 0;
        pnlAvatar.Paint += PnlAvatar_Paint;
        // 
        // btnNavHome
        // 
        btnNavHome.BackColor = Color.FromArgb(10, 10, 15);
        btnNavHome.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        btnNavHome.FlatAppearance.BorderSize = 0;
        btnNavHome.FlatStyle = FlatStyle.Flat;
        btnNavHome.ForeColor = Color.FromArgb(80, 80, 100);
        btnNavHome.IconChar = IconChar.House;
        btnNavHome.IconColor = Color.FromArgb(80, 80, 100);
        btnNavHome.IconFont = IconFont.Auto;
        btnNavHome.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavHome.Location = new Point(150, 0);
        btnNavHome.Name = "btnNavHome";
        btnNavHome.Padding = new Padding(4, 0, 4, 0);
        btnNavHome.Size = new Size(144, 50);
        btnNavHome.TabIndex = 1;
        btnNavHome.Text = "Home";
        btnNavHome.TextAlign = ContentAlignment.MiddleLeft;
        btnNavHome.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavHome.UseVisualStyleBackColor = false;
        btnNavHome.Paint += NavButton_Paint;
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(0, 210, 190);
        lblBrand.Location = new Point(16, 14);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(116, 30);
        lblBrand.TabIndex = 0;
        lblBrand.Text = "DriveBase";
        // 
        // btnNavCars
        // 
        btnNavCars.BackColor = Color.FromArgb(10, 10, 15);
        btnNavCars.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        btnNavCars.FlatAppearance.BorderSize = 0;
        btnNavCars.FlatStyle = FlatStyle.Flat;
        btnNavCars.ForeColor = Color.FromArgb(80, 80, 100);
        btnNavCars.IconChar = IconChar.Car;
        btnNavCars.IconColor = Color.FromArgb(80, 80, 100);
        btnNavCars.IconFont = IconFont.Auto;
        btnNavCars.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavCars.Location = new Point(292, 1);
        btnNavCars.Name = "btnNavCars";
        btnNavCars.Padding = new Padding(4, 0, 4, 0);
        btnNavCars.Size = new Size(152, 50);
        btnNavCars.TabIndex = 2;
        btnNavCars.Text = "Book a Rental";
        btnNavCars.TextAlign = ContentAlignment.MiddleLeft;
        btnNavCars.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavCars.UseVisualStyleBackColor = false;
        btnNavCars.Paint += NavButton_Paint;
        // 
        // btnNavRentals
        // 
        btnNavRentals.BackColor = Color.FromArgb(10, 10, 15);
        btnNavRentals.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        btnNavRentals.FlatAppearance.BorderSize = 0;
        btnNavRentals.FlatStyle = FlatStyle.Flat;
        btnNavRentals.ForeColor = Color.FromArgb(80, 80, 100);
        btnNavRentals.IconChar = IconChar.ClipboardList;
        btnNavRentals.IconColor = Color.FromArgb(80, 80, 100);
        btnNavRentals.IconFont = IconFont.Auto;
        btnNavRentals.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavRentals.Location = new Point(450, 0);
        btnNavRentals.Name = "btnNavRentals";
        btnNavRentals.Padding = new Padding(4, 0, 4, 0);
        btnNavRentals.Size = new Size(138, 50);
        btnNavRentals.TabIndex = 3;
        btnNavRentals.Text = "My Rentals";
        btnNavRentals.TextAlign = ContentAlignment.MiddleLeft;
        btnNavRentals.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavRentals.UseVisualStyleBackColor = false;
        btnNavRentals.Paint += NavButton_Paint;
        // 
        // btnNavPayments
        // 
        btnNavPayments.BackColor = Color.FromArgb(10, 10, 15);
        btnNavPayments.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 15);
        btnNavPayments.FlatAppearance.BorderSize = 0;
        btnNavPayments.FlatStyle = FlatStyle.Flat;
        btnNavPayments.ForeColor = Color.FromArgb(80, 80, 100);
        btnNavPayments.IconChar = IconChar.CreditCard;
        btnNavPayments.IconColor = Color.FromArgb(80, 80, 100);
        btnNavPayments.IconFont = IconFont.Auto;
        btnNavPayments.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavPayments.Location = new Point(594, 1);
        btnNavPayments.Name = "btnNavPayments";
        btnNavPayments.Padding = new Padding(4, 0, 4, 0);
        btnNavPayments.Size = new Size(170, 50);
        btnNavPayments.TabIndex = 4;
        btnNavPayments.Text = "Pending Payments";
        btnNavPayments.TextAlign = ContentAlignment.MiddleLeft;
        btnNavPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavPayments.UseVisualStyleBackColor = false;
        btnNavPayments.Paint += NavButton_Paint;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(15, 15, 22);
        pnlContent.Location = new Point(0, 47);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(1000, 573);
        pnlContent.TabIndex = 1;
        pnlContent.TabStop = true;
        // 
        // CustomerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        ClientSize = new Size(1000, 620);
        Controls.Add(pnlContent);
        Controls.Add(pnlTopNav);
        MinimumSize = new Size(920, 580);
        Name = "CustomerForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DriveBase — Customer Portal";
        pnlTopNav.ResumeLayout(false);
        pnlTopNav.PerformLayout();
        pnlCustomerInfo.ResumeLayout(false);
        ResumeLayout(false);
    }
}
