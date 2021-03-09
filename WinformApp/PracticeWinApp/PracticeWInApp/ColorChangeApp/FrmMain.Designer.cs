
namespace ColorChangeApp
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
            this.PnlResult = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRed = new System.Windows.Forms.TextBox();
            this.TxtGreen = new System.Windows.Forms.TextBox();
            this.TxtBlue = new System.Windows.Forms.TextBox();
            this.BtnPrefix = new System.Windows.Forms.Button();
            this.TrbRED = new System.Windows.Forms.TrackBar();
            this.TrbGREEN = new System.Windows.Forms.TrackBar();
            this.TrbBLUE = new System.Windows.Forms.TrackBar();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TrbRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBLUE)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlResult
            // 
            this.PnlResult.BackColor = System.Drawing.Color.Black;
            this.PnlResult.Location = new System.Drawing.Point(55, 21);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(515, 196);
            this.PnlResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "BLUE";
            // 
            // TxtRed
            // 
            this.TxtRed.Location = new System.Drawing.Point(451, 239);
            this.TxtRed.Name = "TxtRed";
            this.TxtRed.ReadOnly = true;
            this.TxtRed.Size = new System.Drawing.Size(119, 21);
            this.TxtRed.TabIndex = 7;
            this.TxtRed.Text = "0";
            this.TxtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGreen
            // 
            this.TxtGreen.Location = new System.Drawing.Point(451, 285);
            this.TxtGreen.Name = "TxtGreen";
            this.TxtGreen.ReadOnly = true;
            this.TxtGreen.Size = new System.Drawing.Size(119, 21);
            this.TxtGreen.TabIndex = 8;
            this.TxtGreen.Text = "0";
            this.TxtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBlue
            // 
            this.TxtBlue.Location = new System.Drawing.Point(452, 334);
            this.TxtBlue.Name = "TxtBlue";
            this.TxtBlue.ReadOnly = true;
            this.TxtBlue.Size = new System.Drawing.Size(119, 21);
            this.TxtBlue.TabIndex = 9;
            this.TxtBlue.Text = "0";
            this.TxtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPrefix
            // 
            this.BtnPrefix.Location = new System.Drawing.Point(605, 139);
            this.BtnPrefix.Name = "BtnPrefix";
            this.BtnPrefix.Size = new System.Drawing.Size(55, 25);
            this.BtnPrefix.TabIndex = 10;
            this.BtnPrefix.Text = "Color";
            this.BtnPrefix.UseVisualStyleBackColor = true;
            this.BtnPrefix.Click += new System.EventHandler(this.BtnPrefix_Click);
            // 
            // TrbRED
            // 
            this.TrbRED.Location = new System.Drawing.Point(97, 236);
            this.TrbRED.Maximum = 255;
            this.TrbRED.Name = "TrbRED";
            this.TrbRED.Size = new System.Drawing.Size(348, 45);
            this.TrbRED.TabIndex = 11;
            this.TrbRED.TickFrequency = 5;
            this.TrbRED.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbGREEN
            // 
            this.TrbGREEN.Location = new System.Drawing.Point(97, 285);
            this.TrbGREEN.Maximum = 255;
            this.TrbGREEN.Name = "TrbGREEN";
            this.TrbGREEN.Size = new System.Drawing.Size(348, 45);
            this.TrbGREEN.TabIndex = 12;
            this.TrbGREEN.TickFrequency = 5;
            this.TrbGREEN.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbBLUE
            // 
            this.TrbBLUE.Location = new System.Drawing.Point(97, 334);
            this.TrbBLUE.Maximum = 255;
            this.TrbBLUE.Name = "TrbBLUE";
            this.TrbBLUE.Size = new System.Drawing.Size(348, 45);
            this.TrbBLUE.TabIndex = 13;
            this.TrbBLUE.TickFrequency = 5;
            this.TrbBLUE.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(605, 84);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(55, 25);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(605, 31);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(55, 25);
            this.BtnOpen.TabIndex = 10;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(686, 376);
            this.Controls.Add(this.TrbBLUE);
            this.Controls.Add(this.TrbGREEN);
            this.Controls.Add(this.TrbRED);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPrefix);
            this.Controls.Add(this.TxtBlue);
            this.Controls.Add(this.TxtGreen);
            this.Controls.Add(this.TxtRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlResult);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Color Scroller";
            ((System.ComponentModel.ISupportInitialize)(this.TrbRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBLUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRed;
        private System.Windows.Forms.TextBox TxtGreen;
        private System.Windows.Forms.TextBox TxtBlue;
        private System.Windows.Forms.Button BtnPrefix;
        private System.Windows.Forms.TrackBar TrbRED;
        private System.Windows.Forms.TrackBar TrbGREEN;
        private System.Windows.Forms.TrackBar TrbBLUE;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

