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
    public partial class FrmMemberPopUp : MetroForm
    {
        public int selIdx { get; set; }
        
        public string selName { get; set;  }

        #region 이벤트 영역
        public FrmMemberPopUp()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            RefreshData(); 
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            selIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            selName = DgvData.SelectedRows[0].Cells[1].Value.ToString(); 


            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
        
        #endregion

        #region 커스텀 메서드 영역

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
                                       "[Addr], [Mobile], [Email] " +
                                 " FROM [dbo].[membertbl]         ";

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

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
        }


        #endregion

        
    }
}
