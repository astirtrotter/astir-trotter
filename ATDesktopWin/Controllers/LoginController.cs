using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATCommon.Global;
using ATDesktopWin.Helpers;

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

        internal void Login(string userId, string pwd)
        {
            ClientManager.Instance.Login(userId, pwd, loginResponse => {   
                if (loginResponse == null)
                {
                    MessageBoxHelper.ShowError(Constants.Messages.Error.NoResponse);
                }
                else if (loginResponse.success)
                {
                    LoginInfo.token = loginResponse.token;
                    LoginInfo.user = loginResponse.user;

                    AppManager.Load<HomeController>();
                }
                else
                {
                    MessageBoxHelper.ShowWarning(Constants.Messages.Warning.ActionFailed + loginResponse.message);
                }
            });
        }

        internal void Signup()
        {
            AppManager.Load<SignupController>();
        }
    }


}
