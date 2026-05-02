using System.Drawing;
using System.Windows.Forms;

namespace CarRental;

public static class AppTheme
{
    public static Color Sidebar => Color.FromArgb(10, 10, 15);
    public static Color SidebarText => Color.FromArgb(220, 220, 220);
    public static Color SidebarMuted => Color.FromArgb(80, 80, 100);
    public static Color SidebarActive => Color.FromArgb(0, 210, 190);
    public static Color SidebarActiveBg => Color.FromArgb(0, 40, 38);
    public static Color Accent => Color.FromArgb(0, 210, 190);
    public static Color AccentHover => Color.FromArgb(0, 160, 145);
    public static Color ContentBg => Color.FromArgb(15, 15, 22);
    public static Color CardBg => Color.FromArgb(22, 22, 32);
    public static Color CardBorder => Color.FromArgb(60, 0, 210, 190);
    public static Color TextPrimary => Color.FromArgb(230, 230, 230);
    public static Color TextSecondary => Color.FromArgb(130, 130, 150);
    public static Color TextMuted => Color.FromArgb(70, 70, 90);
    public static Color PurpleLight => Color.FromArgb(20, 20, 30);
    public static Color PurpleMid => Color.FromArgb(0, 210, 190);
    public static Color BadgeGreenBg => Color.FromArgb(0, 40, 30);
    public static Color BadgeGreenText => Color.FromArgb(0, 210, 150);
    public static Color BadgeAmberBg => Color.FromArgb(40, 30, 0);
    public static Color BadgeAmberText => Color.FromArgb(255, 180, 0);
    public static Color BadgeRedBg => Color.FromArgb(40, 10, 10);
    public static Color BadgeRedText => Color.FromArgb(255, 70, 70);
    public static Color BadgePurpleBg => Color.FromArgb(20, 20, 40);
    public static Color BadgePurpleText => Color.FromArgb(0, 210, 190);

    public static void StyleDataGridView(DataGridView dgv)
    {
        dgv.BackgroundColor = Color.FromArgb(22, 22, 32);
        dgv.BorderStyle = BorderStyle.None;
        dgv.GridColor = Color.FromArgb(30, 30, 45);
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.DefaultCellStyle.BackColor = Color.FromArgb(22, 22, 32);
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
        dgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 50, 45);
        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 210, 190);
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 28);
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 10, 15);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 210, 190);
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(10, 10, 15);
        dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 10, 15);
        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 100);
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 40, 38);
        dgv.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 210, 190);
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.ColumnHeadersHeight = 38;
        dgv.RowTemplate.Height = 40;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.RowHeadersVisible = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.ReadOnly = true;
    }

    public static void StyleActionButton(Button btn, bool enabled = true)
    {
        btn.BackColor = enabled ? Accent : Color.FromArgb(200, 200, 200);
        btn.ForeColor = Color.White;
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatStyle = FlatStyle.Flat;
        btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btn.Height = 36;
        btn.Cursor = enabled ? Cursors.Hand : Cursors.Default;
        btn.Enabled = enabled;
        btn.FlatAppearance.MouseOverBackColor = enabled ? AccentHover : Color.FromArgb(180, 180, 180);
    }
}
