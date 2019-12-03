using InfoBar.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace InfoBar
{
    public class InfoBarModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion("RightRegion", typeof(Info));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}