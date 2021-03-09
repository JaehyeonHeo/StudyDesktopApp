using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWInApp.Views  // 네임스페이스 변경할때는 designer.cs 코드의 네임스페이스도 바꿔야한다.
{
    public partial class FrmParents : Form
    {
        public FrmParents()
        {
            InitializeComponent();
        }

        private void FrmParents_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(800, 600);

            FrmChild frm = new FrmChild();
            this.AddOwnedForm(frm);    // 부모창 위에 자식창이 뜨도록 하는것 

            frm.Show();   // Show()는 modaless 이다. , Showdialog()는 madal

        }
    }
}
