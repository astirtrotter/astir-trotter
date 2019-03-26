using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public interface _View
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
