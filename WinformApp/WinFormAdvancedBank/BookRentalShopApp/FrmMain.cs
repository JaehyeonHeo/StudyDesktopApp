using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMain : MetroForm

    {
        #region FrmMain Load 영역
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        /// <summary>
        /// 메인화면 닫는 이벤트 : 닫기전에 물어보고 닫게 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false; 
                Environment.Exit(0);
                // application.exit() 하니깐 오류 발생,,,,이유는 ?
            }
            else
            {
                e.Cancel = true; // 프로그램 종료안함
            }
        }
        #endregion


        #region 메뉴버튼 영역

        /// <summary>
        /// 메뉴버튼 중 종료 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
                // application.exit() 하니깐 오류 발생,,,,이유는 ?
            }
            else
            {
                return;  // 프로그램 종료안함
            }
        }

        
        /// <summary>
        /// 구분코드 메뉴 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuDivCode_Click(object sender, EventArgs e)
        {
            // 화면사이즈 조절 후 화면 표시 
            FrmDivCode frm = new FrmDivCode();
            InitChildForm(frm, "구분코드 관리"); 
        }

        /// <summary>
        /// 회원정보 메뉴 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuMember_Click(object sender, EventArgs e)
        {
            // 화면사이즈 조절 후 화면 표시
            FrmMember frm = new FrmMember();
            InitChildForm(frm, "회원관리"); 
        }

        /// <summary>
        /// 도서관리 메뉴 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuBooks_Click(object sender, EventArgs e)
        {
            FrmBooks frm = new FrmBooks();
            InitChildForm(frm, "도서관리");
        }
        #endregion

        #region 메서드 영역

        /// <summary>
        /// 형식 지정 메서드 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="strTitle"></param>
        private void InitChildForm(Form frm, string strTitle)
        {
            frm.Text = strTitle;
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this;   // FrmMain 

            /*frm.Width = this.ClientSize.Width - 10;
            frm.Height = this.Height - menuStrip1.Height;*/
            frm.Show();
            frm.WindowState = FormWindowState.Normal;
        }
        #endregion

        
    }
}
