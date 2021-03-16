using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); // 차트, 리스트박스에 출력될 데이터 리스트
        // 데이터베이스 연결 
        private string connString = "Data Source=127.0.0.1;" +     
                                    "Initial Catalog=IoTData;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;" +
                                    "Password=mssql_p@ssw0rd!"; 
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


         

        // 시뮬레이션 시작
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000; // 1초
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
            InsertTable(data); 


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

            // 200개 넘으면 
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = (sensors.Count >= xCount) ? sensors.Count : xCount;

            // Zoom 처리
            if (sensors.Count >= xCount)
            {
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count); 
            }
            else
            {
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount); 
            }

            // BtnDisplay 처리
            if (IsSimulation)
            {
                BtnDisplay.Text = v.ToString(); 
            }
            else
            {
                BtnDisplay.Text = "~" + "\n" + v.ToString();
            }
        }
        /// <summary>
        /// IoT데이터베이스 내 Tbl_PhotoResister 테이블에 센서데이터 입력하는 메서드
        /// </summary>
        /// <param name="data"></param>
        private void InsertTable(SensorData data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open(); 
                    }
                    var query = $"insert into Tbl_PhotoResistor " +   // 데이터베이스에 자료삽입하는 쿼리문 
                        $" (CurrentDt, Value, SimulFlag) " +
                        $" values " +
                        $" ('{data.Current.ToString("yyyy-MM-dd HH:mm:ss")}', '{data.Value}', '{(data.SimulFlag == true ? "1" : "0")}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}"); 
            }
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

            Application.Exit(); 
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0, sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = sensors.Count / 4; 
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4;
        }
    }
}
