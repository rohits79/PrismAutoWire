using System.Windows;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace Infra
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var item = Container.Resolve<Shell>();
            return item;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            //Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();

        }
    }
}
