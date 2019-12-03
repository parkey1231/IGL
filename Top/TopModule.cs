using Top.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Top
{
    public class TopModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("TopRegion", typeof(TopBar));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}