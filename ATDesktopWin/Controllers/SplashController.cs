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
                    GlobalConstants.hasSeed = true;
                    GlobalConstants.genders = seedResponse.genders;
                    GlobalConstants.parties = seedResponse.parties;
                    GlobalConstants.nationalities = seedResponse.nationalities;
                    GlobalConstants.classOrigins = seedResponse.classOrigins;
                    GlobalConstants.socialOrigins = seedResponse.socialOrigins;
                    GlobalConstants.nationalOrigins = seedResponse.nationalOrigins;
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
