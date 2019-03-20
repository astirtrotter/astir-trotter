using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATDesktopWin.Config;

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
       

        internal void Signup(
            string userId, string password, string firstName, string lastName,
            string nickName, string gender, string birthday, string address, 
            string birthPlace, string party, string nationality, string nationalOrigin, 
            string classOrigin, string socialOrigin, string phoneNumber, string email,
            string moreContactInfo)
        {
            ClientManager.Instance.Signup(userId, password, firstName, lastName, nickName, gender,
                    birthday, address, birthPlace, party, nationality, nationalOrigin,
                    classOrigin, socialOrigin, phoneNumber, email, moreContactInfo, signupResponse => {
                if (signupResponse == null)
                {
                    MessageBox.Show("The response is null.");
                }
                else if (signupResponse.success)
                {
                    MessageBox.Show("You have successfully signed up. Please log in with that credentials.");
                    Back();
                }
                else
                {
                    MessageBox.Show(signupResponse.message);
                }
            });
        }

        internal void Back()
        {
            AppManager.Load<LoginController>();
        }
    }


}
