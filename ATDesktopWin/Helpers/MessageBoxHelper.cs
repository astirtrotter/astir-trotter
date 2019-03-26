using ATCommon.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDesktopWin.Helpers
{
    public static class MessageBoxHelper
    {
        public static DialogResult ShowInfo(IWin32Window owner, 
            string message,
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.None)
        {
            return MessageBox.Show(owner, message, Constants.Messages.Info.Title, buttons, icon);
        }

        public static DialogResult ShowWarning(IWin32Window owner, 
            string message, 
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            return MessageBox.Show(owner, message, Constants.Messages.Warning.Title, buttons, icon);
        }

        public static DialogResult ShowError(IWin32Window owner, 
            string message, 
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            return MessageBox.Show(owner, message, Constants.Messages.Error.Title, buttons, icon);
        }
    }
}
