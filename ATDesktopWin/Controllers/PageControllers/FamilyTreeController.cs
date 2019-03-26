using ATCommon.Global;
using ATDesktopWin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Controllers.PageControllers
{
    public class FamilyTreeController : _PageController
    {
        public FamilyTreeController(_Controller parent) : base(parent)
        {
            
        }

        protected override Object PageData {
            get => null;
        }

        internal override string Title => Constants.DASHBOARD;

        protected override void LoadPageData(Action actionOnSuccess)
        {
            // TODO

            actionOnSuccess();
        }

        protected new void RepresentPageData()
        {
            // TODO

            base.RepresentPageData();
        }

        protected new void ShowPage()
        {
            base.ShowPage();
            ((HomeView)viewController.View).ShowPage(HomeController.Page.FAMILY_TREE);
        }
    }
}
