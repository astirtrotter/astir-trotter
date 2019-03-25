using ATDesktopWin.Controllers;
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
    public partial class HomeView : Form, IView
    {
        public string Title { get => Text; set => Text = value; }

        public Form Form => this;

        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Shown(object sender, EventArgs e)
        {
            AppManager.Instance.GetCurController<HomeController>().RepresentHeaderBar();
            AppManager.Instance.GetCurController<HomeController>().SwitchToPage(HomeController.Page.DASHBOARD);
        }
    }
}
