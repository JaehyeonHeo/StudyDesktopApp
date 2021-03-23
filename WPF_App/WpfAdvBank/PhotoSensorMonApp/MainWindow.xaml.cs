using MahApps.Metro.Controls;
using System;
using System.Windows;
using LiveCharts;
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Linq;
using OxyPlot;
using System.Collections.Generic;

namespace PhotoSensorMonApp
{
    public class SensorData
    {
        public int Idx { get; set;  }
        public DateTime CurrentDt { get; set;  }
        public int Value { get; set;  }
        public bool SimulFlag { get; set;  }

        public SensorData(int idx, DateTime currentDt, int value, bool simulFlag)
        {
            Idx = idx;
            CurrentDt = currentDt;
            Value = value;
            SimulFlag = simulFlag; 
        }
        
    }

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 



    public partial class MainWindow : MetroWindow
    {
        private readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger(); 
        public MainWindow()
        {
            InitializeComponent();

            logger.Info("PhotoSendorMonApp Initialized..."); 
        }


        public ChartValues<int> ChartValues { get; set; }
        public int SensorValue { get; set; }

        public DispatcherTimer CustomTimer { get; set; }

        private string connString = "Data Source=210.119.12.86; " +
                                   "Initial Catalog=IoTData; " +
                                   "Persist Security Info=True; " +
                                   "User ID=sa; Password=mssql_p@ssw0rd!";    // DB 연결하기 위한 문자열!!!! 
        public SensorData GetRealTimeSensor()
        {
            SensorData result = null; 

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = @"SELECT TOP 1  Idx 
                                              , CurrentDt 
                                              , Value 
                                              , SimulFlag 
                                          FROM  Tbl_PhotoResistor 
                                      ORDER By  idx desc;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    var temp = cmd.ExecuteReader();

                    if (temp.Read())
                    {
                        result = new SensorData(Convert.ToInt32( temp["Idx"]), 
                                                Convert.ToDateTime(temp["CurrentDt"]),
                                                Convert.ToInt32(temp["Value"]), 
                                                Convert.ToBoolean( temp["SimulFlag"]));
                    }
                }

                logger.Info("GetRealTimeSensor() completed."); 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");
                logger.Error($"GetRealTimeSensor() error occered {ex}"); 
            }

            return result; 
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

            ChartValues = new ChartValues<int>(); // { 10, 5, 9, 5, 3, 2, 9, 16, 20, 40 }; 
            GrdHistory.DataContext = ChartValues;

            CustomTimer = new DispatcherTimer();
            CustomTimer.Interval = TimeSpan.FromSeconds(1);
            CustomTimer.Tick += CustomTimer_Tick;
            //CustomTimer.Start(); 
        }

        

        private void CustomTimer_Tick(object sender, EventArgs e)
        {
            SensorValue = GetRealTimeSensor().Value; 
            GrdRealTime.DataContext = SensorValue;
        }

        private void MnuStart_Click(object sender, RoutedEventArgs e)
        {
            CustomTimer.Start(); 
        }

        private void MnuStop_Click(object sender, RoutedEventArgs e)
        {
            CustomTimer.Stop(); 
        }

        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuLoad_Click(object sender, RoutedEventArgs e)
        {
            HistoryValues.ItemsSource = GetHistorySensors();  
        }

        private List<DataPoint> GetHistorySensors()
        {
            List<DataPoint> result = new List<DataPoint>();  

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = $@"SELECT Idx, Value 
                                    FROM  Tbl_PhotoResistor 
                                   WHERE  CurrentDt  > CONVERT(DATETIME, '{DateTime.Now.ToString("yyyy-MM-dd")}')
                                ORDER BY  Idx";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(new DataPoint(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1])));
                    }
                }
                logger.Info("GetHistorySensors() completed."); 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");
                logger.Error($"GetHistorySensors() error occured : {ex}"); 
                
            }

            return result; 
        }
    }
}
