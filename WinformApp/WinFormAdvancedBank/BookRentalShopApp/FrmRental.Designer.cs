
namespace BookRentalShopApp
{
    partial class FrmRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbDtail = new System.Windows.Forms.GroupBox();
            this.TxtReturnDate = new System.Windows.Forms.TextBox();
            this.CboRentalState = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.TxtBookName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GrbDtail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDtail
            // 
            this.GrbDtail.Controls.Add(this.TxtReturnDate);
            this.GrbDtail.Controls.Add(this.CboRentalState);
            this.GrbDtail.Controls.Add(this.metroLabel5);
            this.GrbDtail.Controls.Add(this.metroLabel4);
            this.GrbDtail.Controls.Add(this.BtnSearchBook);
            this.GrbDtail.Controls.Add(this.BtnSearchMember);
            this.GrbDtail.Controls.Add(this.DtpRentalDate);
            this.GrbDtail.Controls.Add(this.TxtBookName);
            this.GrbDtail.Controls.Add(this.metroLabel6);
            this.GrbDtail.Controls.Add(this.metroLabel3);
            this.GrbDtail.Controls.Add(this.TxtMemberName);
            this.GrbDtail.Controls.Add(this.TxtIdx);
            this.GrbDtail.Controls.Add(this.BtnSave);
            this.GrbDtail.Controls.Add(this.BtnNew);
            this.GrbDtail.Controls.Add(this.metroLabel2);
            this.GrbDtail.Controls.Add(this.metroLabel1);
            this.GrbDtail.Location = new System.Drawing.Point(736, 63);
            this.GrbDtail.Name = "GrbDtail";
            this.GrbDtail.Size = new System.Drawing.Size(278, 424);
            this.GrbDtail.TabIndex = 23;
            this.GrbDtail.TabStop = false;
            this.GrbDtail.Text = "상세";
            // 
            // TxtReturnDate
            // 
            this.TxtReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReturnDate.Font = new System.Drawing.Font("나눔고딕코딩", 10F);
            this.TxtReturnDate.Location = new System.Drawing.Point(96, 242);
            this.TxtReturnDate.Name = "TxtReturnDate";
            this.TxtReturnDate.ReadOnly = true;
            this.TxtReturnDate.Size = new System.Drawing.Size(163, 21);
            this.TxtReturnDate.TabIndex = 26;
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.ItemHeight = 23;
            this.CboRentalState.Location = new System.Drawing.Point(96, 300);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.Size = new System.Drawing.Size(166, 29);
            this.CboRentalState.TabIndex = 7;
            this.CboRentalState.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 300);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "대여상태 : ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 244);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "반납일 : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Image = global::BookRentalShopApp.Properties.Resources.search;
            this.BtnSearchBook.Location = new System.Drawing.Point(232, 132);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(31, 26);
            this.BtnSearchBook.TabIndex = 4;
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = global::BookRentalShopApp.Properties.Resources.search;
            this.BtnSearchMember.Location = new System.Drawing.Point(232, 76);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(31, 26);
            this.BtnSearchMember.TabIndex = 2;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentalDate.Location = new System.Drawing.Point(96, 188);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(167, 29);
            this.DtpRentalDate.TabIndex = 5;
            // 
            // TxtBookName
            // 
            // 
            // 
            // 
            this.TxtBookName.CustomButton.Image = null;
            this.TxtBookName.CustomButton.Location = new System.Drawing.Point(106, 2);
            this.TxtBookName.CustomButton.Name = "";
            this.TxtBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookName.CustomButton.TabIndex = 1;
            this.TxtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookName.CustomButton.UseSelectable = true;
            this.TxtBookName.CustomButton.Visible = false;
            this.TxtBookName.Lines = new string[0];
            this.TxtBookName.Location = new System.Drawing.Point(96, 132);
            this.TxtBookName.MaxLength = 32767;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.PasswordChar = '\0';
            this.TxtBookName.PromptText = "도서명";
            this.TxtBookName.ReadOnly = true;
            this.TxtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookName.SelectedText = "";
            this.TxtBookName.SelectionLength = 0;
            this.TxtBookName.SelectionStart = 0;
            this.TxtBookName.ShortcutsEnabled = true;
            this.TxtBookName.Size = new System.Drawing.Size(130, 26);
            this.TxtBookName.TabIndex = 3;
            this.TxtBookName.UseSelectable = true;
            this.TxtBookName.WaterMark = "도서명";
            this.TxtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(28, 188);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "대여일 : ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "도서명 : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtMemberName
            // 
            // 
            // 
            // 
            this.TxtMemberName.CustomButton.Image = null;
            this.TxtMemberName.CustomButton.Location = new System.Drawing.Point(106, 2);
            this.TxtMemberName.CustomButton.Name = "";
            this.TxtMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberName.CustomButton.TabIndex = 1;
            this.TxtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberName.CustomButton.UseSelectable = true;
            this.TxtMemberName.CustomButton.Visible = false;
            this.TxtMemberName.Lines = new string[0];
            this.TxtMemberName.Location = new System.Drawing.Point(96, 76);
            this.TxtMemberName.MaxLength = 32767;
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.PasswordChar = '\0';
            this.TxtMemberName.PromptText = "대여회원";
            this.TxtMemberName.ReadOnly = true;
            this.TxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberName.SelectedText = "";
            this.TxtMemberName.SelectionLength = 0;
            this.TxtMemberName.SelectionStart = 0;
            this.TxtMemberName.ShortcutsEnabled = true;
            this.TxtMemberName.Size = new System.Drawing.Size(130, 26);
            this.TxtMemberName.TabIndex = 1;
            this.TxtMemberName.UseSelectable = true;
            this.TxtMemberName.WaterMark = "대여회원";
            this.TxtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(96, 29);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(166, 26);
            this.TxtIdx.TabIndex = 0;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.Location = new System.Drawing.Point(189, 373);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(73, 32);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNew.Location = new System.Drawing.Point(103, 373);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(73, 32);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "대여회원 : ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "순번 : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(14, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(700, 423);
            this.DgvData.TabIndex = 22;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 519);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDtail);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmRental";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 20);
            this.Text = "대여관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.GrbDtail.ResumeLayout(false);
            this.GrbDtail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDtail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroTextBox TxtMemberName;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtBookName;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.Button BtnSearchBook;
        private MetroFramework.Controls.MetroComboBox CboRentalState;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox TxtReturnDate;
    }
}