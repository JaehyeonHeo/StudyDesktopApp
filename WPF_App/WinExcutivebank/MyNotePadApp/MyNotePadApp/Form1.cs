using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePadApp
{
    public partial class Form1 : Form
    {
        public bool IsModify { get; set; }

        private const string firstFilename = "noname.txt"; 

        private string CurrFileName = firstFilename; 

        public Form1()
        {
            InitializeComponent();
        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            // ToDo : 만약 작업중인 파일이 있으면 저장처리 후 실행
            ProcessSaveFileBeforeClose(); 

            TxtMain.Text = "";
            IsModify = false;
            CurrFileName = firstFilename;

            this.Text = $"{CurrFileName} - 내 메모장";
        }

        private void ProcessSaveFileBeforeClose()
        {
            if (IsModify)
            {
                DialogResult answer = MessageBox.Show("변경사항이 있습니다. 저장하시겠습니까?", "저장",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) 
                {
                    if(CurrFileName == firstFilename)
                    {
                        if (DlgSaveText.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(DlgSaveText.FileName);
                            sw.WriteLine(TxtMain.Text); 
                            sw.Close(); 
                        }
                        else
                        {
                            StreamWriter sw = File.CreateText(CurrFileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close(); 
                        }
                    }
                }
            }
        }

        private void MnuOpenFile_Click(object sender, EventArgs e)
        {
            ProcessSaveFileBeforeClose();

            DlgOpenText.ShowDialog();
            CurrFileName = DlgOpenText.FileName;
            this.Text = $"{CurrFileName} - 내 메모장";

            try
            {
                StreamReader sr = File.OpenText(CurrFileName);
                TxtMain.Text = sr.ReadToEnd();

                IsModify = false;
                sr.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ); 
            }


        }

        private void MnuSaveFile_Click(object sender, EventArgs e)
        {
            if (CurrFileName == firstFilename)
            {
                DlgSaveText.Filter = "Txt file (*.txt)|*.txt|(*.log)|*.log";
                if (DlgSaveText.ShowDialog() == DialogResult.OK)
                    CurrFileName = DlgSaveText.FileName; 

            }
            StreamWriter sw = File.CreateText(CurrFileName);
            sw.WriteLine(TxtMain.Text);

            IsModify = false;
            sw.Close();

            this.Text = $"{CurrFileName} - 내 메모장";

        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            ProcessSaveFileBeforeClose();
            Environment.Exit(0); 
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText); 
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                IsModify = true; 
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("메모장 v1.0 입니다."); 

            var form = new AboutThis();
            form.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DlgSaveText.Filter = "Txt file (*.txt)|*.txt|(*.log)|*.log";
            this.Text = $"{CurrFileName} - 내 메모장";
            IsModify = false; 
        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {
            IsModify = true;
            this.Text = $"{CurrFileName} - 내 메모장";
        }
    }
}
