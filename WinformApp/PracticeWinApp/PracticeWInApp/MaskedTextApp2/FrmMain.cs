using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string result = $"입사일 : {TxtHiredDate.Text}\n";
            result += $"우편번호 : {TxtZipCode.Text}\n";
            result += $"주소 : {TxtAddress.Text}\n";
            result += $"휴대폰번호 : {TxtMobile.Text}\n";
            result += $"주민번호 : {TxtRegisterNumber.Text}\n";
            result += $"Email : {TxtEmail.Text}\n";

            MessageBox.Show(result, "개인정보", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
