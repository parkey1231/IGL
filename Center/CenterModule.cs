using Center.Views;
using Center.Views.Home;
using Center.Views.Process;
using Center.Views.WIP;
using Center.Views.Dismounting;
using Center.Views.Trend;
using Center.Views.Alarms;
using Center.Views.Report;
using Center.Views.Service;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Center
{
    public class CenterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //Home
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Main));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Inlet));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Body));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Outlet));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Spray));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Wip));
            //Process
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(BatchInfo));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(ProcessRecipe));
            //WIP
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(WIPRecipe));
            //Dismounting
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Dismounting));
            //Trend
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Trend));
            //Alarms
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Alarms));
            //Report
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(ReportParameter));
            //Service
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(ServiceParameter));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Revision));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(PLC));
            regionManager.RegisterViewWithRegion("CenterRegion", typeof(Info));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}