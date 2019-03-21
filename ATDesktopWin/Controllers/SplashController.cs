using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATCommon.Global;

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
                    Constants.hasSeed = true;
                    Constants.genders = seedResponse.genders;
                    Constants.parties = seedResponse.parties;
                    Constants.nationalities = seedResponse.nationalities;
                    Constants.classOrigins = seedResponse.classOrigins;
                    Constants.socialOrigins = seedResponse.socialOrigins;
                    Constants.nationalOrigins = seedResponse.nationalOrigins;
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
