using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Controllers.PageControllers
{
    public class DashboardPageController : _PageController
    {
        public DashboardPageController(_Controller parent) : base(parent)
        {
            
        }

        protected override Object PageData {
            get => null;
        }

        protected override void LoadPageData(Action actionOnSuccess)
        {
            throw new NotImplementedException();
        }

        protected override void RepresentPageData()
        {
            throw new NotImplementedException();
        }

        protected override void ShowPage()
        {
            throw new NotImplementedException();
        }
    }
}
