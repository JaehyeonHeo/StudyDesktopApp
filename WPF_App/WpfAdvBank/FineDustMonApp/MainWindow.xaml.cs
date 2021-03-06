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
using System.Diagnostics;
using System.Data;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Xml;

namespace FineDustMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly string excelPath = $@"{AppDomain.CurrentDomain.BaseDirectory}busan_station_list.xls";

        private string openApiUrl = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?" +
            "serviceKey=yvBZ9H9iZ4YV2me5rXm9ArE6m%2Fy00y5FRIax2gF8%2FSYx%2BeRP0CBXl%2Fshu7JH%2F7mcObzlm7AIst3qNs3JZtnz9g%3D%3D&" +
            "returnType=xml&" +
            "numOfRows=100&" +
            "pageNo=1&" +
            "dataTerm=DAILY&" +
            "ver=1.0&" +
            "stationName=" ;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 엑셀 파일에서 측정소항목 불러오기 
            IWorkbook wb = null;
            ISheet sh = null;

            using (FileStream fs = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs); 
            }

            List<string> lstLabs = new List<string>();

            sh = wb.GetSheetAt(0); //sheet1에서 값을 가져옴
            int rowCount = sh.LastRowNum;

            try
            {
                for (int r = 0; r <= rowCount; r++)
                {
                    if (r == 0) continue;

                    lstLabs.Add(sh.GetRow(r).Cells[1].ToString());
                }
            }
            catch (Exception)
            {
                
            }
            
            Debug.WriteLine(lstLabs.Count);
            CboStations.ItemsSource = lstLabs; 
        }

        private void CboStations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstResult = new List<FineDustInfo>();

            if (CboStations.SelectedItem != null)
            {
                openApiUrl = openApiUrl.Substring(0, openApiUrl.LastIndexOf("=") + 1) + CboStations.SelectedItem.ToString();
                XmlDocument xml = new XmlDocument();
                xml.Load(openApiUrl);
                XmlNodeList xnList = xml.SelectNodes("/response/body/items/item");

                foreach (XmlNode item in xnList)
                {
                    // Debug.WriteLine($"dateTime : {item["dataTime"].InnerText}"); 
                    lstResult.Add(new FineDustInfo()
                    {
                        DataTime = item["dataTime"].InnerText,
                        KhaiValue = item["khaiValue"].InnerText,
                        So2 = item["so2Value"].InnerText
                    });   
                }
            }
            DgrFineDustInfos.ItemsSource = lstResult;
        }
        private List<FineDustInfo> lstResult; 
    }

    public class FineDustInfo
    {
        public string DataTime { get; set;  }
        public string KhaiValue { get; set;  }
        public string So2 { get; set;  }
    }
}
