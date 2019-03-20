using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;

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

        internal void Login(string userId, string pwd)
        {
            ClientManager.Instance.login(userId, pwd, loginResponse => {   
                if (loginResponse == null)
                {
                    MessageBox.Show("The response is null.");
                }
                else if (loginResponse.success)
                {
                    MessageBox.Show(loginResponse.token + "\n" +
                                Newtonsoft.Json.JsonConvert.SerializeObject(loginResponse.user)); 
                }
                else
                {
                    MessageBox.Show(loginResponse.message);
                }
            });
        }

        internal void signup()
        {
            throw new NotImplementedException();
        }
    }


}
