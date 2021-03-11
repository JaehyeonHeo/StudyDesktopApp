using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool IsSetAlarm;
        WindowsMediaPlayer MediaPlayer; 


        public FrmAlarm()
        {
            InitializeComponent();
            // 초기화 작업
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            MediaPlayer = new WindowsMediaPlayer(); 

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = "";  // 시작할때 라벨에 있는 글자 지우기 

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "hh : mm : ss";

            MyTimer.Interval = 1000; // 1초 
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigiClock; 
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curtDate = DateTime.Now;
            LblDate.Text = curtDate.ToShortDateString();
            LblTime.Text = curtDate.ToString("hh:mm:ss"); 

            if (IsSetAlarm == true)  // 알람설정이 되어있다면
            {
                // 알람 시간과 현재시간 일치하면 알람울릴것 
                if (SetDay == DateTime.Today && SetTime.Hour == curtDate.Hour && 
                    SetTime.Minute == curtDate.Minute && SetTime.Second == curtDate.Second)
                {
                    //IsSetAlarm = false;
                    BtnRelease_Click(sender, e);
                    MediaPlayer.URL = @".\medias\alarm.mp3";
                    MediaPlayer.controls.play(); 

                    MessageBox.Show("알람 !!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }

            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} {SetTime.ToString("hh:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigiClock;
            IsSetAlarm = true; 
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigiClock;
        }
    }
}
