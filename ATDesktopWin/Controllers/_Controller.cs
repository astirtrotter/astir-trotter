using ATDesktopWin.Views;
using System;
using System.Windows.Forms;


namespace ATDesktopWin.Controllers
{
    public abstract class _Controller
    {
        public abstract IView View { get; }

        public void OnLoad()
        {
            AppManager.Instance.Show(this);
        }
    }
}
