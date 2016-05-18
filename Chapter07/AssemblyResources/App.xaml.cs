using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;

namespace AssemblyResources
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : System.Windows.Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled " + e.Exception.GetType().ToString() + " exception was caught and ignored.");
            e.Handled = true;
        }


        private void Application_Startup(object sender, StartupEventArgs e)
        {
        
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            e.ApplicationExitCode = 1;
        }
    }
}