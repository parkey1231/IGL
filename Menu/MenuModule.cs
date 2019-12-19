using Menu.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Menu
{
    public class MenuModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("LeftRegion", typeof(LeftMenuView));

           
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
           
        }
    }
}