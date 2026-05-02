using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

partial class CustomerHomeControl
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private FlowLayoutPanel pnlSummary;
    private Panel pnlCard1;
    private Label lblActiveRentalsTitle;
    public Label lblActiveRentalsValue;
    private Panel pnlCard2;
    private Label lblPendingPaymentsTitle;
    public Label lblPendingPaymentsValue;
    private Panel pnlCard3;
    private Label lblAvailableCarsTitle;
    public Label lblAvailableCarsValue;

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
        pnlSummary = new FlowLayoutPanel();
        pnlCard1 = new Panel();
        lblActiveRentalsTitle = new Label();
        lblActiveRentalsValue = new Label();
        pnlCard2 = new Panel();
        lblPendingPaymentsTitle = new Label();
        lblPendingPaymentsValue = new Label();
        pnlCard3 = new Panel();
        lblAvailableCarsTitle = new Label();
        lblAvailableCarsValue = new Label();

        pnlSummary.SuspendLayout();
        pnlCard1.SuspendLayout();
        pnlCard2.SuspendLayout();
        pnlCard3.SuspendLayout();
        SuspendLayout();

        // lblTitle
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = AppTheme.TextPrimary;
        lblTitle.Location = new Point(32, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(300, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Welcome!";

        // pnlSummary
        pnlSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlSummary.AutoScroll = false;
        pnlSummary.BackColor = Color.Transparent;
        pnlSummary.Controls.Add(pnlCard1);
        pnlSummary.Controls.Add(pnlCard2);
        pnlSummary.Controls.Add(pnlCard3);
        pnlSummary.FlowDirection = FlowDirection.LeftToRight;
        pnlSummary.Location = new Point(32, 90);
        pnlSummary.Name = "pnlSummary";
        pnlSummary.Size = new Size(920, 140);
        pnlSummary.TabIndex = 1;
        pnlSummary.WrapContents = false;

        // pnlCard1
        pnlCard1.BackColor = AppTheme.CardBg;
        pnlCard1.Controls.Add(lblActiveRentalsValue);
        pnlCard1.Controls.Add(lblActiveRentalsTitle);
        pnlCard1.Margin = new Padding(0, 0, 18, 0);
        pnlCard1.Name = "pnlCard1";
        pnlCard1.Size = new Size(220, 110);
        pnlCard1.TabIndex = 0;
        pnlCard1.Paint += CardPanel_Paint;

        // lblActiveRentalsTitle
        lblActiveRentalsTitle.AutoSize = true;
        lblActiveRentalsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblActiveRentalsTitle.ForeColor = AppTheme.TextMuted;
        lblActiveRentalsTitle.Location = new Point(16, 16);
        lblActiveRentalsTitle.Name = "lblActiveRentalsTitle";
        lblActiveRentalsTitle.Size = new Size(100, 19);
        lblActiveRentalsTitle.TabIndex = 0;
        lblActiveRentalsTitle.Text = "Active Rentals";

        // lblActiveRentalsValue
        lblActiveRentalsValue.AutoSize = true;
        lblActiveRentalsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblActiveRentalsValue.ForeColor = AppTheme.TextPrimary;
        lblActiveRentalsValue.Location = new Point(16, 44);
        lblActiveRentalsValue.Name = "lblActiveRentalsValue";
        lblActiveRentalsValue.Size = new Size(32, 46);
        lblActiveRentalsValue.TabIndex = 1;
        lblActiveRentalsValue.Text = "0";

        // pnlCard2
        pnlCard2.BackColor = AppTheme.CardBg;
        pnlCard2.Controls.Add(lblPendingPaymentsValue);
        pnlCard2.Controls.Add(lblPendingPaymentsTitle);
        pnlCard2.Margin = new Padding(0, 0, 18, 0);
        pnlCard2.Name = "pnlCard2";
        pnlCard2.Size = new Size(220, 110);
        pnlCard2.TabIndex = 1;
        pnlCard2.Paint += CardPanel_Paint;

        // lblPendingPaymentsTitle
        lblPendingPaymentsTitle.AutoSize = true;
        lblPendingPaymentsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblPendingPaymentsTitle.ForeColor = AppTheme.TextMuted;
        lblPendingPaymentsTitle.Location = new Point(16, 16);
        lblPendingPaymentsTitle.Name = "lblPendingPaymentsTitle";
        lblPendingPaymentsTitle.Size = new Size(120, 19);
        lblPendingPaymentsTitle.TabIndex = 0;
        lblPendingPaymentsTitle.Text = "Pending Payments";

        // lblPendingPaymentsValue
        lblPendingPaymentsValue.AutoSize = true;
        lblPendingPaymentsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblPendingPaymentsValue.ForeColor = AppTheme.TextPrimary;
        lblPendingPaymentsValue.Location = new Point(16, 44);
        lblPendingPaymentsValue.Name = "lblPendingPaymentsValue";
        lblPendingPaymentsValue.Size = new Size(32, 46);
        lblPendingPaymentsValue.TabIndex = 1;
        lblPendingPaymentsValue.Text = "0";

        // pnlCard3
        pnlCard3.BackColor = AppTheme.CardBg;
        pnlCard3.Controls.Add(lblAvailableCarsValue);
        pnlCard3.Controls.Add(lblAvailableCarsTitle);
        pnlCard3.Margin = new Padding(0, 0, 18, 0);
        pnlCard3.Name = "pnlCard3";
        pnlCard3.Size = new Size(220, 110);
        pnlCard3.TabIndex = 2;
        pnlCard3.Paint += CardPanel_Paint;

        // lblAvailableCarsTitle
        lblAvailableCarsTitle.AutoSize = true;
        lblAvailableCarsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblAvailableCarsTitle.ForeColor = AppTheme.TextMuted;
        lblAvailableCarsTitle.Location = new Point(16, 16);
        lblAvailableCarsTitle.Name = "lblAvailableCarsTitle";
        lblAvailableCarsTitle.Size = new Size(100, 19);
        lblAvailableCarsTitle.TabIndex = 0;
        lblAvailableCarsTitle.Text = "Available Cars";

        // lblAvailableCarsValue
        lblAvailableCarsValue.AutoSize = true;
        lblAvailableCarsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblAvailableCarsValue.ForeColor = AppTheme.TextPrimary;
        lblAvailableCarsValue.Location = new Point(16, 44);
        lblAvailableCarsValue.Name = "lblAvailableCarsValue";
        lblAvailableCarsValue.Size = new Size(32, 46);
        lblAvailableCarsValue.TabIndex = 1;
        lblAvailableCarsValue.Text = "0";

        // CustomerHomeControl
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = AppTheme.ContentBg;
        Controls.Add(pnlSummary);
        Controls.Add(lblTitle);
        Name = "CustomerHomeControl";
        Size = new Size(1000, 620);

        pnlSummary.ResumeLayout(false);
        pnlCard1.ResumeLayout(false);
        pnlCard1.PerformLayout();
        pnlCard2.ResumeLayout(false);
        pnlCard2.PerformLayout();
        pnlCard3.ResumeLayout(false);
        pnlCard3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
