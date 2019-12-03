using System.Windows;

namespace IGL.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        public MainWindow()
        {
            InitializeComponent();
            this.Width =SystemParameters.PrimaryScreenWidth;//得到屏幕整体宽度
            this.Height =SystemParameters.PrimaryScreenHeight;//得到屏幕整体高度
            
        }
    }
}
