using CompositeCommands;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace IGL.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _rightRegionStatus;
        public bool RightRegionStatus
        {
            get { return _rightRegionStatus; }
            set { SetProperty(ref _rightRegionStatus, value); }
        }

        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        private int _spanValue = 1;
        public int Spanvalue
        {
            get { return _spanValue; }
            set { SetProperty(ref _spanValue, value); }
        }

        public DelegateCommand ShowRighRegionCommand { get; private set; }
        public DelegateCommand HiddeRighRegionCommand { get; private set; }



        public MainWindowViewModel(IApplicationCommands applicationCommands)
        {

            _applicationCommands = applicationCommands;

            ShowRighRegionCommand = new DelegateCommand(ShowRightRegion);
            HiddeRighRegionCommand = new DelegateCommand(HiddeRighRegion);


            _applicationCommands.ShowCompositeCommand.RegisterCommand(ShowRighRegionCommand);
            _applicationCommands.HiddeCompositeCommand.RegisterCommand(HiddeRighRegionCommand);

        }

        private void HiddeRighRegion()
        {
            RightRegionStatus = false;
            Spanvalue = 2;
        }

        private void ShowRightRegion()
        {
            RightRegionStatus = true;
            Spanvalue = 1;
        }
    }
}
