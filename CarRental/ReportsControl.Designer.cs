using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class ReportsControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblTitle;
    private ComboBox cmbMonth;
    private ComboBox cmbYear;
    private Button btnExport;
    private Panel pnlTabs;
    private Button btnTabRevenue;
    private Button btnTabFleet;
    private Button btnTabOverdue;
    private Button btnTabDaily;
    private Panel pnlStats;
    private Panel pnlStat1;
    private Panel pnlStat2;
    private Panel pnlStat3;
    private Label lblStat1Val;
    private Label lblStat1Label;
    private Label lblStat2Val;
    private Label lblStat2Label;
    private Label lblStat3Val;
    private Label lblStat3Label;
    private Panel pnlGrid;
    private DataGridView dgvReport;

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
        btnExport = new Button();
        cmbYear = new ComboBox();
        cmbMonth = new ComboBox();
        lblTitle = new Label();
        pnlTabs = new Panel();
        btnTabDaily = new Button();
        btnTabOverdue = new Button();
        btnTabFleet = new Button();
        btnTabRevenue = new Button();
        pnlStats = new Panel();
        pnlStat3 = new Panel();
        lblStat3Label = new Label();
        lblStat3Val = new Label();
        pnlStat2 = new Panel();
        lblStat2Label = new Label();
        lblStat2Val = new Label();
        pnlStat1 = new Panel();
        lblStat1Label = new Label();
        lblStat1Val = new Label();
        pnlGrid = new Panel();
        dgvReport = new DataGridView();
        pnlTopBar.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlStats.SuspendLayout();
        pnlStat3.SuspendLayout();
        pnlStat2.SuspendLayout();
        pnlStat1.SuspendLayout();
        pnlGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(btnExport);
        pnlTopBar.Controls.Add(cmbYear);
        pnlTopBar.Controls.Add(cmbMonth);
        pnlTopBar.Controls.Add(lblTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Margin = new Padding(3, 4, 3, 4);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 72);
        pnlTopBar.TabIndex = 0;
        // 
        // btnExport
        // 
        btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnExport.BackColor = Color.FromArgb(0, 210, 190);
        btnExport.FlatAppearance.BorderSize = 0;
        btnExport.FlatStyle = FlatStyle.Flat;
        btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnExport.ForeColor = Color.FromArgb(10, 10, 15);
        btnExport.Location = new Point(1008, 18);
        btnExport.Margin = new Padding(3, 4, 3, 4);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(79, 34);
        btnExport.TabIndex = 3;
        btnExport.Text = "Export";
        btnExport.UseVisualStyleBackColor = false;
        btnExport.Click += btnExport_Click;
        // 
        // cmbYear
        // 
        cmbYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbYear.BackColor = Color.FromArgb(22, 22, 32);
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbYear.ForeColor = Color.FromArgb(230, 230, 230);
        cmbYear.FormattingEnabled = true;
        cmbYear.Items.AddRange(new object[] { "2024", "2025", "2026" });
        cmbYear.Location = new Point(895, 22);
        cmbYear.Margin = new Padding(3, 4, 3, 4);
        cmbYear.Name = "cmbYear";
        cmbYear.Size = new Size(90, 28);
        cmbYear.TabIndex = 2;
        cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
        // 
        // cmbMonth
        // 
        cmbMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbMonth.BackColor = Color.FromArgb(22, 22, 32);
        cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMonth.ForeColor = Color.FromArgb(230, 230, 230);
        cmbMonth.FormattingEnabled = true;
        cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
        cmbMonth.Location = new Point(769, 22);
        cmbMonth.Margin = new Padding(3, 4, 3, 4);
        cmbMonth.Name = "cmbMonth";
        cmbMonth.Size = new Size(120, 28);
        cmbMonth.TabIndex = 1;
        cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(20, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(124, 40);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Reports";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = Color.FromArgb(15, 15, 22);
        pnlTabs.Controls.Add(btnTabDaily);
        pnlTabs.Controls.Add(btnTabOverdue);
        pnlTabs.Controls.Add(btnTabFleet);
        pnlTabs.Controls.Add(btnTabRevenue);
        pnlTabs.Dock = DockStyle.Top;
        pnlTabs.Location = new Point(0, 72);
        pnlTabs.Margin = new Padding(3, 4, 3, 4);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Size = new Size(1103, 46);
        pnlTabs.TabIndex = 1;
        pnlTabs.Paint += pnlTabs_Paint;
        // 
        // btnTabDaily
        // 
        btnTabDaily.BackColor = Color.FromArgb(15, 15, 22);
        btnTabDaily.FlatAppearance.BorderSize = 0;
        btnTabDaily.FlatStyle = FlatStyle.Flat;
        btnTabDaily.Font = new Font("Segoe UI", 9.5F);
        btnTabDaily.ForeColor = Color.FromArgb(130, 130, 150);
        btnTabDaily.Location = new Point(444, 4);
        btnTabDaily.Margin = new Padding(3, 4, 3, 4);
        btnTabDaily.Name = "btnTabDaily";
        btnTabDaily.Size = new Size(124, 38);
        btnTabDaily.TabIndex = 3;
        btnTabDaily.Text = "Daily Report";
        btnTabDaily.UseVisualStyleBackColor = true;
        btnTabDaily.Click += btnTabDaily_Click;
        // 
        // btnTabOverdue
        // 
        btnTabOverdue.BackColor = Color.FromArgb(15, 15, 22);
        btnTabOverdue.FlatAppearance.BorderSize = 0;
        btnTabOverdue.FlatStyle = FlatStyle.Flat;
        btnTabOverdue.Font = new Font("Segoe UI", 9.5F);
        btnTabOverdue.ForeColor = Color.FromArgb(130, 130, 150);
        btnTabOverdue.Location = new Point(324, 4);
        btnTabOverdue.Margin = new Padding(3, 4, 3, 4);
        btnTabOverdue.Name = "btnTabOverdue";
        btnTabOverdue.Size = new Size(113, 38);
        btnTabOverdue.TabIndex = 2;
        btnTabOverdue.Text = "Overdue";
        btnTabOverdue.UseVisualStyleBackColor = true;
        btnTabOverdue.Click += btnTabOverdue_Click;
        // 
        // btnTabFleet
        // 
        btnTabFleet.BackColor = Color.FromArgb(15, 15, 22);
        btnTabFleet.FlatAppearance.BorderSize = 0;
        btnTabFleet.FlatStyle = FlatStyle.Flat;
        btnTabFleet.Font = new Font("Segoe UI", 9.5F);
        btnTabFleet.ForeColor = Color.FromArgb(130, 130, 150);
        btnTabFleet.Location = new Point(170, 4);
        btnTabFleet.Margin = new Padding(3, 4, 3, 4);
        btnTabFleet.Name = "btnTabFleet";
        btnTabFleet.Size = new Size(147, 38);
        btnTabFleet.TabIndex = 1;
        btnTabFleet.Text = "Fleet Utilization";
        btnTabFleet.UseVisualStyleBackColor = true;
        btnTabFleet.Click += btnTabFleet_Click;
        // 
        // btnTabRevenue
        // 
        btnTabRevenue.BackColor = Color.FromArgb(15, 15, 22);
        btnTabRevenue.FlatAppearance.BorderSize = 0;
        btnTabRevenue.FlatStyle = FlatStyle.Flat;
        btnTabRevenue.Font = new Font("Segoe UI", 9.5F);
        btnTabRevenue.ForeColor = Color.FromArgb(130, 130, 150);
        btnTabRevenue.Location = new Point(16, 4);
        btnTabRevenue.Margin = new Padding(3, 4, 3, 4);
        btnTabRevenue.Name = "btnTabRevenue";
        btnTabRevenue.Size = new Size(147, 38);
        btnTabRevenue.TabIndex = 0;
        btnTabRevenue.Text = "Revenue by Type";
        btnTabRevenue.UseVisualStyleBackColor = true;
        btnTabRevenue.Click += btnTabRevenue_Click;
        // 
        // pnlStats
        // 
        pnlStats.BackColor = Color.FromArgb(15, 15, 22);
        pnlStats.Controls.Add(pnlStat3);
        pnlStats.Controls.Add(pnlStat2);
        pnlStats.Controls.Add(pnlStat1);
        pnlStats.Dock = DockStyle.Top;
        pnlStats.Location = new Point(0, 118);
        pnlStats.Margin = new Padding(3, 4, 3, 4);
        pnlStats.Name = "pnlStats";
        pnlStats.Padding = new Padding(16, 10, 16, 10);
        pnlStats.Size = new Size(1103, 100);
        pnlStats.TabIndex = 2;
        // 
        // pnlStat3
        // 
        pnlStat3.BackColor = Color.FromArgb(22, 22, 32);
        pnlStat3.BorderStyle = BorderStyle.FixedSingle;
        pnlStat3.Controls.Add(lblStat3Label);
        pnlStat3.Controls.Add(lblStat3Val);
        pnlStat3.Location = new Point(442, 10);
        pnlStat3.Margin = new Padding(3, 4, 3, 4);
        pnlStat3.Name = "pnlStat3";
        pnlStat3.Size = new Size(200, 78);
        pnlStat3.TabIndex = 2;
        // 
        // lblStat3Label
        // 
        lblStat3Label.AutoSize = true;
        lblStat3Label.Font = new Font("Segoe UI", 8F);
        lblStat3Label.ForeColor = Color.FromArgb(80, 80, 100);
        lblStat3Label.Location = new Point(14, 56);
        lblStat3Label.Name = "lblStat3Label";
        lblStat3Label.Size = new Size(33, 19);
        lblStat3Label.TabIndex = 1;
        lblStat3Label.Text = "Stat";
        // 
        // lblStat3Val
        // 
        lblStat3Val.AutoSize = true;
        lblStat3Val.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblStat3Val.ForeColor = Color.FromArgb(230, 230, 230);
        lblStat3Val.Location = new Point(14, 11);
        lblStat3Val.Name = "lblStat3Val";
        lblStat3Val.Size = new Size(40, 46);
        lblStat3Val.TabIndex = 0;
        lblStat3Val.Text = "0";
        // 
        // pnlStat2
        // 
        pnlStat2.BackColor = Color.FromArgb(22, 22, 32);
        pnlStat2.BorderStyle = BorderStyle.FixedSingle;
        pnlStat2.Controls.Add(lblStat2Label);
        pnlStat2.Controls.Add(lblStat2Val);
        pnlStat2.Location = new Point(229, 10);
        pnlStat2.Margin = new Padding(3, 4, 3, 4);
        pnlStat2.Name = "pnlStat2";
        pnlStat2.Size = new Size(200, 78);
        pnlStat2.TabIndex = 1;
        // 
        // lblStat2Label
        // 
        lblStat2Label.AutoSize = true;
        lblStat2Label.Font = new Font("Segoe UI", 8F);
        lblStat2Label.ForeColor = Color.FromArgb(80, 80, 100);
        lblStat2Label.Location = new Point(14, 56);
        lblStat2Label.Name = "lblStat2Label";
        lblStat2Label.Size = new Size(33, 19);
        lblStat2Label.TabIndex = 1;
        lblStat2Label.Text = "Stat";
        // 
        // lblStat2Val
        // 
        lblStat2Val.AutoSize = true;
        lblStat2Val.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblStat2Val.ForeColor = Color.FromArgb(230, 230, 230);
        lblStat2Val.Location = new Point(14, 11);
        lblStat2Val.Name = "lblStat2Val";
        lblStat2Val.Size = new Size(40, 46);
        lblStat2Val.TabIndex = 0;
        lblStat2Val.Text = "0";
        // 
        // pnlStat1
        // 
        pnlStat1.BackColor = Color.FromArgb(22, 22, 32);
        pnlStat1.BorderStyle = BorderStyle.FixedSingle;
        pnlStat1.Controls.Add(lblStat1Label);
        pnlStat1.Controls.Add(lblStat1Val);
        pnlStat1.Location = new Point(16, 10);
        pnlStat1.Margin = new Padding(3, 4, 3, 4);
        pnlStat1.Name = "pnlStat1";
        pnlStat1.Size = new Size(200, 78);
        pnlStat1.TabIndex = 0;
        // 
        // lblStat1Label
        // 
        lblStat1Label.AutoSize = true;
        lblStat1Label.Font = new Font("Segoe UI", 8F);
        lblStat1Label.ForeColor = Color.FromArgb(80, 80, 100);
        lblStat1Label.Location = new Point(14, 56);
        lblStat1Label.Name = "lblStat1Label";
        lblStat1Label.Size = new Size(33, 19);
        lblStat1Label.TabIndex = 1;
        lblStat1Label.Text = "Stat";
        // 
        // lblStat1Val
        // 
        lblStat1Val.AutoSize = true;
        lblStat1Val.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblStat1Val.ForeColor = Color.FromArgb(230, 230, 230);
        lblStat1Val.Location = new Point(14, 11);
        lblStat1Val.Name = "lblStat1Val";
        lblStat1Val.Size = new Size(40, 46);
        lblStat1Val.TabIndex = 0;
        lblStat1Val.Text = "0";
        // 
        // pnlGrid
        // 
        pnlGrid.BackColor = Color.FromArgb(15, 15, 22);
        pnlGrid.Controls.Add(dgvReport);
        pnlGrid.Dock = DockStyle.Fill;
        pnlGrid.Location = new Point(0, 218);
        pnlGrid.Margin = new Padding(3, 4, 3, 4);
        pnlGrid.Name = "pnlGrid";
        pnlGrid.Padding = new Padding(16, 4, 16, 16);
        pnlGrid.Size = new Size(1103, 689);
        pnlGrid.TabIndex = 3;
        // 
        // dgvReport
        // 
        dgvReport.ColumnHeadersHeight = 29;
        dgvReport.Dock = DockStyle.Fill;
        dgvReport.Margin = new Padding(3, 4, 3, 4);
        dgvReport.Name = "dgvReport";
        dgvReport.RowHeadersWidth = 51;
        dgvReport.RowTemplate.Height = 44;
        dgvReport.TabIndex = 0;
        // 
        // ReportsControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlGrid);
        Controls.Add(pnlStats);
        Controls.Add(pnlTabs);
        Controls.Add(pnlTopBar);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ReportsControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlStats.ResumeLayout(false);
        pnlStat3.ResumeLayout(false);
        pnlStat3.PerformLayout();
        pnlStat2.ResumeLayout(false);
        pnlStat2.PerformLayout();
        pnlStat1.ResumeLayout(false);
        pnlStat1.PerformLayout();
        pnlGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
        ResumeLayout(false);
    }
}
