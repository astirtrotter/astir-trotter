using ATCommon.Global;
using ATDesktopWin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Controllers.PageControllers
{
    public class FamilyTreePageController : _PageController
    {
        public FamilyTreePageController(_Controller parent) : base(parent)
        {
            
        }

        protected override Object PageData {
            get => null;
        }

        internal override string Title => Constants.FAMILY_TREE;

        protected override void LoadPageData(Action actionOnSuccess)
        {
            // TODO

            actionOnSuccess();
        }

        protected override void RepresentPageData()
        {
            // TODO

            base.RepresentPageData();
        }

        protected override void ShowPage()
        {
            base.ShowPage();
            ((HomeView)viewController.View).ShowPage(HomeController.Page.FAMILY_TREE);
        }
    }
}
