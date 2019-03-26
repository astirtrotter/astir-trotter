using ATDesktopWin.Controllers.PageControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public partial class HomeView : Form, _View
    {
        private FamilyTreePageController pageController { get => (FamilyTreePageController)controller.CurrentPageController; }



    }
}
