using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Top.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {
        DispatcherTimer timer;

        public TopBar()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += ShowCurTime;

            timer.Interval = new TimeSpan(1000);

            timer.Start();
        }

        private void ShowCurTime(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            //获得年月日
            // this.tbDateText.Text = DateTime.Now.ToString("yyyy/MM/dd");   //yyyy/MM/dd
            //获得时分秒
            this.tbTimeText.Text = DateTime.Now.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
