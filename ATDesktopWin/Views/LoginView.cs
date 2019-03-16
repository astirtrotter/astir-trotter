using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public partial class LoginView : Form, IView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => Text;
            set => Text = value;
        }

        public Form Form => this;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtUserID.Text);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtPassword.Text);
        }
    }
}
