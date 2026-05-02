using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerPaymentsControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Panel pnlCard;
    private DataGridView dgvPayments;
    private Panel pnlFooter;
    private Label lblTotal;
    private Button btnConfirmPayment;
    private Panel pnlActions;

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
        dgvPayments = new DataGridView();
        pnlFooter = new Panel();
        lblTotal = new Label();
        btnConfirmPayment = new Button();
        pnlActions = new Panel();
        pnlCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
        pnlFooter.SuspendLayout();
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
        lblTitle.Size = new Size(343, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Pending Payments";
        // 
        // pnlCard
        // 
        pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlCard.BackColor = Color.FromArgb(22, 22, 32);
        pnlCard.Controls.Add(dgvPayments);
        pnlCard.Controls.Add(pnlFooter);
        pnlCard.Location = new Point(32, 88);
        pnlCard.Name = "pnlCard";
        pnlCard.Padding = new Padding(1);
        pnlCard.Size = new Size(920, 460);
        pnlCard.TabIndex = 1;
        pnlCard.Paint += CardPanel_Paint;
        // 
        // dgvPayments
        // 
        dgvPayments.AllowUserToAddRows = false;
        dgvPayments.AllowUserToDeleteRows = false;
        dgvPayments.AllowUserToResizeRows = false;
        dgvPayments.BackgroundColor = Color.FromArgb(22, 22, 32);
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPayments.Dock = DockStyle.Fill;
        dgvPayments.Location = new Point(1, 1);
        dgvPayments.MultiSelect = false;
        dgvPayments.Name = "dgvPayments";
        dgvPayments.ReadOnly = true;
        dgvPayments.RowHeadersVisible = false;
        dgvPayments.RowHeadersWidth = 51;
        dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPayments.Size = new Size(918, 382);
        dgvPayments.TabIndex = 0;
        dgvPayments.DataBindingComplete += DgvPayments_DataBindingComplete;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = Color.FromArgb(22, 22, 32);
        pnlFooter.Controls.Add(lblTotal);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(1, 383);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Size = new Size(918, 76);
        pnlFooter.TabIndex = 1;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(0, 210, 190);
        lblTotal.Location = new Point(16, 18);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(246, 28);
        lblTotal.TabIndex = 0;
        lblTotal.Text = "Total Outstanding: $0.00";
        // 
        // btnConfirmPayment
        // 
        btnConfirmPayment.Anchor = AnchorStyles.None;
        btnConfirmPayment.BackColor = Color.FromArgb(0, 210, 190);
        btnConfirmPayment.FlatAppearance.BorderSize = 0;
        btnConfirmPayment.FlatStyle = FlatStyle.Flat;
        btnConfirmPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnConfirmPayment.ForeColor = Color.FromArgb(10, 10, 15);
        btnConfirmPayment.Location = new Point(-1, 0);
        btnConfirmPayment.Name = "btnConfirmPayment";
        btnConfirmPayment.Size = new Size(170, 45);
        btnConfirmPayment.TabIndex = 1;
        btnConfirmPayment.Text = "Confirm Payment";
        btnConfirmPayment.UseVisualStyleBackColor = false;
        btnConfirmPayment.Click += btnConfirmPayment_Click;
        // 
        // pnlActions
        // 
        pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        pnlActions.BackColor = Color.FromArgb(15, 15, 22);
        pnlActions.Controls.Add(btnConfirmPayment);
        pnlActions.Location = new Point(33, 562);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(170, 48);
        pnlActions.TabIndex = 2;
        // 
        // CustomerPaymentsControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlCard);
        Controls.Add(pnlActions);
        Controls.Add(lblTitle);
        DoubleBuffered = true;
        Name = "CustomerPaymentsControl";
        Size = new Size(1000, 620);
        Resize += CustomerPaymentsControl_Resize;
        pnlCard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
