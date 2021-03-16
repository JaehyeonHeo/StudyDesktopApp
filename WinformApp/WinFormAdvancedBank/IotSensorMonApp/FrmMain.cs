using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;  

namespace IotSensorMonApp
{
    public partial class FrmMain : Form
    {
        private double xCount = 200; // 차트에 보이는 데이터 수 

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // comboBox 초기화
            foreach (var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port); 
            }
            CboSerialPort.Text = "Select Port";

            // IoT장비에서 받을 값의 범위 
            PrbPhotoResistor.Minimum = 0;
            PrbPhotoResistor.Maximum = 1023;

            // 차트모양 초기화 
            InitChartStyle(); 

            // BtnDisplay 초기화
            BtnDisplay.BackColor = Color.CadetBlue;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "None";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            // 나머지 초기화
            LblConnectTime.Text = "Connection Time : ";
            TxtSensorNum.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false; 
        }

        /// <summary>
        /// 차트 초기설정 메서드 InitChartStyle()
        /// </summary>
        private void InitChartStyle()
        {
            ChtPhotoResisters.ChartAreas[0].BackColor = Color.DarkBlue;
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResisters.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResisters.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResisters.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResisters.Series.Clear();  //series1 값 지움
            ChtPhotoResisters.Series.Add("PhotoValue");
            ChtPhotoResisters.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResisters.Series[0].Color = Color.YellowGreen;
            ChtPhotoResisters.Series[0].BorderWidth = 2;

            // 범례삭제
            if (ChtPhotoResisters.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResisters.Legends.Count; i++)
                {
                    ChtPhotoResisters.Legends.RemoveAt(i); 
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // ToDo 나중에 실제 작업시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            // ToDo 나중에 실제 작업시 작성
        }


        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); // 차트, 리스트박스에 출력될 데이터 리스트  
        // 시뮬레이션 시작
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;
            timerSimul.Tick += TimerSimul_Tick; //메서드생성
            timerSimul.Start(); 
        }
        /// <summary>
        /// TimerSimul_Tick 메서드 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSimul_Tick(object sender, EventArgs e)
        {
            int value = randPhoto.Next(1, 1023);
            ShowSensorValue(value.ToString()); //메서드생성
        }
        /// <summary>
        /// 센서값 화면 출력 메서드 
        /// </summary>
        /// <param name="value"></param>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);
            var currentTime = DateTime.Now; 

            SensorData data = new SensorData(currentTime, v, IsSimulation);
            sensors.Add(data);

            // 센서값 갯수
            TxtSensorNum.Text = $"{sensors.Count}";
            // 프로그래스바 현재값 출력 
            PrbPhotoResistor.Value = v;
            // 리스트박스에 데이터 출력 
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1; // 스크롤 처리

            // 차트에 데이터 출력
            ChtPhotoResisters.Series[0].Points.Add(v); 

        }

        // 시뮬레이션 끝
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop(); 
        }

        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘후 프로그램을 종료하세요", "종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            Environment.Exit(0); 
        }
    }
}
