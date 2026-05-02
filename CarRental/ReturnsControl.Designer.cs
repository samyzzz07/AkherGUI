using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class ReturnsControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblTitle;
    private Label lblSubtitle;
    private Panel pnlContent;
    private Panel pnlCards;
    private DataGridView dgvReturns;
    private Panel pnlActions;
    private Button btnProcess;

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
        pnlTopBar = new Panel();
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlContent = new Panel();
        pnlActions = new Panel();
        btnProcess = new Button();
        pnlCards = new Panel();
        dgvReturns = new DataGridView();
        pnlTopBar.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlActions.SuspendLayout();
        pnlCards.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReturns).BeginInit();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(lblSubtitle);
        pnlTopBar.Controls.Add(lblTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Margin = new Padding(3, 4, 3, 4);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 73);
        pnlTopBar.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(0, 210, 190);
        lblSubtitle.Location = new Point(21, 45);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(111, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Pending returns";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(21, 13);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(200, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Process Returns";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(15, 15, 22);
        pnlContent.Controls.Add(pnlActions);
        pnlContent.Controls.Add(pnlCards);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(0, 73);
        pnlContent.Margin = new Padding(3, 4, 3, 4);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(16, 19, 16, 19);
        pnlContent.Size = new Size(1103, 834);
        pnlContent.TabIndex = 1;
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.FromArgb(15, 15, 22);
        pnlActions.Controls.Add(btnProcess);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(16, 739);
        pnlActions.Margin = new Padding(3, 4, 3, 4);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(9, 11, 9, 11);
        pnlActions.Size = new Size(1071, 76);
        pnlActions.TabIndex = 1;
        // 
        // btnProcess
        // 
        btnProcess.BackColor = Color.FromArgb(0, 210, 190);
        btnProcess.Enabled = false;
        btnProcess.FlatAppearance.BorderSize = 0;
        btnProcess.FlatStyle = FlatStyle.Flat;
        btnProcess.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnProcess.ForeColor = Color.FromArgb(15, 15, 22);
        btnProcess.Location = new Point(9, 11);
        btnProcess.Margin = new Padding(3, 4, 3, 4);
        btnProcess.Name = "btnProcess";
        btnProcess.Size = new Size(171, 48);
        btnProcess.TabIndex = 0;
        btnProcess.Text = "⚙ Process Return";
        btnProcess.UseVisualStyleBackColor = false;
        btnProcess.Click += btnProcess_Click;
        // 
        // pnlCards
        // 
        pnlCards.AutoScroll = true;
        pnlCards.BackColor = Color.FromArgb(15, 15, 22);
        pnlCards.Controls.Add(dgvReturns);
        pnlCards.Dock = DockStyle.Fill;
        pnlCards.Location = new Point(16, 19);
        pnlCards.Margin = new Padding(3, 4, 3, 4);
        pnlCards.Name = "pnlCards";
        pnlCards.Size = new Size(1071, 796);
        pnlCards.TabIndex = 0;
        // 
        // dgvReturns
        // 
        dgvReturns.ColumnHeadersHeight = 29;
        dgvReturns.Dock = DockStyle.Fill;
        dgvReturns.EnableHeadersVisualStyles = false;
        dgvReturns.Location = new Point(0, 0);
        dgvReturns.Margin = new Padding(3, 4, 3, 4);
        dgvReturns.Name = "dgvReturns";
        dgvReturns.RowHeadersWidth = 51;
        dgvReturns.Size = new Size(1071, 796);
        dgvReturns.TabIndex = 0;
        dgvReturns.CellClick += dgvReturns_CellClick;
        dgvReturns.SelectionChanged += dgvReturns_SelectionChanged;
        // 
        // ReturnsControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 247, 255);
        Controls.Add(pnlContent);
        Controls.Add(pnlTopBar);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ReturnsControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        pnlCards.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvReturns).EndInit();
        ResumeLayout(false);
    }
}
