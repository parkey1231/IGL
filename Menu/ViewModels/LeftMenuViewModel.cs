using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using CompositeCommands;

namespace Menu.ViewModels
{
    public class LeftMenuViewModel : BindableBase
    {
        private IRegionManager _regionManager;

        #region Home

        private Visibility _homeSubPanelStatus = Visibility.Collapsed;
        public Visibility HomeSubPanelStatus
        {
            get { return _homeSubPanelStatus; }
            set { SetProperty(ref _homeSubPanelStatus, value); }
        }

        private bool _homeButtonStatus;
        public bool HomeButtonStatus
        {
            get { return _homeButtonStatus; }
            set { SetProperty(ref _homeButtonStatus, value); }
        }

        private bool _homeMainButtonStatus;
        public bool HomeMainButtonStatus
        {
            get { return _homeMainButtonStatus; }
            set { SetProperty(ref _homeMainButtonStatus, value); }
        }

        private bool _homeInletButtonStatus;
        public bool HomeInletButtonStatus
        {
            get { return _homeInletButtonStatus; }
            set { SetProperty(ref _homeInletButtonStatus, value); }
        }

        private bool _HomeBodyButtonStatus;
        public bool HomeBodyButtonStatus
        {
            get { return _HomeBodyButtonStatus; }
            set { SetProperty(ref _HomeBodyButtonStatus, value); }
        }

        private bool _homeOutletButtonStatus;
        public bool HomeOutletButtonStatus
        {
            get { return _homeOutletButtonStatus; }
            set { SetProperty(ref _homeOutletButtonStatus, value); }
        }

        private bool _homeSprayButtonStatus;
        public bool HomeSprayButtonStatus
        {
            get { return _homeSprayButtonStatus; }
            set { SetProperty(ref _homeSprayButtonStatus, value); }
        }

        private bool _homeWIPButtonStatus;
        public bool HomeWIPButtonStatus
        {
            get { return _homeWIPButtonStatus; }
            set { SetProperty(ref _homeWIPButtonStatus, value); }
        }

        public DelegateCommand GoHomeCommand { get; private set; }

        #endregion

        #region Process

        private Visibility _processSubPanelStatus = Visibility.Collapsed;
        public Visibility ProcessSubPanelStatus
        {
            get { return _processSubPanelStatus; }
            set { SetProperty(ref _processSubPanelStatus, value); }
        }

        private bool _processBatchInfoButtonStatus;
        public bool ProcessBatchInfoButtonStatus
        {
            get { return _processBatchInfoButtonStatus; }
            set { SetProperty(ref _processBatchInfoButtonStatus, value); }
        }

        private bool _processRecipeButtonStatus;
        public bool ProcessRecipeButtonStatus
        {
            get { return _processRecipeButtonStatus; }
            set { SetProperty(ref _processRecipeButtonStatus, value); }
        }

        public DelegateCommand GoProcessCommand { get; private set; }

        public DelegateCommand ProcessStartCommand { get; private set; }

        public DelegateCommand ProcessPauseCommand { get; private set; }

        public DelegateCommand ProcessStopCommand { get; private set; }

        public DelegateCommand ProcessFillingCommand { get; private set; }

        public DelegateCommand ProcessTemperingCommand { get; private set; }

        public DelegateCommand ProcessSprayCommand { get; private set; }

        public DelegateCommand ProcessDischargeCommand { get; private set; }

        public DelegateCommand ProcessHSMFillingCommand { get; private set; }

        public DelegateCommand ProcessHSMMixingCommand { get; private set; }

        public DelegateCommand ProcessHSMSprayCommand { get; private set; }

        public DelegateCommand ProcessHSMTransferCommand { get; private set; }

        #endregion

        #region WIP

        private Visibility _WIPSubPanelStatus = Visibility.Collapsed;
        public Visibility WIPSubPanelStatus
        {
            get { return _WIPSubPanelStatus; }
            set { SetProperty(ref _WIPSubPanelStatus, value); }
        }

        private bool _WIPRecipeButtonStatus;
        public bool WIPRecipeButtonStatus
        {
            get { return _WIPRecipeButtonStatus; }
            set { SetProperty(ref _WIPRecipeButtonStatus, value); }
        }

        public DelegateCommand GoWIPCommand { get; private set; }

        public DelegateCommand WIPStartCommand { get; private set; }

        public DelegateCommand WIPStopCommand { get; private set; }

        public DelegateCommand WIPPauseCommand { get; private set; }

        #endregion

        #region Dismounting

        private bool _dismountingButtonStatus;
        public bool DismountingButtonStatus
        {
            get { return _dismountingButtonStatus; }
            set { SetProperty(ref _dismountingButtonStatus, value); }
        }


        #endregion

        #region Trend

        private bool _trendButtonStatus;
        public bool TrendButtonStatus
        {
            get { return _trendButtonStatus; }
            set { SetProperty(ref _trendButtonStatus, value); }
        }

        #endregion

        #region Alarms

        private bool _alarmsButtonStatus;
        public bool AlarmsButtonStatus
        {
            get { return _alarmsButtonStatus; }
            set { SetProperty(ref _alarmsButtonStatus, value); }
        }

        #endregion

        #region Report

        private Visibility _reportSubPanelStatus = Visibility.Collapsed;
        public Visibility ReportSubPanelStatus
        {
            get { return _reportSubPanelStatus; }
            set { SetProperty(ref _reportSubPanelStatus, value); }
        }

        private bool _reportParameterButtonStatus;
        public bool ReportParameterButtonStatus
        {
            get { return _reportParameterButtonStatus; }
            set { SetProperty(ref _reportParameterButtonStatus, value); }
        }

        private bool _reportProcessReportButtonStatus;
        public bool ReportProcessReportButtonStatus
        {
            get { return _reportProcessReportButtonStatus; }
            set { SetProperty(ref _reportProcessReportButtonStatus, value); }
        }

        private bool _reportWIPReportButtonStatus;
        public bool ReportWIPReportButtonStatus
        {
            get { return _reportWIPReportButtonStatus; }
            set { SetProperty(ref _reportWIPReportButtonStatus, value); }
        }

        private bool _reportAuditTrailButtonStatus;
        public bool ReportAuditTrailButtonStatus
        {
            get { return _reportAuditTrailButtonStatus; }
            set { SetProperty(ref _reportAuditTrailButtonStatus, value); }
        }

        private bool _reportProcessRecipeButtonStatus;
        public bool ReportProcessRecipeButtonStatus
        {
            get { return _reportProcessRecipeButtonStatus; }
            set { SetProperty(ref _reportProcessRecipeButtonStatus, value); }
        }

        private bool _reportWIPRecipeButtonStatus;
        public bool ReportWIPRecipeButtonStatus
        {
            get { return _reportWIPRecipeButtonStatus; }
            set { SetProperty(ref _reportWIPRecipeButtonStatus, value); }
        }

        public DelegateCommand GoReprotCommand { get; private set; }

        public DelegateCommand ReportParameterCommand { get; private set; }

        public DelegateCommand ReportProcessReportCommand { get; private set; }

        public DelegateCommand ReportWIPReportCommand { get; private set; }

        public DelegateCommand ReportAuditTrailCommand { get; private set; }

        public DelegateCommand ReportProcessRecipeCommand { get; private set; }

        public DelegateCommand ReportWIPRecipeCommand { get; private set; }



        #endregion

        #region Service

        private Visibility _serviceSubPanelStatus = Visibility.Collapsed;
        public Visibility ServiceSubpanelStaus
        {
            get { return _serviceSubPanelStatus; }
            set { SetProperty(ref _serviceSubPanelStatus, value); }
        }

        private bool _serviceParameterButtonStatus;
        public bool ServiceParameterButtonStatus
        {
            get { return _serviceParameterButtonStatus; }
            set { SetProperty(ref _serviceParameterButtonStatus, value); }
        }

        private bool _serviceRevisionButtonStatus;
        public bool ServiceRevisionButtonStatus
        {
            get { return _serviceRevisionButtonStatus; }
            set { SetProperty(ref _serviceRevisionButtonStatus, value); }
        }

        private bool _servicePLCButtonStatus;
        public bool ServicePLCButtonStatus
        {
            get { return _servicePLCButtonStatus; }
            set { SetProperty(ref _servicePLCButtonStatus, value); }
        }

        private bool _serviceInfoButtonStatus;
        public bool ServiceInfoButtonStatus
        {
            get { return _serviceInfoButtonStatus; }
            set { SetProperty(ref _serviceInfoButtonStatus, value); }
        }

        public DelegateCommand GoServiceCommand { get; private set; }

        #endregion

        public DelegateCommand<string> NavigateCommand { get; private set; }

        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }        

        public LeftMenuViewModel(IRegionManager regionManager, IApplicationCommands applicationCommands)
        {
            _regionManager = regionManager;

            ApplicationCommands = applicationCommands;

            NavigateCommand = new DelegateCommand<string>(Navigate);

            GoHomeCommand = new DelegateCommand(GoHome);

            GoProcessCommand = new DelegateCommand(GoProcess);

            GoWIPCommand = new DelegateCommand(GoWIp);

            GoReprotCommand = new DelegateCommand(GoReport);

            GoServiceCommand = new DelegateCommand(GoService);

            ReportParameterCommand = new DelegateCommand(ReportParmameter);

            ReportProcessReportCommand = new DelegateCommand(ReportProcess);

            ReportWIPReportCommand = new DelegateCommand(ReportWIP);

            ReportAuditTrailCommand = new DelegateCommand(ReportAuditTrail);

            ReportProcessRecipeCommand = new DelegateCommand(ReportProcessRecipe);

            ReportWIPRecipeCommand = new DelegateCommand(ReportWIPRecipe);


            _applicationCommands.HiddeCompositeCommand.RegisterCommand(NavigateCommand);
            _applicationCommands.ShowCompositeCommand.RegisterCommand(NavigateCommand);




        }

        private void ReportProcessRecipe()
        {
            InitButtonStatus();
            ReportProcessRecipeButtonStatus = true;
        }

        private void ReportWIPRecipe()
        {
            InitButtonStatus();
            ReportWIPRecipeButtonStatus = true;
        }

        private void ReportAuditTrail()
        {
            InitButtonStatus();
            ReportAuditTrailButtonStatus = true;
        }

        private void ReportWIP()
        {
            InitButtonStatus();
            ReportWIPReportButtonStatus = true;
        }

        private void ReportProcess()
        {
            InitButtonStatus();
            ReportProcessReportButtonStatus = true;
        }

        private void ReportParmameter()
        {
            InitButtonStatus();
            ReportParameterButtonStatus = true;
        }

        private void GoService()
        {
            Navigate("ServiceParameter");
            if (ServiceSubpanelStaus == Visibility.Visible)
            {

                ServiceSubpanelStaus = Visibility.Collapsed;
            }
            else if (ServiceSubpanelStaus == Visibility.Collapsed)
            {
                InitButtonStatus();
                InitSubPanelStatus();
                ServiceParameterButtonStatus = true;
                ServiceSubpanelStaus = Visibility.Visible;
            }
        }

        private void GoReport()
        {
            Navigate("ReportParameter");
            if (ReportSubPanelStatus == Visibility.Visible)
            {

                ReportSubPanelStatus = Visibility.Collapsed;
            }
            else if (ReportSubPanelStatus == Visibility.Collapsed)
            {
                InitButtonStatus();
                InitSubPanelStatus();
                ReportParameterButtonStatus = true;
                ReportSubPanelStatus = Visibility.Visible;
            }
        }

        private void GoWIp()
        {
            if (WIPSubPanelStatus == Visibility.Visible)
            {

                WIPSubPanelStatus = Visibility.Collapsed;
            }
            else if (WIPSubPanelStatus == Visibility.Collapsed)
            {
                InitButtonStatus();
                InitSubPanelStatus();
                WIPSubPanelStatus = Visibility.Visible;
            }
        }

        private void GoProcess()
        {

            if (ProcessSubPanelStatus == Visibility.Visible)
            {

                ProcessSubPanelStatus = Visibility.Collapsed;
            }
            else if (ProcessSubPanelStatus == Visibility.Collapsed)
            {
                InitButtonStatus();
                InitSubPanelStatus();
                ProcessSubPanelStatus = Visibility.Visible;
            }

        }

        private void GoHome()
        {

            Navigate("Main");
            if (HomeSubPanelStatus == Visibility.Visible)
            {

                HomeSubPanelStatus = Visibility.Collapsed;
            }
            else if (HomeSubPanelStatus == Visibility.Collapsed)
            {
                InitButtonStatus();
                InitSubPanelStatus();
                HomeMainButtonStatus = true;
                HomeSubPanelStatus = Visibility.Visible;
            }

        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("CenterRegion", navigatePath, NavigationComplete);
        }

        private void NavigationComplete(NavigationResult result)
        {

            //System.Windows.MessageBox.Show(String.Format("Navigation to {0} complete. ", result.Context.Uri));

            InitButtonStatus();

            string subPanelSelect = result.Context.Uri.ToString();

            switch (subPanelSelect)
            {
                case "Main":
                    HomeMainButtonStatus = true;
                    break;

                case "Inlet":
                    HomeInletButtonStatus = true;
                    break;

                case "Body":
                    HomeBodyButtonStatus = true;
                    break;

                case "Outlet":
                    HomeOutletButtonStatus = true;
                    break;

                case "Spray":
                    HomeSprayButtonStatus = true;
                    break;

                case "Wip":
                    HomeWIPButtonStatus = true;
                    break;

                case "BatchInfo":
                    InitButtonStatus();
                    ProcessBatchInfoButtonStatus = true;
                    break;

                case "ProcessRecipe":
                    InitButtonStatus();
                    ProcessRecipeButtonStatus = true;
                    break;

                case "WIPRecipe":
                    InitButtonStatus();
                    WIPRecipeButtonStatus = true;
                    break;

                case "Trend":
                    InitButtonStatus();
                    InitSubPanelStatus();
                    TrendButtonStatus = true;
                    break;

                case "Dismounting":
                    InitButtonStatus();
                    InitSubPanelStatus();
                    DismountingButtonStatus = true;
                    break;

                case "Alarms":
                    InitButtonStatus();
                    InitSubPanelStatus();
                    AlarmsButtonStatus = true;
                    break;

                case "ReportParameter":
                    InitButtonStatus();
                    ReportParameterButtonStatus = true;
                    break;

                case "ServiceParameter":
                    InitButtonStatus();
                    ServiceParameterButtonStatus = true;
                    break;

                case "Revision":
                    InitButtonStatus();
                    ServiceRevisionButtonStatus = true;
                    break;

                case "PLC":
                    InitButtonStatus();
                    ServicePLCButtonStatus = true;
                    break;

                case "Info":
                    InitButtonStatus();
                    ServiceInfoButtonStatus = true;
                    break;

                default:
                    break;
            }


        }

        private void InitButtonStatus()
        {

            HomeMainButtonStatus = HomeInletButtonStatus = HomeBodyButtonStatus = HomeOutletButtonStatus = HomeSprayButtonStatus = HomeWIPButtonStatus = false;

            ProcessBatchInfoButtonStatus = ProcessRecipeButtonStatus = false;

            WIPRecipeButtonStatus = false;

            TrendButtonStatus = false;

            DismountingButtonStatus = false;

            AlarmsButtonStatus = false;

            ReportParameterButtonStatus = ReportProcessReportButtonStatus = ReportWIPReportButtonStatus = ReportAuditTrailButtonStatus = ReportProcessRecipeButtonStatus = ReportWIPRecipeButtonStatus = false;

            ServiceInfoButtonStatus = ServiceParameterButtonStatus = ServicePLCButtonStatus = ServiceRevisionButtonStatus = false;

        }

        private void InitSubPanelStatus()
        {
            HomeSubPanelStatus = ProcessSubPanelStatus = WIPSubPanelStatus = ReportSubPanelStatus = ServiceSubpanelStaus = Visibility.Collapsed;
        }
    }
}
