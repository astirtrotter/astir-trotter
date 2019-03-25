using ATCommon.Global;
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

        internal override string Title => Constants.DASHBOARD;

        protected override void LoadPageData(Action actionOnSuccess)
        {
            actionOnSuccess();
        }

        protected override void RepresentPageData()
        {
            
        }

        protected override void ShowPage()
        {
            
        }
    }
}
