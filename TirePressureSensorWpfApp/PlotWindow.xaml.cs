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
using System.Windows.Shapes;

using MahApps.Metro.Controls;

using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;

namespace TirePressureSensorWpfApp
{
    /// <summary>
    /// PlotWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PlotWindow : MetroWindow
    {
        public PlotWindow()
        {
            InitializeComponent();
        }
    }
}
