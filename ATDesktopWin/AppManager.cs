using ATDesktopWin.Controllers;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ATDesktopWin
{
    public class AppManager
    {
        private static bool _started;

        private static AppManager _instance;

        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");

                return _instance;
            }
        }

        /// <summary>
        /// The current _Controller instance
        /// </summary>
        public _Controller _currentController;

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private AppManager() { }
        
        /// <summary>
        /// Loads a Controller, handles the loading state
        /// </summary>
        /// <typeparam name="T">Generic Type where T extends Controller</typeparam>
        public static void Load<T>()
            where T : _Controller
        {
            if (!_started)
            {
                _started = true;
                _instance = new AppManager();
            }

            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                controller.OnLoad();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Shows the View of the Controller parameter  
        /// </summary>
        /// <param name="controller">The controller instance</param>
        public void Show(_Controller controller)
        {
            if (_currentController != null)
            {
                _currentController.View.Form.Close();
                _currentController.View.Form.Dispose();
            }

            _currentController = controller;

            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        /// <summary>
        /// Used as single-threaded appartment thread-callback to keep the main thread running
        /// </summary>
        private void openForm()
        {
            Application.Run(_currentController.View.Form);
        }
    }
}
