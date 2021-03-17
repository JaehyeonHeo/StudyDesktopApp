using MetroFramework.Forms;
using MetroFramework; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {
        #region 전역변수 영역
        private bool isNew = false;  // false = 수정, true = 신규 
        #endregion

        #region 이벤트 영역
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            isNew = true; 
            RefreshData(); 
        }
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDtail.Height = this.ClientRectangle.Height - 90;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevel.SelectedItem = selData.Cells[2].Value; 
                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtUserID.Text = selData.Cells[6].Value.ToString();
                TxtPassword.Text = selData.Cells[7].Value.ToString();
                TxtIdx.ReadOnly = true;

                isNew = false; // 수정 
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false) return; // 메서드 사용

            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData(); // 메서드 사용
            RefreshData();// 메서드 사용
            ClearInputs();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation 체크 (유효성 체크)
            if (CheckValidation() == false) return; // 메서드사용

            SaveData(); //메서드사용
            RefreshData(); //메서드사용
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs(); // 메서드사용
        }
        #endregion

        #region 커스텀 메서드 영역
        /// <summary>
        /// 삭제메서드
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";
                    query = "DELETE FROM [dbo].[membertbl] " +
                            " WHERE [Idx] = @Idx ";
                    cmd.CommandText = query;

                    SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 데이터 조회 메서드
        /// </summary>
        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "SELECT [Idx], [Names], [Levels], " +
                        "[Addr], [Mobile], [Email], " +
                        "[userID], [lastLoginDt] " +
                        " FROM [dbo].[membertbl] ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                                                                               MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// 저장 메서드
        /// </summary>
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    // 신규내용이면 쿼리문을 insert쿼리문 사용해서 저장, 기존내용이면 update쿼리 사용해서 수정됨 !
                    if (isNew == true) // INSERT 쿼리
                    {
                        query = @" INSERT INTO [dbo].[membertbl]  
                                               [Names] 
                                               ,[Levels] 
                                               ,[Addr] 
                                               ,[Mobile] 
                                               ,[Email] 
                                               ,[userID] 
                                               ,[passwords] 
                                        VALUES
                                               @Names
                                               @Levels
                                               @Addr
                                               @Mobile
                                               @Email
                                               @userID
                                               @passwords "; 
                    }
                    else // UPDATE 쿼리 
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                     SET [Names] = @Names  
                                          ,[Levels] = @Levels 
                                          ,[Addr] = @Addr 
                                          ,[Mobile] =@Mobile 
                                          ,[Email] = @Email 
                                          ,[userID] = @userID 
                                          ,[passwords] = @passwords 
                                   WHERE idx = @idx; ";
                    }
                    cmd.CommandText = query;

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevel.SelectedItem;
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    var pUserID = new SqlParameter("@UserID", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(pUserID);

                    var pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPasswords);

                    if (isNew == false) // update 일때만 idx사용
                    {
                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "실패",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            if ( string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtUserID.Text) ||
                CboLevel.SelectedIndex ==-1 )
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 초기화 메서드
        /// </summary>
        private void ClearInputs()
        {
            // 초기화한 후에 읽기전용 해제
            TxtIdx.Text = TxtNames.Text = 
            TxtMobile.Text = TxtEmail.Text =
            TxtUserID.Text = TxtPassword.Text = 
            TxtAddr.Text =  "";
            CboLevel.SelectedIndex = -1; 
            TxtIdx.ReadOnly = true;
            isNew = true;
        }

        #endregion







    }
}
