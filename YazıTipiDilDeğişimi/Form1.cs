using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aç komutu seçildi");
        }

        private void yeniBelgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni belge komutu seçildi");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                menuStrip1.Visible = true;
                menuStrip2.Visible = false;
                toolStripStatusLabel2.Text = "Türkçe";
                toolStripProgressBar1.Value = 33;
            }
            else
            {
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
                toolStripStatusLabel2.Text = "İngilizce";
                toolStripProgressBar1.Value = 66;
            }

        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (kalınToolStripMenuItem.Checked)
                kalınToolStripMenuItem.Checked = false;
            else kalınToolStripMenuItem.Checked = true;
            */
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (italikToolStripMenuItem.Checked)
                italikToolStripMenuItem.Checked = false;
            else italikToolStripMenuItem.Checked = true;
            */
        }

        private void altıÇizliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (altıÇizliToolStripMenuItem.Checked)
                altıÇizliToolStripMenuItem.Checked = false;
            else altıÇizliToolStripMenuItem.Checked = true;
            */

        }
    }
}
