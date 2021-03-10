
namespace ListboxWinApp
{
    partial class FrmMain
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
            this.LsbGDP_country = new System.Windows.Forms.ListBox();
            this.LsbGoodCity = new System.Windows.Forms.ListBox();
            this.LsbHappyCountry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdxGDP = new System.Windows.Forms.TextBox();
            this.TxtItemGDP = new System.Windows.Forms.TextBox();
            this.TxtIdxGoodCity = new System.Windows.Forms.TextBox();
            this.TxtItemGoodCity = new System.Windows.Forms.TextBox();
            this.TxtIdxHappy = new System.Windows.Forms.TextBox();
            this.TxtItemHappy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LsbGDP_country
            // 
            this.LsbGDP_country.FormattingEnabled = true;
            this.LsbGDP_country.ItemHeight = 12;
            this.LsbGDP_country.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "한국",
            "필리핀",
            "태국",
            "베트남",
            "스위스",
            "스웨덴",
            "덴마크",
            "멕시코",
            "이탈리아",
            "홍콩"});
            this.LsbGDP_country.Location = new System.Drawing.Point(117, 36);
            this.LsbGDP_country.Name = "LsbGDP_country";
            this.LsbGDP_country.Size = new System.Drawing.Size(138, 196);
            this.LsbGDP_country.TabIndex = 0;
            this.LsbGDP_country.SelectedIndexChanged += new System.EventHandler(this.LsbGDP_country_SelectedIndexChanged);
            // 
            // LsbGoodCity
            // 
            this.LsbGoodCity.FormattingEnabled = true;
            this.LsbGoodCity.ItemHeight = 12;
            this.LsbGoodCity.Location = new System.Drawing.Point(290, 36);
            this.LsbGoodCity.Name = "LsbGoodCity";
            this.LsbGoodCity.Size = new System.Drawing.Size(138, 196);
            this.LsbGoodCity.TabIndex = 1;
            this.LsbGoodCity.SelectedIndexChanged += new System.EventHandler(this.LsbGoodCity_SelectedIndexChanged);
            // 
            // LsbHappyCountry
            // 
            this.LsbHappyCountry.FormattingEnabled = true;
            this.LsbHappyCountry.ItemHeight = 12;
            this.LsbHappyCountry.Location = new System.Drawing.Point(462, 36);
            this.LsbHappyCountry.Name = "LsbHappyCountry";
            this.LsbHappyCountry.Size = new System.Drawing.Size(138, 196);
            this.LsbHappyCountry.TabIndex = 2;
            this.LsbHappyCountry.SelectedIndexChanged += new System.EventHandler(this.LsbHappyCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(114, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕코딩", 11F);
            this.label2.Location = new System.Drawing.Point(288, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "살기좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕코딩", 11F);
            this.label3.Location = new System.Drawing.Point(460, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "행복한 나라";
            // 
            // TxtIdxGDP
            // 
            this.TxtIdxGDP.Location = new System.Drawing.Point(116, 254);
            this.TxtIdxGDP.Name = "TxtIdxGDP";
            this.TxtIdxGDP.Size = new System.Drawing.Size(137, 19);
            this.TxtIdxGDP.TabIndex = 6;
            // 
            // TxtItemGDP
            // 
            this.TxtItemGDP.Location = new System.Drawing.Point(116, 279);
            this.TxtItemGDP.Name = "TxtItemGDP";
            this.TxtItemGDP.Size = new System.Drawing.Size(137, 19);
            this.TxtItemGDP.TabIndex = 7;
            // 
            // TxtIdxGoodCity
            // 
            this.TxtIdxGoodCity.Location = new System.Drawing.Point(291, 254);
            this.TxtIdxGoodCity.Name = "TxtIdxGoodCity";
            this.TxtIdxGoodCity.Size = new System.Drawing.Size(137, 19);
            this.TxtIdxGoodCity.TabIndex = 8;
            // 
            // TxtItemGoodCity
            // 
            this.TxtItemGoodCity.Location = new System.Drawing.Point(290, 279);
            this.TxtItemGoodCity.Name = "TxtItemGoodCity";
            this.TxtItemGoodCity.Size = new System.Drawing.Size(137, 19);
            this.TxtItemGoodCity.TabIndex = 9;
            // 
            // TxtIdxHappy
            // 
            this.TxtIdxHappy.Location = new System.Drawing.Point(462, 254);
            this.TxtIdxHappy.Name = "TxtIdxHappy";
            this.TxtIdxHappy.Size = new System.Drawing.Size(137, 19);
            this.TxtIdxHappy.TabIndex = 10;
            // 
            // TxtItemHappy
            // 
            this.TxtItemHappy.Location = new System.Drawing.Point(462, 279);
            this.TxtItemHappy.Name = "TxtItemHappy";
            this.TxtItemHappy.Size = new System.Drawing.Size(137, 19);
            this.TxtItemHappy.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Index :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selected Item :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtItemHappy);
            this.Controls.Add(this.TxtIdxHappy);
            this.Controls.Add(this.TxtItemGoodCity);
            this.Controls.Add(this.TxtIdxGoodCity);
            this.Controls.Add(this.TxtItemGDP);
            this.Controls.Add(this.TxtIdxGDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsbHappyCountry);
            this.Controls.Add(this.LsbGoodCity);
            this.Controls.Add(this.LsbGDP_country);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listbox Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LsbGDP_country;
        private System.Windows.Forms.ListBox LsbGoodCity;
        private System.Windows.Forms.ListBox LsbHappyCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdxGDP;
        private System.Windows.Forms.TextBox TxtItemGDP;
        private System.Windows.Forms.TextBox TxtIdxGoodCity;
        private System.Windows.Forms.TextBox TxtItemGoodCity;
        private System.Windows.Forms.TextBox TxtIdxHappy;
        private System.Windows.Forms.TextBox TxtItemHappy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

