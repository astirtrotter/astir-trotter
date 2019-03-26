using ATDesktopWin.Views;
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

        internal abstract string Title { get;  }
        
        protected abstract Object PageData { get; }

        public _PageController(_Controller parent)
        {
            viewController = parent;
        }

        /// <summary>
        /// Show page in tab control and indicate loading....
        /// </summary>
        protected void ShowPage()
        {
            ((HomeView)viewController.View).StartLoading();
        }

        /// <summary>
        /// Represent page data and stop loading indication.
        /// </summary>
        protected void RepresentPageData()
        {
            ((HomeView)viewController.View).EndLoading();
        }

        /// <summary>
        /// Fetch data from server and perform actionOnSuccess.
        /// </summary>
        /// <param name="actionOnSuccess"></param>
        protected abstract void LoadPageData(Action actionOnSuccess);

        /// <summary>
        /// Refresh entire screen (header bar + current page).
        /// </summary>
        /// <param name="force">if true, LoadPageData is called.</param>
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
