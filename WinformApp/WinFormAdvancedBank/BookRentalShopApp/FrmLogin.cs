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
        #region 메인 이벤트 
        public FrmLogin()
        {
            InitializeComponent();
             
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Activate();
            TxtUserId.Focus(); 
        }
        #endregion

        #region 클릭이벤트
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var strUserId = ""; 
             
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

                    var query = "SELECT userID FROM membertbl " +
                                " WHERE userID = @userID    " +
                                "   AND passwords = @passwords " +
                                "   AND levels = 'S' "; 

                    // SqlCommand 생성
                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    // SqlInjection 해킹 막기 위해서 사용 
                    SqlParameter pUserID = new SqlParameter("@userId", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserID);

                    SqlParameter pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 20);
                    pPasswords.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPasswords); 

                    // SqlDataReader 실행(1)
                    SqlDataReader reader = cmd.ExecuteReader();
                    // reader로 처리 
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";
                    reader.Close(); 
                    // 값이 넘어오는지 중간 확인
                    //MessageBox.Show(strUserId); 

                    if (string.IsNullOrEmpty(strUserId))
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                    else
                    {
                        var updateQuery = $@"UPDATE membertbl SET 
                                               lastloginDt = GETDATE() 
                                               , loginIpAddr = '{Helper.Common.GetLocalIp()}' 
                                               WHERE userId = '{strUserId}' ";
                        cmd.CommandText = updateQuery;
                        cmd.ExecuteNonQuery(); 
                        MetroMessageBox.Show(this, "접속성공", "로그인성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
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
        #endregion
    }
}


