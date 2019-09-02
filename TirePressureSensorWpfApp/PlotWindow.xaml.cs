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
using System.Windows.Threading;
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

        private double i = 0;
        private DispatcherTimer timer = new DispatcherTimer();

        public ObservableDataSource<Point> TemDataSource { get; set; }
            = new ObservableDataSource<Point>();

        public ObservableDataSource<Point> PreDataSource { get; set; }
            = new ObservableDataSource<Point>();

        public ObservableDataSource<Point> FreDataSource { get; set; }
            = new ObservableDataSource<Point>();

        public ObservableDataSource<Point> AmpDataSource { get; set; }
            = new ObservableDataSource<Point>();


        public bool IsAutoFit { get; set; } = true;

        public int AutoFitCount { get; set; } = 200;

        public double PlotTimerInterval { get; set; } = 0.05;

        public int LineWidth { get; set; } = 2;

        public PlotWindow()
        {
            InitializeComponent();
        }

        private void AnimatedPlot(object sender, EventArgs e)
        {
            TemDataSource.AppendAsync(base.Dispatcher, new Point(i, tem));
            PreDataSource.AppendAsync(base.Dispatcher, new Point(i, pre));
            FreDataSource.AppendAsync(base.Dispatcher, new Point(i, fre));
            AmpDataSource.AppendAsync(base.Dispatcher, new Point(i, amp));
            var count = TemDataSource.Collection.Count;
            i += PlotTimerInterval;
            if (count >= AutoFitCount && IsAutoFit == true)
            {
                TemDataSource.Collection.RemoveAt(0);
                PreDataSource.Collection.RemoveAt(0);
                FreDataSource.Collection.RemoveAt(0);
                AmpDataSource.Collection.RemoveAt(0);
                FitToView();
            }

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //templotter.AddLineGraph(TemDataSource, Colors.BlueViolet, LineWidth);
            //preplotter.AddLineGraph(PreDataSource, Colors.BlueViolet, LineWidth);
            //freplotter.AddLineGraph(FreDataSource, Colors.BlueViolet, LineWidth);
            //ampplotter.AddLineGraph(AmpDataSource, Colors.BlueViolet, LineWidth);
            timer.Interval = TimeSpan.FromSeconds(PlotTimerInterval);
            timer.Tick += new EventHandler(AnimatedPlot);
            timer.IsEnabled = true;
            FitToView();
        }

        public void FitToView()
        {
            templotter.Viewport.FitToView();
            preplotter.Viewport.FitToView();
            freplotter.Viewport.FitToView();
            ampplotter.Viewport.FitToView();
        }

        private double tem;
        private double pre;
        private double fre;
        private double amp;

        public void AppendPlotData(double tem, double pre, double fre, double amp)
        {
            this.tem = tem;
            this.pre = pre;
            this.fre = fre;
            this.amp = amp;
        }

    }
}
