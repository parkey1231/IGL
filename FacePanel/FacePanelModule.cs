using FacePanel.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FacePanel
{
    public class FacePanelModule : IModule
    {
        public int MyProperty { get; set; }


        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}