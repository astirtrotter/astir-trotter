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
            string details, string diedDay, byte[] picture)
        {
            View.Form.Enabled = false;

            ClientManager.Instance.Signup(userId, password, firstName, lastName, nickName, gender,
                    birthday, address, birthPlace, party, nationality, nationalOrigin,
                    classOrigin, socialOrigin, phoneNumber, email, details, diedDay, picture, 
                    (data, errMsg) => {
                View.Form.BeginInvoke((MethodInvoker)delegate
                {
                    View.Form.Enabled = true;
                });

                if (errMsg != null)
                {
                    MessageBoxHelper.ShowError(View.Form, Constants.Messages.Error.ActionFailed + errMsg);
                }
                else if (data.success)
                {
                    MessageBoxHelper.ShowInfo(View.Form, Constants.Messages.Info.SignupSuccess);
                    Back();
                }
                else
                {
                    MessageBoxHelper.ShowWarning(View.Form, Constants.Messages.Warning.ActionFailed + data.message);
                }
            });
        }

        internal void Back()
        {
            AppManager.Load<LoginController>();
        }
    }


}
