using MahApps.Metro.Controls;
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
using LiveCharts;
using LiveCharts.Wpf;
using System.Threading;
using System.Windows.Threading;

namespace PhotoSensorMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public ChartValues<float> ChartValues { get; set; }
        public int SensorValue { get; set; }

        public DispatcherTimer CustomTimer { get; set; }

        private void Window_Initialized(object sender, EventArgs e)
        {
            //var x = Enumerable.Range(0, 1001).Select(i => i / 10.0).ToArray();
            //var y = x.Select(v => Math.Abs(v)) < 1e-10 ? 1 : Math.Sin(v) / v).

            ChartValues = new ChartValues<float>() { 10, 5, 9, 6, 7, 3, 4, 5, 16.5f, 11.2f };
            GrdHistory.DataContext = ChartValues;

            CustomTimer = new DispatcherTimer();
            CustomTimer.Interval = TimeSpan.FromSeconds(1);
            CustomTimer.Tick += CustomTimer_Tick;
            CustomTimer.Start(); 
        }

        private void CustomTimer_Tick(object sender, EventArgs e)
        {
            SensorValue = new Random().Next(0, 1023);
            GrdRealTime.DataContext = SensorValue;
        }

      
    }
}
