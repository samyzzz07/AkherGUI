namespace CarRental;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LogoutButtonHelper.AddLogoutButton(this);
    }
}
