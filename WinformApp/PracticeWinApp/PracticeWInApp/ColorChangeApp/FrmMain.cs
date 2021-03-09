using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangeApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrbRED.Value.ToString();
            TxtGreen.Text = TrbGREEN.Value.ToString();
            TxtBlue.Text = TrbBLUE.Value.ToString();

            PnlResult.BackColor = Color.FromArgb(TrbRED.Value, TrbGREEN.Value, TrbBLUE.Value);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); 
        }

        private void BtnPrefix_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); 
        }
    }
}
