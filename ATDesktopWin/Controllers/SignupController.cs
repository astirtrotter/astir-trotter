using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;

namespace ATDesktopWin.Controllers
{
    class SignupController : _Controller
    {
        private IView _view;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new SignupView();
                }
                return _view;
            }
        }

        public override bool Loadable() => true;

        internal void Signup(string userId, string pwd)
        {
            ClientManager.Instance.Login(userId, pwd, loginResponse => {   
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
