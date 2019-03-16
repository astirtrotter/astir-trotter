using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public interface IView
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
