using ATDesktopWin.Config;
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
    public partial class SplashView : Form, IView
    {
        private bool isTimeout = false;
        private bool hasSeed = false;

        public SplashView()
        {
            InitializeComponent();
        }

        public string Title { get => Text; set => Text = value; }

        public Form Form => this;

        private void SplashTimeout_Tick(object sender, EventArgs e)
        {
            isTimeout = true;
            checkNextStep();
        }

        private void SplashView_Shown(object sender, EventArgs e)
        {
            ((SplashController)AppManager.Instance._currentController).getSeed(() => {
                checkNextStep();
            });
        }

        private void checkNextStep()
        {
            if (!isTimeout || !Global.hasSeed) return;

            ((SplashController)AppManager.Instance._currentController).gotoLogin();
        }
    }
}
