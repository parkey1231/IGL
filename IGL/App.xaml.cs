using CompositeCommands;
using IGL.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;


namespace IGL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    moduleCatalog.AddModule<Bottom.BottomModule>();
        //    moduleCatalog.AddModule<Center.CenterModule>();
        //    moduleCatalog.AddModule<InfoBar.InfoBarModule>();
        //    moduleCatalog.AddModule<Menu.MenuModule>();
        //    moduleCatalog.AddModule<RightMenu.RightMenuModule>();
        //    moduleCatalog.AddModule<Top.TopModule>();
        //}


    }
}
