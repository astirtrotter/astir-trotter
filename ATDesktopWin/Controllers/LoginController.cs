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
            ClientManager.Instance.Login(userId, pwd, (data, errMsg) => {
                if (data == null)
                {
                    MessageBoxHelper.ShowError(Constants.Messages.Error.ActionFailed + errMsg);
                }
                else if (data.success)
                {
                    LoginInfo.token = data.token;
                    LoginInfo.user = data.user;

                    AppManager.Load<HomeController>();
                }
                else
                {
                    MessageBoxHelper.ShowWarning(Constants.Messages.Warning.ActionFailed + data.message);
                }
            });
        }

        internal void Signup()
        {
            AppManager.Load<SignupController>();
        }
    }


}
