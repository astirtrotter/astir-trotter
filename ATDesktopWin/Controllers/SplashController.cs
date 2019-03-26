using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATCommon.Global;
using ATDesktopWin.Helpers;

namespace ATDesktopWin.Controllers
{
    class SplashController : _Controller
    {
        private _View _view;
        public override _View View
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
            ClientManager.Instance.GetSeed((data, errMsg) => {
                View.Form.BeginInvoke((MethodInvoker)delegate
                {
                    if (errMsg != null || !data.success)
                    {
                        MessageBoxHelper.ShowError(View.Form, Constants.Messages.Error.ActionFailed + errMsg);
                        Application.Exit();
                    }
                    else
                    {
                        Constants.hasSeed = true;
                        Constants.genders = data.genders;
                        Constants.parties = data.parties;
                        Constants.nationalities = data.nationalities;
                        Constants.classOrigins = data.classOrigins;
                        Constants.socialOrigins = data.socialOrigins;
                        Constants.nationalOrigins = data.nationalOrigins;
                        Constants.relationships = data.relationships;
                        callback();
                    }
                });
            });
        }

        internal void gotoLogin()
        {
            AppManager.Load<LoginController>();
        }
    }


}
