using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ListViewItem itemSwitch = new ListViewItem("Nintendo Switch", 0);
            itemSwitch.SubItems.Add("600,000");
            itemSwitch.SubItems.Add("10");
            itemSwitch.SubItems.Add("6,000,000");
            ListViewItem itemDs = new ListViewItem("Nintendo DS", 1);
            itemDs.SubItems.Add("500,000");
            itemDs.SubItems.Add("10");
            itemDs.SubItems.Add("5,000,000");
            ListViewItem itemPs = new ListViewItem("PlaySataion 4", 2);
            itemPs.SubItems.Add("800,000");
            itemPs.SubItems.Add("12");
            itemPs.SubItems.Add("9,600,000");
            ListViewItem itemWii = new ListViewItem("Nintendo Wii", 3);
            itemWii.SubItems.Add("600,000");
            itemWii.SubItems.Add("30");
            itemWii.SubItems.Add("18,000,000");
            ListViewItem itemXbox = new ListViewItem("Xbox 360", 4);
            itemXbox.SubItems.Add("1,000,000");
            itemXbox.SubItems.Add("14");
            itemXbox.SubItems.Add("14,000,000");


            LsvProducts.Items.AddRange(new ListViewItem[] { itemSwitch, itemDs, itemPs, itemWii, itemXbox }); 
        }

        private void RdbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDetails.Checked)
            {
                LsvProducts.View = View.Details; 
            }
        }

        private void RdbList_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbList.Checked)
            {
                LsvProducts.View = View.List; 
            }
        }

        private void RdbSmallicon_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSmallicon.Checked)
            {
                LsvProducts.View = View.SmallIcon; 
            }
        }

        private void RdbBigicon_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBigicon.Checked)
            {
                LsvProducts.View = View.LargeIcon; 
            }
        }

        private void LsvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSelected.Text = string.Empty;

            var selected = LsvProducts.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                {
                    TxtSelected.Text += item.SubItems[i].Text + " ";
                }
            }
        }
    }
}
