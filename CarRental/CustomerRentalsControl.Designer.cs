using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerRentalsControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Panel pnlCard;
    private DataGridView dgvRentals;
    private Panel pnlActions;
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
        pnlActions = new Panel();
        btnDeleteRental = new Button();
        pnlCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(32, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(213, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "My Rentals";
        // 
        // pnlCard
        // 
        pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlCard.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard.Controls.Add(dgvRentals);
        pnlCard.Location = new Point(32, 88);
        pnlCard.Name = "pnlCard";
        pnlCard.Padding = new Padding(1);
        pnlCard.Size = new Size(920, 460);
        pnlCard.TabIndex = 1;
        pnlCard.Paint += CardPanel_Paint;
        // 
        // dgvRentals
        // 
        dgvRentals.AllowUserToAddRows = false;
        dgvRentals.AllowUserToDeleteRows = false;
        dgvRentals.AllowUserToResizeRows = false;
        dgvRentals.BackgroundColor = Color.FromArgb(22, 22, 32);
        dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRentals.Dock = DockStyle.Fill;
        dgvRentals.Location = new Point(1, 1);
        dgvRentals.MultiSelect = false;
        dgvRentals.Name = "dgvRentals";
        dgvRentals.ReadOnly = true;
        dgvRentals.RowHeadersVisible = false;
        dgvRentals.RowHeadersWidth = 51;
        dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRentals.Size = new Size(918, 458);
        dgvRentals.TabIndex = 0;
        dgvRentals.CellClick += DgvRentals_CellClick;
        dgvRentals.CellFormatting += DgvRentals_CellFormatting;
        dgvRentals.DataBindingComplete += DgvRentals_DataBindingComplete;
        // 
        // pnlActions
        // 
        pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        pnlActions.BackColor = Color.FromArgb(15, 15, 22);
        pnlActions.Controls.Add(btnDeleteRental);
        pnlActions.Location = new Point(33, 554);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(120, 32);
        pnlActions.TabIndex = 2;
        // 
        // btnDeleteRental
        // 
        btnDeleteRental.Anchor = AnchorStyles.None;
        btnDeleteRental.BackColor = Color.FromArgb(0, 210, 190);
        btnDeleteRental.FlatAppearance.BorderSize = 0;
        btnDeleteRental.FlatStyle = FlatStyle.Flat;
        btnDeleteRental.ForeColor = Color.FromArgb(15, 15, 22);
        btnDeleteRental.Location = new Point(0, -3);
        btnDeleteRental.Name = "btnDeleteRental";
        btnDeleteRental.Size = new Size(120, 32);
        btnDeleteRental.TabIndex = 1;
        btnDeleteRental.Text = "Delete Rental";
        btnDeleteRental.UseVisualStyleBackColor = false;
        btnDeleteRental.Click += BtnDeleteRental_Click;
        // 
        // CustomerRentalsControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlCard);
        Controls.Add(pnlActions);
        Controls.Add(lblTitle);
        DoubleBuffered = true;
        Name = "CustomerRentalsControl";
        Size = new Size(1000, 620);
        Resize += CustomerRentalsControl_Resize;
        pnlCard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
