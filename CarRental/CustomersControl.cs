using System;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class CustomersControl : UserControl
{
    private CustomersDB db = new CustomersDB();

    public CustomersControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvCustomers);
        Load += CustomersControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }

    private void CustomersControl_Load(object sender, EventArgs e)
    {
        RefreshCustomers();
    }

    private void LoadCustomers()
    {
        dgvCustomers.DataSource = db.GetAllCustomers();
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void RefreshCustomers()
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            LoadCustomers();
            return;
        }

        dgvCustomers.DataSource = db.SearchCustomers(txtSearch.Text);
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void HandleDataChanged()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke((Action)RefreshCustomers);
            return;
        }

        RefreshCustomers();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvCustomers.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("SSN", "SSN");
        SetHeaderIfExists("CName", "Name");
        SetHeaderIfExists("Email", "Email");
        SetHeaderIfExists("PhoneNumber", "Phone");
        SetHeaderIfExists("City", "City");

        SetVisibleIfExists("Birthdate", false);
        SetVisibleIfExists("DriversLicenseNumber", false);
        SetVisibleIfExists("HouseNumber", false);
        SetVisibleIfExists("Street", false);
        SetVisibleIfExists("District", false);
    }

    private void EnsureActionColumns()
    {
        // Action buttons are now outside the grid
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvCustomers.Columns.Contains(columnName))
        {
            dgvCustomers.Columns[columnName].HeaderText = headerText;
        }
    }

    private void SetVisibleIfExists(string columnName, bool visible)
    {
        if (dgvCustomers.Columns.Contains(columnName))
        {
            dgvCustomers.Columns[columnName].Visible = visible;
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        dgvCustomers.DataSource = db.SearchCustomers(txtSearch.Text);
        ApplyGridConfiguration();
        EnsureActionColumns();
    }

    private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        var hasSelection = dgvCustomers.SelectedRows.Count > 0;
        btnEdit.Enabled = hasSelection;
        btnDelete.Enabled = hasSelection;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count == 0)
        {
            return;
        }

        var ssnValue = dgvCustomers.SelectedRows[0].Cells["SSN"].Value;
        if (ssnValue == null || !int.TryParse(ssnValue.ToString(), out var ssn))
        {
            return;
        }

        using var form = new CustomerEditForm(ssn);
        form.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.SelectedRows.Count == 0)
        {
            return;
        }

        var ssnValue = dgvCustomers.SelectedRows[0].Cells["SSN"].Value;
        if (ssnValue == null || !int.TryParse(ssnValue.ToString(), out var ssn))
        {
            return;
        }

        var result = MessageBox.Show(
            "Delete this customer?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            db.DeleteCustomer(ssn);
        }
    }

    private void btnAddCustomer_Click(object sender, EventArgs e)
    {
        using var form = new CustomerEditForm(0);
        form.ShowDialog();
    }
}
