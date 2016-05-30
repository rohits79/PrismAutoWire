using System;
using System.Reflection;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace Infra
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            ViewModelLocationProvider.SetDefaultViewModelFactory(type =>
            {
                var returnType = Container.Resolve(type);
                return returnType;
            });

            var item = Container.Resolve<Shell>();
            return item;
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();

        }

        protected override void ConfigureModuleCatalog()
        {
            string path = @"E:\git\Learn Prism Boostrapper\Prism App\MainModule\bin\Debug\MainModule.dll";
            var assembly = Assembly.LoadFrom(path);
            var type = assembly.GetType("MainModule.MainModuleModule");
            ModuleCatalog.AddModule(new ModuleInfo
            {
                ModuleName = type.Name,
                ModuleType = type.AssemblyQualifiedName,
                Ref = new Uri(path, UriKind.RelativeOrAbsolute).AbsoluteUri
            });


        }
        
    }
}
