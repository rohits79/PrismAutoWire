using MainModule.ViewModels;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace MainModule
{
    public class MainModuleModule : IModule
    {
        private readonly IUnityContainer _unityContainer;
        private readonly IRegionManager _regionManager;

        public MainModuleModule(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            _unityContainer = unityContainer;
            _regionManager = regionManager;

            _unityContainer.RegisterType<ToolbarWindowViewModel>();
          
        }

        public void Initialize()
        {
            _regionManager.Regions["Toolbar"].Add(_unityContainer.Resolve<ToolbarWindow>());
        }
    }
}
