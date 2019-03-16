using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATDesktopWin.Views;

namespace ATDesktopWin.Controllers
{
    class LoginController : _Controller
    {
        private IView _view;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new LoginView();
                }
                return _view;
            }
        }

        public override bool Loadable() => true;
    }
}
