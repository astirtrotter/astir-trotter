using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ATCommon.Global;
using ATDesktopWin.Controllers;
using ATDesktopWin.Helpers;

namespace ATDesktopWin.Views
{
    public partial class LoginView : Form, IView
    {
        public string Title { get => Text; set => Text = value; }

        public Form Form => this;


        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserID.Text,
                password = txtPassword.Text;
            List<string> invalidFields = new List<string>();
            if (userId.Length == 0) invalidFields.Add("User Id");
            if (password.Length == 0) invalidFields.Add("Password");

            if (invalidFields.Count > 0)
            {
                MessageBoxHelper.ShowWarning(Constants.Messages.Warning.InvalidInput + String.Join("\n", invalidFields));
            } else
            {
                AppManager.Instance.GetCurController<LoginController>().Login(userId, password);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            AppManager.Instance.GetCurController<LoginController>().Signup();
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
