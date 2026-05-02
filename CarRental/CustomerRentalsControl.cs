using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CarRental.DB;
using Microsoft.Data.SqlClient;

namespace CarRental;

public partial class CustomerRentalsControl : UserControl
{
    private readonly int ssn;
    private readonly CustomerPortalDB db = new CustomerPortalDB();

    public CustomerRentalsControl(int ssn)
    {
        this.ssn = ssn;
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvRentals);
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;

        dgvRentals.DataBindingComplete += DgvRentals_DataBindingComplete;
        dgvRentals.CellClick += DgvRentals_CellClick;
        dgvRentals.CellFormatting += DgvRentals_CellFormatting;

        Load += CustomerRentalsControl_Load;
        Resize += CustomerRentalsControl_Resize;
    }

    private void CustomerRentalsControl_Load(object? sender, EventArgs e)
    {
        LoadRentals();
    }

    private void CustomerRentalsControl_Resize(object? sender, EventArgs e)
    {
        pnlCard.Invalidate();
    }

    private void LoadRentals()
    {
        dgvRentals.DataSource = db.GetCustomerRentals(ssn);
        ApplyGridConfiguration();
        ApplyRowColors();
        AddCancelButtonColumn();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)LoadRentals);
            return;
        }

        LoadRentals();
    }

    private void AddCancelButtonColumn()
    {
        if (dgvRentals.Columns["colCancel"] == null)
        {
            var colCancel = new DataGridViewButtonColumn
            {
                Name = "colCancel",
                HeaderText = "",
                Text = "Cancel",
                UseColumnTextForButtonValue = true,
                Width = 80,
                FlatStyle = FlatStyle.Flat
            };
            dgvRentals.Columns.Add(colCancel);
        }
    }

    private void DgvRentals_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        ApplyGridConfiguration();
        ApplyRowColors();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvRentals.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("RentalID", "ID");
        SetHeaderIfExists("VehicleModel", "Vehicle");
        SetHeaderIfExists("StartDate", "Start");
        SetHeaderIfExists("EndDate", "Return");
        SetHeaderIfExists("Status_", "Status");

        foreach (DataGridViewColumn column in dgvRentals.Columns)
        {
            if (column.Name is "RentalID" or "VehicleModel" or "StartDate" or "EndDate" or "Status_")
            {
                continue;
            }

            column.Visible = false;
        }
    }

    private void ApplyRowColors()
    {
        if (dgvRentals.Rows.Count == 0 || !dgvRentals.Columns.Contains("Status_"))
        {
            return;
        }

        foreach (DataGridViewRow row in dgvRentals.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            var status = row.Cells["Status_"].Value?.ToString();
            var color = status switch
            {
                "Active" => AppTheme.BadgeGreenText,
                "Overdue" => AppTheme.BadgeRedText,
                _ => AppTheme.BadgeAmberText
            };

            row.DefaultCellStyle.ForeColor = color;
            row.DefaultCellStyle.SelectionForeColor = color;
        }
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvRentals.Columns.Contains(columnName))
        {
            dgvRentals.Columns[columnName].HeaderText = headerText;
        }
    }

    private void CardPanel_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var pen = new Pen(AppTheme.CardBorder);
        var rectangle = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
        e.Graphics.DrawRectangle(pen, rectangle);
    }

    private void DgvRentals_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
        {
            return;
        }

        var column = dgvRentals.Columns[e.ColumnIndex];
        if (column.Name == "colCancel")
        {
            if (dgvRentals.Rows[e.RowIndex].Cells["RentalID"].Value is not int rentalID)
            {
                return;
            }

            var result = MessageBox.Show(
                "Cancel this rental?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CancelRental(rentalID);
            }
            return;
        }

    }

        private void BtnDeleteRental_Click(object? sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rental to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvRentals.SelectedRows[0];
            //if (!row.Cells.Contains("RentalID"))
            //{
            //    MessageBox.Show("Selected row does not contain a RentalID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (!int.TryParse(row.Cells["RentalID"].Value?.ToString(), out var rentalID))
            {
                MessageBox.Show("Invalid RentalID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected rental?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var db = new CustomerPortalDB();
                db.DeleteRental(rentalID);
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private void DgvRentals_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.ColumnIndex < 0 || e.RowIndex < 0)
        {
            return;
        }

        var column = dgvRentals.Columns[e.ColumnIndex];
        if (column.Name == "colCancel")
        {
            var status = dgvRentals.Rows[e.RowIndex].Cells["Status_"].Value?.ToString();
            if (status != "Active")
            {
                e.Value = string.Empty;
            }
        }
    }

    private void CancelRental(int rentalID)
    {
        try
        {
            using var conn = new SqlConnection(DBHelper.ConnStr);
            using var cmd = new SqlCommand("CancelRental", conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@RentalID", rentalID);
            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show(
                "Rental cancelled.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadRentals();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Error cancelling rental: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}