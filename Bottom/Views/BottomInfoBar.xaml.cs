using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Threading;
using System;

namespace Bottom.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class BottomInfoBar : UserControl
    {
        DispatcherTimer _timer;
        PerformanceCounter _cpuCounter;
        PerformanceCounter _ramCounter;

        public BottomInfoBar()
        {
            InitializeComponent();
            _cpuCounter = new PerformanceCounter();
            _cpuCounter.CategoryName = "Processor";
            _cpuCounter.CounterName = "% Processor Time";
            _cpuCounter.InstanceName = "_Total";
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            CPUCounterText.Text = "RAM: " + (_ramCounter.NextValue() / 1024).ToString("0.0") + "    " + "CPU: " + _cpuCounter.NextValue().ToString("0.0");
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(2000);
            _timer.Tick += Timer_Tick;
            //_timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);

            //CPUCounterText.Text = "RAM: " + (_ramCounter.NextValue() / 1024).ToString("0.0") + "    " + "CPU: " + _cpuCounter.NextValue().ToString("0.0");
        }
    }
}
