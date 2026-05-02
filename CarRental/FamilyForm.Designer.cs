using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class FamilyForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblFamily;
    private TextBox txtFamily;
    private Label lblBrand;
    private TextBox txtBrand;
    private Button btnSave;
    private Button btnCancel;

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
        lblFamily = new Label();
        txtFamily = new TextBox();
        lblBrand = new Label();
        txtBrand = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(18, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(136, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Insert Family";
        // 
        // lblFamily
        // 
        lblFamily.AutoSize = true;
        lblFamily.Font = new Font("Segoe UI", 9F);
        lblFamily.Location = new Point(20, 68);
        lblFamily.Name = "lblFamily";
        lblFamily.Size = new Size(88, 20);
        lblFamily.TabIndex = 1;
        lblFamily.Text = "Vehicle Family";
        // 
        // txtFamily
        // 
        txtFamily.Location = new Point(20, 92);
        txtFamily.Name = "txtFamily";
        txtFamily.Size = new Size(320, 27);
        txtFamily.TabIndex = 2;
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Font = new Font("Segoe UI", 9F);
        lblBrand.Location = new Point(20, 132);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(75, 20);
        lblBrand.TabIndex = 3;
        lblBrand.Text = "Brand Name";
        // 
        // txtBrand
        // 
        txtBrand.Location = new Point(20, 156);
        txtBrand.Name = "txtBrand";
        txtBrand.Size = new Size(320, 27);
        txtBrand.TabIndex = 4;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(0, 210, 190);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Location = new Point(176, 200);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 36);
        btnSave.TabIndex = 5;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += BtnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.FromArgb(90, 90, 100);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Location = new Point(264, 200);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(80, 36);
        btnCancel.TabIndex = 6;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += BtnCancel_Click;
        // 
        // FamilyForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(364, 254);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(txtBrand);
        Controls.Add(lblBrand);
        Controls.Add(txtFamily);
        Controls.Add(lblFamily);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FamilyForm";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(false);
        PerformLayout();
    }
}