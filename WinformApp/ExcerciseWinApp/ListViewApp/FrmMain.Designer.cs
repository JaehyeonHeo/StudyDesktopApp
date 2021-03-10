
namespace ListViewApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LsvProducts = new System.Windows.Forms.ListView();
            this.RdbDetails = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmallicon = new System.Windows.Forms.RadioButton();
            this.RdbBigicon = new System.Windows.Forms.RadioButton();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgSmallicon = new System.Windows.Forms.ImageList(this.components);
            this.ImgBigicon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // LsvProducts
            // 
            this.LsvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvProducts.FullRowSelect = true;
            this.LsvProducts.GridLines = true;
            this.LsvProducts.HideSelection = false;
            this.LsvProducts.LargeImageList = this.ImgBigicon;
            this.LsvProducts.Location = new System.Drawing.Point(12, 65);
            this.LsvProducts.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LsvProducts.Name = "LsvProducts";
            this.LsvProducts.Size = new System.Drawing.Size(602, 230);
            this.LsvProducts.SmallImageList = this.ImgSmallicon;
            this.LsvProducts.TabIndex = 0;
            this.LsvProducts.UseCompatibleStateImageBehavior = false;
            this.LsvProducts.View = System.Windows.Forms.View.Details;
            this.LsvProducts.SelectedIndexChanged += new System.EventHandler(this.LsvProducts_SelectedIndexChanged);
            // 
            // RdbDetails
            // 
            this.RdbDetails.AutoSize = true;
            this.RdbDetails.Location = new System.Drawing.Point(251, 32);
            this.RdbDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RdbDetails.Name = "RdbDetails";
            this.RdbDetails.Size = new System.Drawing.Size(65, 21);
            this.RdbDetails.TabIndex = 1;
            this.RdbDetails.TabStop = true;
            this.RdbDetails.Text = "자세히";
            this.RdbDetails.UseVisualStyleBackColor = true;
            this.RdbDetails.CheckedChanged += new System.EventHandler(this.RdbDetails_CheckedChanged);
            // 
            // RdbList
            // 
            this.RdbList.AutoSize = true;
            this.RdbList.Location = new System.Drawing.Point(332, 32);
            this.RdbList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RdbList.Name = "RdbList";
            this.RdbList.Size = new System.Drawing.Size(65, 21);
            this.RdbList.TabIndex = 2;
            this.RdbList.TabStop = true;
            this.RdbList.Text = "리스트";
            this.RdbList.UseVisualStyleBackColor = true;
            this.RdbList.CheckedChanged += new System.EventHandler(this.RdbList_CheckedChanged);
            // 
            // RdbSmallicon
            // 
            this.RdbSmallicon.AutoSize = true;
            this.RdbSmallicon.Location = new System.Drawing.Point(414, 32);
            this.RdbSmallicon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RdbSmallicon.Name = "RdbSmallicon";
            this.RdbSmallicon.Size = new System.Drawing.Size(96, 21);
            this.RdbSmallicon.TabIndex = 3;
            this.RdbSmallicon.TabStop = true;
            this.RdbSmallicon.Text = "작은 아이콘";
            this.RdbSmallicon.UseVisualStyleBackColor = true;
            this.RdbSmallicon.CheckedChanged += new System.EventHandler(this.RdbSmallicon_CheckedChanged);
            // 
            // RdbBigicon
            // 
            this.RdbBigicon.AutoSize = true;
            this.RdbBigicon.Location = new System.Drawing.Point(531, 32);
            this.RdbBigicon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RdbBigicon.Name = "RdbBigicon";
            this.RdbBigicon.Size = new System.Drawing.Size(83, 21);
            this.RdbBigicon.TabIndex = 4;
            this.RdbBigicon.TabStop = true;
            this.RdbBigicon.Text = "큰 아이콘";
            this.RdbBigicon.UseVisualStyleBackColor = true;
            this.RdbBigicon.CheckedChanged += new System.EventHandler(this.RdbBigicon_CheckedChanged);
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(226, 324);
            this.TxtSelected.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(388, 25);
            this.TxtSelected.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected :";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제품명";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "단가";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "금액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 130;
            // 
            // ImgSmallicon
            // 
            this.ImgSmallicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallicon.ImageStream")));
            this.ImgSmallicon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallicon.Images.SetKeyName(0, "controller.png");
            this.ImgSmallicon.Images.SetKeyName(1, "ds.png");
            this.ImgSmallicon.Images.SetKeyName(2, "ps4.png");
            this.ImgSmallicon.Images.SetKeyName(3, "remote.png");
            this.ImgSmallicon.Images.SetKeyName(4, "xbox.png");
            // 
            // ImgBigicon
            // 
            this.ImgBigicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgBigicon.ImageStream")));
            this.ImgBigicon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgBigicon.Images.SetKeyName(0, "controller.png");
            this.ImgBigicon.Images.SetKeyName(1, "ds.png");
            this.ImgBigicon.Images.SetKeyName(2, "ps4.png");
            this.ImgBigicon.Images.SetKeyName(3, "remote.png");
            this.ImgBigicon.Images.SetKeyName(4, "xbox.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(626, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.RdbBigicon);
            this.Controls.Add(this.RdbSmallicon);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetails);
            this.Controls.Add(this.LsvProducts);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LsvProducts;
        private System.Windows.Forms.RadioButton RdbDetails;
        private System.Windows.Forms.RadioButton RdbList;
        private System.Windows.Forms.RadioButton RdbSmallicon;
        private System.Windows.Forms.RadioButton RdbBigicon;
        private System.Windows.Forms.TextBox TxtSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList ImgSmallicon;
        private System.Windows.Forms.ImageList ImgBigicon;
    }
}

