
namespace AlarmClockApp
{
    partial class FrmAlarm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabClock = new System.Windows.Forms.TabControl();
            this.TapSetAlarm = new System.Windows.Forms.TabPage();
            this.BtnRelease = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.DtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.DtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TapDigiClock = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblAlarm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.TabClock.SuspendLayout();
            this.TapSetAlarm.SuspendLayout();
            this.TapDigiClock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabClock
            // 
            this.TabClock.Controls.Add(this.TapSetAlarm);
            this.TabClock.Controls.Add(this.TapDigiClock);
            this.TabClock.Location = new System.Drawing.Point(4, 2);
            this.TabClock.Name = "TabClock";
            this.TabClock.SelectedIndex = 0;
            this.TabClock.Size = new System.Drawing.Size(414, 309);
            this.TabClock.TabIndex = 0;
            // 
            // TapSetAlarm
            // 
            this.TapSetAlarm.Controls.Add(this.BtnRelease);
            this.TapSetAlarm.Controls.Add(this.BtnSet);
            this.TapSetAlarm.Controls.Add(this.DtpAlarmTime);
            this.TapSetAlarm.Controls.Add(this.DtpAlarmDate);
            this.TapSetAlarm.Controls.Add(this.label2);
            this.TapSetAlarm.Controls.Add(this.label1);
            this.TapSetAlarm.Location = new System.Drawing.Point(4, 22);
            this.TapSetAlarm.Name = "TapSetAlarm";
            this.TapSetAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TapSetAlarm.Size = new System.Drawing.Size(406, 283);
            this.TapSetAlarm.TabIndex = 0;
            this.TapSetAlarm.Text = "알람설정";
            this.TapSetAlarm.UseVisualStyleBackColor = true;
            // 
            // BtnRelease
            // 
            this.BtnRelease.Location = new System.Drawing.Point(307, 250);
            this.BtnRelease.Name = "BtnRelease";
            this.BtnRelease.Size = new System.Drawing.Size(76, 25);
            this.BtnRelease.TabIndex = 5;
            this.BtnRelease.Text = "해제";
            this.BtnRelease.UseVisualStyleBackColor = true;
            this.BtnRelease.Click += new System.EventHandler(this.BtnRelease_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(209, 250);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(76, 25);
            this.BtnSet.TabIndex = 4;
            this.BtnSet.Text = "설정";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // DtpAlarmTime
            // 
            this.DtpAlarmTime.CustomFormat = "hh : mm : ss";
            this.DtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarmTime.Location = new System.Drawing.Point(26, 141);
            this.DtpAlarmTime.Name = "DtpAlarmTime";
            this.DtpAlarmTime.ShowUpDown = true;
            this.DtpAlarmTime.Size = new System.Drawing.Size(286, 21);
            this.DtpAlarmTime.TabIndex = 3;
            // 
            // DtpAlarmDate
            // 
            this.DtpAlarmDate.Location = new System.Drawing.Point(27, 58);
            this.DtpAlarmDate.Name = "DtpAlarmDate";
            this.DtpAlarmDate.Size = new System.Drawing.Size(285, 21);
            this.DtpAlarmDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "시간 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 설정";
            // 
            // TapDigiClock
            // 
            this.TapDigiClock.Controls.Add(this.groupBox1);
            this.TapDigiClock.Controls.Add(this.LblAlarm);
            this.TapDigiClock.Controls.Add(this.label3);
            this.TapDigiClock.Location = new System.Drawing.Point(4, 22);
            this.TapDigiClock.Name = "TapDigiClock";
            this.TapDigiClock.Padding = new System.Windows.Forms.Padding(3);
            this.TapDigiClock.Size = new System.Drawing.Size(406, 283);
            this.TapDigiClock.TabIndex = 1;
            this.TapDigiClock.Text = "디지털시계";
            this.TapDigiClock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재시간";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblTime.Location = new System.Drawing.Point(30, 79);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(79, 32);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "Time";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(34, 35);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 12);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date";
            // 
            // LblAlarm
            // 
            this.LblAlarm.AutoSize = true;
            this.LblAlarm.Location = new System.Drawing.Point(40, 74);
            this.LblAlarm.Name = "LblAlarm";
            this.LblAlarm.Size = new System.Drawing.Size(50, 12);
            this.LblAlarm.TabIndex = 1;
            this.LblAlarm.Text = "Alarm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "알람 설정";
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 313);
            this.Controls.Add(this.TabClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "알람시계";
            this.Load += new System.EventHandler(this.FrmAlarm_Load);
            this.TabClock.ResumeLayout(false);
            this.TapSetAlarm.ResumeLayout(false);
            this.TapSetAlarm.PerformLayout();
            this.TapDigiClock.ResumeLayout(false);
            this.TapDigiClock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabClock;
        private System.Windows.Forms.TabPage TapSetAlarm;
        private System.Windows.Forms.Button BtnRelease;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.DateTimePicker DtpAlarmTime;
        private System.Windows.Forms.DateTimePicker DtpAlarmDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TapDigiClock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer MyTimer;
    }
}

