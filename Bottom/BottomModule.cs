using Bottom.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Bottom
{
    public class BottomModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("BottomRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}