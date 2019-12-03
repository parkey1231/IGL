using RightMenu.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace RightMenu
{
    public class RightMenuModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("RightMenuRegion", typeof(RightMenuView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}