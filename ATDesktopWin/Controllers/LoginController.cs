using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATDesktopWin.Config;

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
                    MessageBox.Show("The response is null.");
                }
                else if (loginResponse.success)
                {
                    GlobalConstants.token = loginResponse.token;
                    GlobalConstants.user = loginResponse.user;

                    AppManager.Load<HomeController>();
                }
                else
                {
                    MessageBox.Show(loginResponse.message);
                }
            });
        }

        internal void Signup()
        {
            AppManager.Load<SignupController>();
        }
    }


}
