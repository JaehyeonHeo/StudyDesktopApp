using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualsize.Text = string.Empty; 
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nostrum nam, consequatur provident laudantium minima exercitationem nobis, iste expedita molestias nemo qui recusandae? Beatae explicabo, veritatis ullam delectus quibusdam commodi quo?";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ad, praesentium labore doloremque rerum distinctio dolores, dicta sequi minima itaque similique molestiae nulla dolorum sit veniam nobis ducimus ullam quisquam dolorem.";

            LblAutoSize.Text = sample1;
            LblManualsize.Text = sample2; 
        }
    }
}
