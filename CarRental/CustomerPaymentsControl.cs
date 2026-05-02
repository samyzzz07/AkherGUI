using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class CustomerPaymentsControl : UserControl
{
    private readonly int ssn;
    private readonly CustomerPortalDB db = new CustomerPortalDB();

    public CustomerPaymentsControl(int ssn)
    {
        this.ssn = ssn;
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvPayments);
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
        Load += CustomerPaymentsControl_Load;
    }

    private void CustomerPaymentsControl_Load(object? sender, EventArgs e)
    {
        LoadPayments();
    }

    private void CustomerPaymentsControl_Resize(object? sender, EventArgs e)
    {
        pnlCard.Invalidate();
    }

    private void LoadPayments()
    {
        dgvPayments.DataSource = db.GetPendingPayments(ssn);
        UpdateTotalLabel();
    }

    private void btnConfirmPayment_Click(object? sender, EventArgs e)
    {
        if (dgvPayments.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a payment to confirm.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var row = dgvPayments.SelectedRows[0];
        if (row.Cells["RentalID"].Value == null)
        {
            MessageBox.Show("Selected row does not contain a RentalID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int rentalID;
        try
        {
            rentalID = Convert.ToInt32(row.Cells["RentalID"].Value);
        }
        catch
        {
            MessageBox.Show("Invalid RentalID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var res = MessageBox.Show("Confirm payment for the selected entry?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res != DialogResult.Yes)
        {
            return;
        }

        try
        {
            db.ConfirmPayment(rentalID);
            MessageBox.Show("Payment confirmed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPayments();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error confirming payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadPayments);
            return;
        }

        LoadPayments();
    }

    private void DgvPayments_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        UpdateTotalLabel();
    }

    private void UpdateTotalLabel()
    {
        var total = 0m;

        if (dgvPayments.Columns.Contains("Amount"))
        {
            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var value = row.Cells["Amount"].Value;
                if (value == null || value == DBNull.Value)
                {
                    continue;
                }

                if (decimal.TryParse(Convert.ToString(value, CultureInfo.InvariantCulture), NumberStyles.Any, CultureInfo.InvariantCulture, out var amount) ||
                    decimal.TryParse(Convert.ToString(value), NumberStyles.Any, CultureInfo.CurrentCulture, out amount))
                {
                    total += amount;
                }
            }
        }

        lblTotal.Text = $"Total Outstanding: ${total.ToString("N2", CultureInfo.InvariantCulture)}";
    }

    private void CardPanel_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var pen = new Pen(AppTheme.CardBorder);
        var rectangle = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
        e.Graphics.DrawRectangle(pen, rectangle);
    }
}