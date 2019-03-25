using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Controllers.PageControllers
{
    public abstract class _PageController
    {
        protected _Controller viewController;
        
        protected abstract Object PageData { get; }

        public _PageController(_Controller parent)
        {
            viewController = parent;
        }

        /// <summary>
        /// Show page and indicate loading....
        /// </summary>
        protected abstract void ShowPage();

        /// <summary>
        /// Represent page data and stop loading indication.
        /// </summary>
        protected abstract void RepresentPageData();

        protected abstract void LoadPageData(Action actionOnSuccess);

        public void Refresh(bool force = false)
        {
            ShowPage();

            if (force || PageData == null)
            {
                LoadPageData(RepresentPageData);
            } else
            {
                RepresentPageData();
            }
        }

        internal static _PageController Create(HomeController.Page page)
        {
            HomeController parent = AppManager.Instance.GetCurController<HomeController>();
            switch (page)
            {
                case HomeController.Page.DASHBOARD:
                    return new DashboardPageController(parent);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
