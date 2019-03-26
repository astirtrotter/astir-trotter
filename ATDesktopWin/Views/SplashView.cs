using ATCommon.Global;
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
    public partial class SplashView : Form, _View
    {
        Timer timer = new Timer();

        public SplashView()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(SplashTimeout_Tick);
            timer.Interval = 2000;
            timer.Enabled = true;
            timer.Start();
        }

        public string Title { get => Text; set => Text = value; }

        public Form Form => this;

        private void SplashTimeout_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();

            if (Constants.hasSeed)
            {
                Next();
            }
        }

        private void SplashView_Shown(object sender, EventArgs e)
        {
            AppManager.Instance.GetCurController<SplashController>().getSeed(() => {
                if (!timer.Enabled)
                {
                    Next();
                }
            });
        }

        private void Next()
        {
            AppManager.Instance.GetCurController<SplashController>().gotoLogin();
        }
    }
}
