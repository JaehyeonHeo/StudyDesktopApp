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
    public partial class FrmBooksPopUp : MetroForm
    {
        public int selIdx { get; set; }

        public string selName { get; set; }

        #region 이벤트 영역
        public FrmBooksPopUp()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

       

        private void groupBox1_Resize(object sender, EventArgs e)
        {
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];

            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            selName = DgvData.SelectedRows[0].Cells[4].Value.ToString();


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

                    var query = @" SELECT  b.Idx
                                          ,b.Author
                                          ,b.Division
	                                      ,d.Names as DivName
                                          ,b.Names
                                          ,b.ReleaseDate
                                          ,b.ISBN
                                          ,b.Price
                                          ,b.Descriptions   
                                      FROM dbo.bookstbl as b
                                     INNER JOIN dbo.divtbl as d
                                        on b.Division = d.Division";  
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                                                                               MessageBoxIcon.Error);

            }
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 데이터그리드뷰 컬럼(Division) 화면에서 안보이게 
            var column = DgvData.Columns[2];
            column.Visible = false;
            column = DgvData.Columns[8];
            column.Visible = false; 
        }




        #endregion

        
    }
}
