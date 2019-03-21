using ATDesktopWin.Views;
using System;
using System.Windows.Forms;


namespace ATDesktopWin.Controllers
{
    public abstract class _Controller
    {
        public abstract IView View { get; }

        public _Controller()
        {
        }

        protected virtual void OnLoadSucceededHandler(Object sender, EventArgs e)
        {
            AppManager.Instance.Show(this);
        }

        protected virtual void OnLoadFailedHandler(Object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void OnLoad()
        {
            AppManager.Instance.Show(this);
        }
    }
}
