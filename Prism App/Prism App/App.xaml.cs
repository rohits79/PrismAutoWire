using System.Windows;
using Infra;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace Prism_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs startupEventArgs)
        {
            base.OnStartup(startupEventArgs);

            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
