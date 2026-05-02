using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerCarsControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Panel pnlCard;
    private DataGridView dgvCars;

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
        dgvCars = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
        pnlCard.SuspendLayout();
        SuspendLayout();

        // lblTitle
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = AppTheme.TextPrimary;
        lblTitle.Location = new Point(32, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(200, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Available Cars";

        // pnlCard
        pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlCard.BackColor = AppTheme.CardBg;
        pnlCard.Controls.Add(dgvCars);
        pnlCard.Location = new Point(32, 80);
        pnlCard.Name = "pnlCard";
        pnlCard.Padding = new Padding(1);
        pnlCard.Size = new Size(920, 460);
        pnlCard.TabIndex = 1;
        pnlCard.Paint += CardPanel_Paint;

        // dgvCars
        dgvCars.AllowUserToAddRows = false;
        dgvCars.AllowUserToDeleteRows = false;
        dgvCars.AllowUserToResizeRows = false;
        dgvCars.AutoGenerateColumns = true;
        dgvCars.BackgroundColor = AppTheme.CardBg;
        dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCars.Dock = DockStyle.Fill;
        dgvCars.Location = new Point(1, 1);
        dgvCars.MultiSelect = false;
        dgvCars.Name = "dgvCars";
        dgvCars.ReadOnly = true;
        dgvCars.RowHeadersVisible = false;
        dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCars.Size = new Size(918, 458);
        dgvCars.TabIndex = 0;
        dgvCars.DataBindingComplete += DgvCars_DataBindingComplete;

        // CustomerCarsControl
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = AppTheme.ContentBg;
        Controls.Add(pnlCard);
        Controls.Add(lblTitle);
        DoubleBuffered = true;
        Name = "CustomerCarsControl";
        Size = new Size(1000, 620);
        Resize += CustomerCarsControl_Resize;

        pnlCard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
