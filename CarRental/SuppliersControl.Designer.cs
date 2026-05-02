using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class SuppliersControl
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTopBar;
    private Label lblTitle;
    private Button btnAddSupplier;
    private Panel pnlContent;
    private Panel pnlGrid;
    private DataGridView dgvSuppliers;
    private Panel pnlActions;
    private Button btnEdit;
    private Button btnDelete;

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
        btnAddSupplier = new Button();
        lblTitle = new Label();
        pnlContent = new Panel();
        pnlActions = new Panel();
        btnEdit = new Button();
        btnDelete = new Button();
        pnlGrid = new Panel();
        dgvSuppliers = new DataGridView();
        pnlTopBar.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlActions.SuspendLayout();
        pnlGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(15, 15, 22);
        pnlTopBar.Controls.Add(btnAddSupplier);
        pnlTopBar.Controls.Add(lblTitle);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Margin = new Padding(3, 4, 3, 4);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(1103, 73);
        pnlTopBar.TabIndex = 0;
        // 
        // btnAddSupplier
        // 
        btnAddSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddSupplier.BackColor = Color.FromArgb(0, 210, 190);
        btnAddSupplier.FlatAppearance.BorderSize = 0;
        btnAddSupplier.FlatStyle = FlatStyle.Flat;
        btnAddSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddSupplier.ForeColor = Color.FromArgb(15, 15, 22);
        btnAddSupplier.Location = new Point(955, 16);
        btnAddSupplier.Margin = new Padding(3, 4, 3, 4);
        btnAddSupplier.Name = "btnAddSupplier";
        btnAddSupplier.Size = new Size(137, 43);
        btnAddSupplier.TabIndex = 1;
        btnAddSupplier.Text = "+ Add Supplier";
        btnAddSupplier.UseVisualStyleBackColor = false;
        btnAddSupplier.Click += btnAddSupplier_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
        lblTitle.Location = new Point(21, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(125, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Suppliers";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(15, 15, 22);
        pnlContent.Controls.Add(pnlActions);
        pnlContent.Controls.Add(pnlGrid);
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
        pnlActions.BackColor = Color.FromArgb(22, 22, 32);
        pnlActions.Controls.Add(btnEdit);
        pnlActions.Controls.Add(btnDelete);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(16, 749);
        pnlActions.Margin = new Padding(3, 4, 3, 4);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(9, 11, 9, 11);
        pnlActions.Size = new Size(1071, 66);
        pnlActions.TabIndex = 1;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = Color.FromArgb(0, 210, 190);
        btnEdit.Enabled = false;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEdit.ForeColor = Color.FromArgb(15, 15, 22);
        btnEdit.Location = new Point(9, 11);
        btnEdit.Margin = new Padding(3, 4, 3, 4);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(114, 48);
        btnEdit.TabIndex = 0;
        btnEdit.Text = "✏ Edit";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(0, 210, 190);
        btnDelete.Enabled = false;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDelete.ForeColor = Color.FromArgb(15, 15, 22);
        btnDelete.Location = new Point(133, 11);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(114, 48);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "🗑 Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // pnlGrid
        // 
        pnlGrid.BackColor = Color.FromArgb(22, 22, 32);
        pnlGrid.Controls.Add(dgvSuppliers);
        pnlGrid.Dock = DockStyle.Fill;
        pnlGrid.Location = new Point(16, 19);
        pnlGrid.Margin = new Padding(3, 4, 3, 4);
        pnlGrid.Name = "pnlGrid";
        pnlGrid.Size = new Size(1071, 796);
        pnlGrid.TabIndex = 0;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.ColumnHeadersHeight = 29;
        dgvSuppliers.Dock = DockStyle.Fill;
        dgvSuppliers.Location = new Point(0, 0);
        dgvSuppliers.Margin = new Padding(3, 4, 3, 4);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(1071, 796);
        dgvSuppliers.TabIndex = 0;
        dgvSuppliers.CellClick += dgvSuppliers_CellClick;
        dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
        // 
        // SuppliersControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 247, 255);
        Controls.Add(pnlContent);
        Controls.Add(pnlTopBar);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SuppliersControl";
        Size = new Size(1103, 907);
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        pnlGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
        ResumeLayout(false);
    }
}
