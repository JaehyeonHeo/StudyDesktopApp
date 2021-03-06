
namespace MaskedTextApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHiredDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.TxtRegisterNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.TxtMobile = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.MaskedTextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "입사일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "우편번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "휴대폰 번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "주민번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // TxtHiredDate
            // 
            this.TxtHiredDate.Location = new System.Drawing.Point(101, 22);
            this.TxtHiredDate.Mask = "0000-00-00";
            this.TxtHiredDate.Name = "TxtHiredDate";
            this.TxtHiredDate.Size = new System.Drawing.Size(83, 20);
            this.TxtHiredDate.TabIndex = 0;
            this.TxtHiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(101, 57);
            this.TxtZipCode.Mask = "99999";
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(44, 20);
            this.TxtZipCode.TabIndex = 1;
            this.TxtZipCode.ValidatingType = typeof(int);
            // 
            // TxtRegisterNumber
            // 
            this.TxtRegisterNumber.Location = new System.Drawing.Point(101, 165);
            this.TxtRegisterNumber.Mask = "000000-0000000";
            this.TxtRegisterNumber.Name = "TxtRegisterNumber";
            this.TxtRegisterNumber.Size = new System.Drawing.Size(108, 20);
            this.TxtRegisterNumber.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(101, 200);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(187, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(101, 129);
            this.TxtMobile.Mask = "000-9000-0000";
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(108, 20);
            this.TxtMobile.TabIndex = 3;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(101, 93);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(369, 20);
            this.TxtAddress.TabIndex = 2;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Image = global::MaskedTextApp2.Properties.Resources.register;
            this.BtnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegister.Location = new System.Drawing.Point(101, 236);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(77, 28);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "   등록";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 279);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtMobile);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtRegisterNumber);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.TxtHiredDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmMain";
            this.Text = "Employee ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtHiredDate;
        private System.Windows.Forms.MaskedTextBox TxtZipCode;
        private System.Windows.Forms.MaskedTextBox TxtRegisterNumber;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox TxtMobile;
        private System.Windows.Forms.MaskedTextBox TxtAddress;
        private System.Windows.Forms.Button BtnRegister;
    }
}

