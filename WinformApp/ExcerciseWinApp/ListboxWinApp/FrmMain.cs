using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // GoodCity 초기화, 가장 기본적인 리스트박스 추가
            LsbGoodCity.Items.Add("오스트리아, 빈");
            LsbGoodCity.Items.Add("호주, 멜버른");
            LsbGoodCity.Items.Add("일본, 오사카");
            LsbGoodCity.Items.Add("캐나다, 캘거리");
            LsbGoodCity.Items.Add("호주, 시드니");
            LsbGoodCity.Items.Add("캐나다, 밴쿠버");
            LsbGoodCity.Items.Add("일본, 도쿄");
            LsbGoodCity.Items.Add("캐나다, 토론토");
            LsbGoodCity.Items.Add("덴마크, 코펜하겐");
            LsbGoodCity.Items.Add("호주, 애들레이드");

            List<string> lstCounty = new List<string>()
            {
                "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아",
                "UAE", "필리핀"
            };
            LsbHappyCountry.DataSource = lstCounty;
            
        }

        private void LsbGDP_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 값 확인
            //MessageBox.Show(sender.ToString()); 
            var selItem = sender as ListBox;
            //MessageBox.Show($"{selItem.SelectedIndex} / {selItem.SelectedItem}"); 
            TxtIdxGDP.Text = selItem.SelectedIndex.ToString();
            TxtItemGDP.Text = selItem.SelectedItem.ToString(); 

        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            //MessageBox.Show($"{selItem.SelectedIndex} / {selItem.SelectedItem}"); 
            TxtIdxGoodCity.Text = selItem.SelectedIndex.ToString();
            TxtItemGoodCity.Text = selItem.SelectedItem.ToString();
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            //MessageBox.Show($"{selItem.SelectedIndex} / {selItem.SelectedItem}"); 
            TxtIdxHappy.Text = selItem.SelectedIndex.ToString();
            TxtItemHappy.Text = selItem.SelectedItem.ToString();
        }

        
    }
}
