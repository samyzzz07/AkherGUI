using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomersControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblTitle;
    private Button btnAddCustomer;
    private Panel pnlSearch;
    private TextBox txtSearch;
    private Button btnSearch;
    private Panel pnlContent;
    private Panel pnlGrid;
    private DataGridView dgvCustomers;
    private Button btnEdit;
    private Button btnDelete;
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
        pnlTopBar = new Panel();
        btnAddCustomer = new Button();
        lblTitle = new Label();
        pnlSearch = new Panel();
        btnSearch = new Button();
        txtSearch = new TextBox();
        pnlContent = new Panel();
        pnlGrid = new Panel();
        dgvCustomers = new DataGridView();
        pnlActions = new Panel();
        btnDelete = new Button();
        btnEdit = new Button();
        pnlTopBar.SuspendLayout();
        pnlSearch.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(btnAddCustomer);
        pnlTopBar.Controls.Add(lblTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 80);
        pnlTopBar.TabIndex = 0;
        // 
        // btnAddCustomer
        // 
        btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddCustomer.BackColor = Color.FromArgb(0, 210, 190);
        btnAddCustomer.FlatAppearance.BorderSize = 0;
        btnAddCustomer.FlatStyle = FlatStyle.Flat;
        btnAddCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddCustomer.ForeColor = Color.FromArgb(15, 15, 22);
        btnAddCustomer.Location = new Point(919, 20);
        btnAddCustomer.Name = "btnAddCustomer";
        btnAddCustomer.Size = new Size(160, 40);
        btnAddCustomer.TabIndex = 1;
        btnAddCustomer.Text = "+ New Customer";
        btnAddCustomer.UseVisualStyleBackColor = false;
        btnAddCustomer.Click += btnAddCustomer_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(28, 22);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(166, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Customers";
        // 
        // pnlSearch
        // 
        pnlSearch.BackColor = Color.FromArgb(12, 12, 18);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Dock = DockStyle.Top;
        pnlSearch.Location = new Point(0, 80);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Padding = new Padding(24, 14, 24, 14);
        pnlSearch.Size = new Size(1103, 60);
        pnlSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.FromArgb(0, 210, 190);
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSearch.ForeColor = Color.FromArgb(15, 15, 22);
        btnSearch.Location = new Point(340, 14);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(100, 32);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtSearch
        // 
        txtSearch.BackColor = Color.FromArgb(22, 22, 32);
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.ForeColor = Color.FromArgb(220, 220, 220);
        txtSearch.Location = new Point(24, 14);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search name, email, SSN...";
        txtSearch.Size = new Size(300, 27);
        txtSearch.TabIndex = 0;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(15, 15, 22);
        pnlContent.Controls.Add(pnlGrid);
        pnlContent.Controls.Add(pnlActions);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(0, 140);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(24, 16, 24, 20);
        pnlContent.Size = new Size(1103, 767);
        pnlContent.TabIndex = 2;
        // 
        // pnlGrid
        // 
        pnlGrid.BackColor = Color.FromArgb(22, 22, 32);
        pnlGrid.Controls.Add(dgvCustomers);
        pnlGrid.Dock = DockStyle.Fill;
        pnlGrid.Location = new Point(24, 16);
        pnlGrid.Name = "pnlGrid";
        pnlGrid.Size = new Size(1055, 671);
        pnlGrid.TabIndex = 0;
        // 
        // dgvCustomers
        // 
        dgvCustomers.BorderStyle = BorderStyle.None;
        dgvCustomers.ColumnHeadersHeight = 38;
        dgvCustomers.EnableHeadersVisualStyles = false;
        dgvCustomers.Location = new Point(0, 0);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.RowHeadersVisible = false;
        dgvCustomers.RowHeadersWidth = 51;
        dgvCustomers.RowTemplate.Height = 40;
        dgvCustomers.Size = new Size(1076, 647);
        dgvCustomers.TabIndex = 0;
        dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.FromArgb(22, 22, 32);
        pnlActions.Controls.Add(btnDelete);
        pnlActions.Controls.Add(btnEdit);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(24, 687);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(12, 10, 12, 10);
        pnlActions.Size = new Size(1055, 60);
        pnlActions.TabIndex = 1;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(0, 210, 190);
        btnDelete.Enabled = false;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDelete.ForeColor = Color.FromArgb(10, 10, 15);
        btnDelete.Location = new Point(128, 10);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(110, 40);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "🗑 Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = Color.FromArgb(0, 210, 190);
        btnEdit.Enabled = false;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEdit.ForeColor = Color.FromArgb(10, 10, 15);
        btnEdit.Location = new Point(12, 10);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(110, 40);
        btnEdit.TabIndex = 0;
        btnEdit.Text = "✏ Edit";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // CustomersControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 22);
        Controls.Add(pnlContent);
        Controls.Add(pnlSearch);
        Controls.Add(pnlTopBar);
        Name = "CustomersControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
    }
}
