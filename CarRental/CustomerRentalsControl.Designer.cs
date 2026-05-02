using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerRentalsControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Panel pnlCard;
    private DataGridView dgvRentals;
    private Panel pnlFooter;
    private Button btnDeleteRental;

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
        pnlCard = new Panel();
        dgvRentals = new DataGridView();
        pnlFooter = new Panel();
        btnDeleteRental = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
        pnlCard.SuspendLayout();
        SuspendLayout();

        // lblTitle
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = AppTheme.TextPrimary;
        lblTitle.Location = new Point(32, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "My Rentals";

        // pnlCard
        pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlCard.BackColor = AppTheme.CardBg;
        pnlCard.Controls.Add(dgvRentals);
        pnlCard.Controls.Add(pnlFooter);
        pnlCard.Location = new Point(32, 88);
        pnlCard.Name = "pnlCard";
        pnlCard.Padding = new Padding(1);
        pnlCard.Size = new Size(920, 460);
        pnlCard.TabIndex = 1;
        pnlCard.Paint += CardPanel_Paint;

        // dgvRentals
        dgvRentals.AllowUserToAddRows = false;
        dgvRentals.AllowUserToDeleteRows = false;
        dgvRentals.AllowUserToResizeRows = false;
        dgvRentals.AutoGenerateColumns = true;
        dgvRentals.BackgroundColor = AppTheme.CardBg;
        dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRentals.Dock = DockStyle.Fill;
        dgvRentals.Location = new Point(1, 1);
        dgvRentals.MultiSelect = false;
        dgvRentals.Name = "dgvRentals";
        dgvRentals.ReadOnly = true;
        dgvRentals.RowHeadersVisible = false;
        dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRentals.Size = new Size(918, 458);
        dgvRentals.TabIndex = 0;
        dgvRentals.DataBindingComplete += DgvRentals_DataBindingComplete;
        dgvRentals.CellClick += DgvRentals_CellClick;
        dgvRentals.CellFormatting += DgvRentals_CellFormatting;

        // pnlFooter
        // 
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Height = 64;
        pnlFooter.BackColor = AppTheme.CardBg;
        pnlFooter.Padding = new Padding(8);
        pnlFooter.Controls.Add(btnDeleteRental);

        // btnDeleteRental
        // 
        btnDeleteRental.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDeleteRental.BackColor = AppTheme.Accent;
        btnDeleteRental.FlatAppearance.BorderSize = 0;
        btnDeleteRental.FlatStyle = FlatStyle.Flat;
        btnDeleteRental.ForeColor = Color.FromArgb(15,15,22);
        btnDeleteRental.Location = new Point(790, 16);
        btnDeleteRental.Name = "btnDeleteRental";
        btnDeleteRental.Size = new Size(120, 32);
        btnDeleteRental.TabIndex = 1;
        btnDeleteRental.Text = "Delete Rental";
        btnDeleteRental.UseVisualStyleBackColor = false;
        btnDeleteRental.Click += BtnDeleteRental_Click;

        // CustomerRentalsControl
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = AppTheme.ContentBg;
        Controls.Add(pnlCard);
        Controls.Add(lblTitle);
        DoubleBuffered = true;
        Name = "CustomerRentalsControl";
        Size = new Size(1000, 620);
        Resize += CustomerRentalsControl_Resize;

        pnlCard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
