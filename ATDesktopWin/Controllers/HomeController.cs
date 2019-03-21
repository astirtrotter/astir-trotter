using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;

namespace ATDesktopWin.Controllers
{
    class HomeController : _Controller
    {
        private IView _view;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new HomeView();
                }
                return _view;
            }
        }


    }


}
