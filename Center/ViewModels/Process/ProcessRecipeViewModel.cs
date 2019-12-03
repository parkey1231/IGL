using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Center.ViewModels.Process
{
    public class ProcessRecipeViewModel : BindableBase
    {
        IRegionManager _regionManager;


        public DelegateCommand NewProcessRecipeCommand { get; private set; }
        public DelegateCommand<string> NavigateCommand { get; private set; }


        public ProcessRecipeViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NewProcessRecipeCommand = new DelegateCommand(NewProcess);
            NavigateCommand = new DelegateCommand<string>(Navigate);

        }


        private void NewProcess()
        {

        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("CenterRegion", navigatePath, NavigationComplete);
        }

        private void NavigationComplete(NavigationResult result)
        { 

        }
    }
}
