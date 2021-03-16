using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("로그인 성공"); 
            if (string.IsNullOrEmpty(TxtUserId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                // SqlConnection 연결
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // SqlCommand 생성
                    SqlCommand cmd = new SqlCommand();

                    // SqlInjection 해킹 막기 위해서 사용 
                    SqlParameter param; 

                    // SqlDataReader 실행(1)
                    SqlDataReader reader = cmd.ExecuteReader(); 

                    // reader로 처리 

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error : {ex.Message}", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
            // Environment.Exit(0); --> 오류가 있어도 종료가능 
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)  TxtPassword.Focus(); 
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnLogin_Click(sender, e); 
        }
    }
}


