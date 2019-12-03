using CompositeCommands;
using Prism.Commands;
using Prism.Mvvm;
using System;


namespace InfoBar.ViewModels
{
    public class InfoViewModel : BindableBase
    {
        IApplicationCommands _applicationCommands;

        private bool _batchViewButtonStatus;
        public bool BatchViewButtonStatus
        {
            get { return _batchViewButtonStatus; }
            set { SetProperty(ref _batchViewButtonStatus, value); }
        }

        private bool _GUIInfoButtonStatus;
        public bool GUIInfoButtonStatus
        {
            get { return _GUIInfoButtonStatus; }
            set { SetProperty(ref _GUIInfoButtonStatus, value); }
        }

        private bool _processButtonStatus;
        public bool ProcessButtonStatus
        {
            get { return _processButtonStatus; }
            set { SetProperty(ref _processButtonStatus, value); }
        }

        private bool _WIPButtonStatus;
        public bool WIPButtonStaus
        {
            get { return _WIPButtonStatus; }
            set { SetProperty(ref _WIPButtonStatus, value); }
        }

        private bool _infoPanelStatus = true;
        public bool InfoPanelStatus
        {
            get { return _infoPanelStatus; }
            set { SetProperty(ref _infoPanelStatus, value); }
        }

        public DelegateCommand BatchViewCommand { get; private set; }
        public DelegateCommand GUIInfoCommand { get; private set; }
        public DelegateCommand ProcessCommand { get; private set; }
        public DelegateCommand WIPCommand { get; private set; }

        public DelegateCommand HiddeCommand { get; private set; }
        public DelegateCommand ShowCommand { get; private set; }

        public InfoViewModel(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;

            HiddeCommand = new DelegateCommand(HiderInfoPanel);
            ShowCommand = new DelegateCommand(ShowinfoPanel);


            BatchViewCommand = new DelegateCommand(GoBatchView);
            GUIInfoCommand = new DelegateCommand(GoGUIInfo);
            ProcessCommand = new DelegateCommand(GoProcess);
            WIPCommand = new DelegateCommand(GoWIP);

            _applicationCommands.HiddeCompositeCommand.RegisterCommand(HiddeCommand);
            _applicationCommands.ShowCompositeCommand.RegisterCommand(ShowCommand);
        }

        private void HiderInfoPanel()
        {
            InfoPanelStatus = false;
        }

        private void ShowinfoPanel()
        {
            InfoPanelStatus = true;
        }

        private void GoGUIInfo()
        {
            if (GUIInfoButtonStatus)
                GUIInfoButtonStatus = false;

            else
            {
                InitButtonStatus();
                GUIInfoButtonStatus = true;
            }
        }

        private void GoWIP()
        {
            if (WIPButtonStaus)
                WIPButtonStaus = false;

            else
            {
                InitButtonStatus();
                WIPButtonStaus = true;
            }
        }

        private void GoProcess()
        {
            if (ProcessButtonStatus)
                ProcessButtonStatus = false;

            else
            {
                InitButtonStatus();
                ProcessButtonStatus = true;
            }
        }

        private void GoBatchView()
        {

            if (BatchViewButtonStatus)
                BatchViewButtonStatus = false;

            else
            {
                InitButtonStatus();
                BatchViewButtonStatus = true;
            }


        }

        void InitButtonStatus()
        {
            BatchViewButtonStatus = GUIInfoButtonStatus = WIPButtonStaus = ProcessButtonStatus = false;
        }
    }
}
