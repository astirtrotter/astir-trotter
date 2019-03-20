using System;
using System.Windows.Forms;
using ATDesktopWin.Controllers;

namespace ATDesktopWin.Views
{
    public partial class LoginView : Form, IView
    {
        public string Title
        {
            get => Text;
            set => Text = value;
        }

        public Form Form => this;


        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ((LoginController)AppManager.Instance._currentController).Login(txtUserID.Text, txtPassword.Text);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            ((LoginController)AppManager.Instance._currentController).Signup();
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
