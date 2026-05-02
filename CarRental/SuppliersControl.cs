using System;
using System.Windows.Forms;
using CarRental.DB;

namespace CarRental;

public partial class SuppliersControl : UserControl
{
    private SuppliersDB db = new SuppliersDB();

    public SuppliersControl()
    {
        InitializeComponent();
        AppTheme.StyleDataGridView(dgvSuppliers);
        Load += SuppliersControl_Load;
        DataRefreshNotifier.DataChanged += HandleDataChanged;
        Disposed += (_, _) => DataRefreshNotifier.DataChanged -= HandleDataChanged;
    }
    

    private void SuppliersControl_Load(object sender, EventArgs e)
    {
        LoadSuppliers();
    }

    private void LoadSuppliers()
    {
        dgvSuppliers.DataSource = db.GetAllSuppliers();
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
            BeginInvoke((Action)LoadSuppliers);
            return;
        }

        LoadSuppliers();
    }

    private void ApplyGridConfiguration()
    {
        if (dgvSuppliers.Columns.Count == 0)
        {
            return;
        }

        SetHeaderIfExists("SupplierID", "ID");
        SetHeaderIfExists("SupplierName", "Name");
        SetHeaderIfExists("VehicleInStock", "In Stock");
        SetHeaderIfExists("VehiclesSupplied", "Supplied");
    }

    private void EnsureActionColumns()
    {
        // Action buttons are now outside the grid
    }

    private void SetHeaderIfExists(string columnName, string headerText)
    {
        if (dgvSuppliers.Columns.Contains(columnName))
        {
            dgvSuppliers.Columns[columnName].HeaderText = headerText;
        }
    }

    private void btnAddSupplier_Click(object sender, EventArgs e)
    {
        using var form = new SupplierEditForm(0);
        form.ShowDialog();
    }

    private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
    {
        var hasSelection = dgvSuppliers.SelectedRows.Count > 0;
        if (btnEdit != null)
        {
            btnEdit.Enabled = hasSelection;
        }

        if (btnDelete != null)
        {
            btnDelete.Enabled = hasSelection;
        }
    }

    private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        var hasSelection = dgvSuppliers.SelectedRows.Count > 0;
        if (btnEdit != null)
        {
            btnEdit.Enabled = hasSelection;
        }

        if (btnDelete != null)
        {
            btnDelete.Enabled = hasSelection;
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvSuppliers.SelectedRows.Count == 0)
        {
            return;
        }

        var supplierIdValue = dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value;
        if (supplierIdValue == null || !int.TryParse(supplierIdValue.ToString(), out var supplierId))
        {
            return;
        }

        using var form = new SupplierEditForm(supplierId);
        form.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvSuppliers.SelectedRows.Count == 0)
        {
            return;
        }

        var supplierIdValue = dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value;
        if (supplierIdValue == null || !int.TryParse(supplierIdValue.ToString(), out var supplierId))
        {
            return;
        }

        var result = MessageBox.Show(
            "Delete this supplier?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            db.DeleteSupplier(supplierId);
        }
    }
}
