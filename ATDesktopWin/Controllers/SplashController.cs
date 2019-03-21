using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATDesktopWin.Config;

namespace ATDesktopWin.Controllers
{
    class SplashController : _Controller
    {
        private IView _view;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new SplashView();
                }
                return _view;
            }
        }

        internal void getSeed(Action callback)
        {
            ClientManager.Instance.GetSeed(seedResponse => {   
                if (seedResponse == null)
                {
                    MessageBox.Show("The response is null.");
                    Application.Exit();
                }
                else
                {
                    Global.hasSeed = true;
                    Global.genders = seedResponse.genders;
                    Global.parties = seedResponse.parties;
                    Global.nationalities = seedResponse.nationalities;
                    Global.classOrigins = seedResponse.classOrigins;
                    Global.socialOrigins = seedResponse.socialOrigins;
                    Global.nationalOrigins = seedResponse.nationalOrigins;
                    callback();
                }
            });
        }

        internal void gotoLogin()
        {
            AppManager.Load<LoginController>();
        }
    }


}
