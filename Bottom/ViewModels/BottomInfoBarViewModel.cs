using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bottom.ViewModels
{
    public class BottomInfoBarViewModel : BindableBase
    {
        public DelegateCommand ShutdownCommand { get; set; }

        public BottomInfoBarViewModel()
        {
            ShutdownCommand = new DelegateCommand(ShutdownApp);
        }

        private void ShutdownApp()
        {
            Application.Current.Shutdown();
        }
    }
}
