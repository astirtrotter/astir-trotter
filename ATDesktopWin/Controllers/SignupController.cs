using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using ATDesktopWin.Helpers;
using ATCommon.Global;

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


        internal void Signup(
            string userId, string password, string firstName, string lastName,
            string nickName, string gender, string birthday, string address, 
            string birthPlace, string party, string nationality, string nationalOrigin, 
            string classOrigin, string socialOrigin, string phoneNumber, string email,
            string details, string diedDay)
        {
            ClientManager.Instance.Signup(userId, password, firstName, lastName, nickName, gender,
                    birthday, address, birthPlace, party, nationality, nationalOrigin,
                    classOrigin, socialOrigin, phoneNumber, email, details, diedDay, signupResponse => {
                if (signupResponse == null)
                {
                    MessageBoxHelper.ShowError(Constants.Messages.Error.NoResponse);
                }
                else if (signupResponse.success)
                {
                    MessageBoxHelper.ShowInfo(Constants.Messages.Info.SignupSuccess);
                    Back();
                }
                else
                {
                    MessageBoxHelper.ShowWarning(Constants.Messages.Warning.ActionFailed + signupResponse.message);
                }
            });
        }

        internal void Back()
        {
            AppManager.Load<LoginController>();
        }
    }


}
