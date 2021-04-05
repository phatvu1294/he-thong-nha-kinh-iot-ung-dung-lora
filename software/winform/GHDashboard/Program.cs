using System;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace GHDashboard
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{5F715D00-F665-4247-8F36-EE1D2F136F0F}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                #region SplashScreen
                new SplashScreenUsingVBFramework().Run(args);
                #endregion
                mutex.ReleaseMutex();
            }
        }
    }

    #region SplashScreen
    class SplashScreenUsingVBFramework : WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            base.OnCreateSplashScreen();
            this.SplashScreen = new GHDashboard.frmSplash();
        }
        protected override void OnCreateMainForm()
        {
            base.OnCreateMainForm();
            this.MainForm = new frmMain();
        }
    }
    #endregion
}
