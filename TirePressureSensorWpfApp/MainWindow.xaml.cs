using System.Windows;

using MahApps.Metro.Controls;

using TirePressureSensorWpfApp.ViewModel;

namespace TirePressureSensorWpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new PlotWindow().Show();
        }
    }
}
