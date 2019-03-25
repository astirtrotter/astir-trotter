using System;
using ATDesktopWin.Views;
using ATCommon.API;
using System.Windows.Forms;
using System.Collections.Generic;
using ATDesktopWin.Controllers.PageControllers;

namespace ATDesktopWin.Controllers
{
    class HomeController : _Controller
    {
        private IView _view;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new HomeView();
                }
                return _view;
            }
        }

        internal enum Page { DASHBOARD, FAMILY_TREE, FAMILY_TABLE };
        private Page currentPage;
        private Dictionary<Page, _PageController> pageControllers;

        internal _PageController CurrentPageController
        {
            get
            {
                if (pageControllers == null)
                {
                    pageControllers = new Dictionary<Page, _PageController>();
                }
                _PageController ret = pageControllers[currentPage];
                if (ret == null)
                {
                    ret = _PageController.Create(currentPage);
                }

                return ret;
            }
        }

        private void RefreshHeaderBar()
        {

        }

        internal void Refresh()
        {
            RefreshHeaderBar();
            CurrentPageController.Refresh(true);
        }

        internal void SwitchToPage(Page page)
        {
            currentPage = page;
            CurrentPageController.Refresh();
        }


    }


}
