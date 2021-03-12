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

namespace AnlogClockApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point Center { get; set;  }
        public double Radius { get; set;  }
        public int HourHand { get; set;  }
        public int MinHand { get; set;  }
        public int SecHand { get; set;  }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            SetClock();
            SetTimer(); 
        }
        private void SetClock()
        {
            Center = new Point(CvsClock.Width / 2, CvsClock.Height / 2); // 시계 중심점
            Radius = CvsClock.Width / 2; // 시계의 반지름
            HourHand = (int)(Radius * 0.45); // 시침 길이
            MinHand = (int)(Radius * 0.55);
            SecHand = (int)(Radius * 0.75);
        }
        private void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);      // 1초
            timer.Tick += Timer_Tick;
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;

            CvsClock.Children.Clear();
            DrawClockFace();  // 시계판 그리기

            double radHour = (curTime.Hour % 12 + curTime.Minute / 60.0) * 30 * Math.PI / 180; // 현재 시침의 각도
            double radMin = (curTime.Minute + curTime.Second / 60.0) * 6 * Math.PI / 180;  // 현재 분침의 각도
            double radSec = (curTime.Second + curTime.Millisecond / 1000.0) * 6 * Math.PI / 180;
            Drawhands(radHour, radMin, radSec); 

        }

        private void Drawhands(double radHour, double radMin, double radSec)
        {
            //초침 그림
            DrawLine(SecHand * Math.Sin(radSec), -SecHand * Math.Cos(radSec),
                0, 0, Brushes.OrangeRed, 2, new Thickness(Center.X, Center.Y, 0, 0));
            // 분침그림 
            DrawLine(MinHand * Math.Sin(radMin), -MinHand * Math.Cos(radMin),
                0, 0, Brushes.DeepSkyBlue, 4, new Thickness(Center.X, Center.Y, 0, 0));
            // 시침그림
            DrawLine(HourHand * Math.Sin(radHour), -HourHand * Math.Cos(radHour),
                0, 0, Brushes.RoyalBlue, 6, new Thickness(Center.X, Center.Y, 0, 0));

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(CvsClock.Width / 2 - 10, CvsClock.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.Red;
            core.Fill = Brushes.OrangeRed;
            core.Height = 20;
            core.Width = 20;
            CvsClock.Children.Add(core); 
        }
        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color, int thick, Thickness margin)
        { // 그리기 메소드
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Triangle;
            CvsClock.Children.Add(line); 
        }

        private void DrawClockFace()
        {
            ElsClock.Stroke = Brushes.LightSteelBlue;
            ElsClock.StrokeThickness = 30;
            CvsClock.Children.Add(ElsClock); 
        }
    }
}
