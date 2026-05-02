using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class SupplierEditForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlTitle;
    private Label lblTitle;
    private Panel pnlForm;
    private TableLayoutPanel tblForm;
    private Label lblSupplierID;
    private TextBox txtSupplierID;
    private Label lblSupplierName;
    private TextBox txtSupplierName;
    private Label lblInStock;
    private NumericUpDown nudInStock;
    private FlowLayoutPanel pnlButtons;
    private Button btnCancel;
    private Button btnSave;

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
        pnlTitle = new Panel();
        lblTitle = new Label();
        pnlForm = new Panel();
        tblForm = new TableLayoutPanel();
        lblSupplierID = new Label();
        txtSupplierID = new TextBox();
        lblSupplierName = new Label();
        txtSupplierName = new TextBox();
        nudInStock = new NumericUpDown();
        lblInStock = new Label();
        pnlButtons = new FlowLayoutPanel();
        btnCancel = new Button();
        btnSave = new Button();
        pnlTitle.SuspendLayout();
        pnlForm.SuspendLayout();
        tblForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudInStock).BeginInit();
        pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTitle
        // 
        pnlTitle.Controls.Add(lblTitle);
        pnlTitle.Dock = DockStyle.Top;
        pnlTitle.Location = new Point(0, 0);
        pnlTitle.Margin = new Padding(3, 4, 3, 4);
        pnlTitle.Name = "pnlTitle";
        pnlTitle.Size = new Size(480, 67);
        pnlTitle.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.Location = new Point(18, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(148, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Add Supplier";
        // 
        // pnlForm
        // 
        pnlForm.Controls.Add(tblForm);
        pnlForm.Controls.Add(pnlButtons);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(0, 67);
        pnlForm.Margin = new Padding(3, 4, 3, 4);
        pnlForm.Name = "pnlForm";
        pnlForm.Padding = new Padding(18, 21, 18, 21);
        pnlForm.Size = new Size(480, 333);
        pnlForm.TabIndex = 1;
        // 
        // tblForm
        // 
        tblForm.ColumnCount = 2;
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
        tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
        tblForm.Controls.Add(lblSupplierID, 0, 0);
        tblForm.Controls.Add(txtSupplierID, 1, 0);
        tblForm.Controls.Add(lblSupplierName, 0, 1);
        tblForm.Controls.Add(txtSupplierName, 1, 1);
        tblForm.Controls.Add(nudInStock, 1, 2);
        tblForm.Controls.Add(lblInStock, 0, 2);
        tblForm.Dock = DockStyle.Fill;
        tblForm.Location = new Point(18, 21);
        tblForm.Margin = new Padding(3, 4, 3, 4);
        tblForm.Name = "tblForm";
        tblForm.RowCount = 3;
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
        tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
        tblForm.Size = new Size(444, 254);
        tblForm.TabIndex = 0;
        // 
        // lblSupplierID
        // 
        lblSupplierID.Dock = DockStyle.Fill;
        lblSupplierID.Font = new Font("Segoe UI", 9F);
        lblSupplierID.Location = new Point(3, 0);
        lblSupplierID.Name = "lblSupplierID";
        lblSupplierID.Padding = new Padding(0, 0, 9, 0);
        lblSupplierID.Size = new Size(162, 59);
        lblSupplierID.TabIndex = 0;
        lblSupplierID.Text = "Supplier ID";
        lblSupplierID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtSupplierID
        // 
        txtSupplierID.BorderStyle = BorderStyle.FixedSingle;
        txtSupplierID.Dock = DockStyle.Fill;
        txtSupplierID.Font = new Font("Segoe UI", 10F);
        txtSupplierID.Location = new Point(171, 12);
        txtSupplierID.Margin = new Padding(3, 12, 3, 12);
        txtSupplierID.Name = "txtSupplierID";
        txtSupplierID.Size = new Size(270, 30);
        txtSupplierID.TabIndex = 1;
        // 
        // lblSupplierName
        // 
        lblSupplierName.Dock = DockStyle.Fill;
        lblSupplierName.Font = new Font("Segoe UI", 9F);
        lblSupplierName.Location = new Point(3, 59);
        lblSupplierName.Name = "lblSupplierName";
        lblSupplierName.Padding = new Padding(0, 0, 9, 0);
        lblSupplierName.Size = new Size(162, 59);
        lblSupplierName.TabIndex = 2;
        lblSupplierName.Text = "Supplier Name";
        lblSupplierName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtSupplierName
        // 
        txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
        txtSupplierName.Dock = DockStyle.Fill;
        txtSupplierName.Font = new Font("Segoe UI", 10F);
        txtSupplierName.Location = new Point(171, 71);
        txtSupplierName.Margin = new Padding(3, 12, 3, 12);
        txtSupplierName.Name = "txtSupplierName";
        txtSupplierName.Size = new Size(270, 30);
        txtSupplierName.TabIndex = 3;
        // 
        // nudInStock
        // 
        nudInStock.Anchor = AnchorStyles.None;
        nudInStock.BorderStyle = BorderStyle.FixedSingle;
        nudInStock.Font = new Font("Segoe UI", 10F);
        nudInStock.Location = new Point(171, 171);
        nudInStock.Margin = new Padding(3, 12, 3, 12);
        nudInStock.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        nudInStock.Name = "nudInStock";
        nudInStock.Size = new Size(270, 30);
        nudInStock.TabIndex = 5;
        // 
        // lblInStock
        // 
        lblInStock.Anchor = AnchorStyles.None;
        lblInStock.Font = new Font("Segoe UI", 9F);
        lblInStock.Location = new Point(3, 165);
        lblInStock.Name = "lblInStock";
        lblInStock.Padding = new Padding(0, 0, 9, 0);
        lblInStock.Size = new Size(162, 42);
        lblInStock.TabIndex = 4;
        lblInStock.Text = "Vehicle In Stock";
        lblInStock.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlButtons
        // 
        pnlButtons.Controls.Add(btnCancel);
        pnlButtons.Controls.Add(btnSave);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.FlowDirection = FlowDirection.RightToLeft;
        pnlButtons.Location = new Point(18, 275);
        pnlButtons.Margin = new Padding(3, 4, 3, 4);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new Size(444, 37);
        pnlButtons.TabIndex = 1;
        pnlButtons.WrapContents = false;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Location = new Point(358, 0);
        btnCancel.Margin = new Padding(3, 0, 0, 0);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 35);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = SystemColors.ControlText;
        btnSave.Location = new Point(217, 0);
        btnSave.Margin = new Padding(0, 0, 9, 0);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(129, 35);
        btnSave.TabIndex = 0;
        btnSave.Text = "Save Supplier";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // SupplierEditForm
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(480, 400);
        Controls.Add(pnlForm);
        Controls.Add(pnlTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SupplierEditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Supplier";
        pnlTitle.ResumeLayout(false);
        pnlTitle.PerformLayout();
        pnlForm.ResumeLayout(false);
        tblForm.ResumeLayout(false);
        tblForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudInStock).EndInit();
        pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }
}
