using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarRental;

public static class LogoutButtonHelper
{
    public static Button AddLogoutButton(Form form)
    {
        var button = new Button
        {
            Text = "Logout",
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            Size = new Size(96, 34),
            BackColor = AppTheme.Accent,
            ForeColor = Color.FromArgb(10, 10, 15),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            TabStop = false,
            Location = new Point(form.ClientSize.Width - 112, form.ClientSize.Height - 50)
        };

        button.FlatAppearance.BorderSize = 0;
        button.Click += (_, _) => Logout(form);

        form.Controls.Add(button);
        button.BringToFront();
        return button;
    }

    private static void Logout(Form currentForm)
    {
        var loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault() ?? new LoginForm();
        loginForm.ResetForLogout();

        if (!loginForm.Visible)
        {
            loginForm.Show();
        }

        loginForm.WindowState = FormWindowState.Normal;
        loginForm.BringToFront();
        loginForm.Activate();

        currentForm.Close();
    }
}