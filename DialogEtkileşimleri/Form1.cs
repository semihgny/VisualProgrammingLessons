using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = colorDialog1.ShowDialog();

            if(cevap == DialogResult.OK) 
            { 
                label1.ForeColor = colorDialog1.Color;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = folderBrowserDialog1.ShowDialog();

            if ( cevap == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = fontDialog1.ShowDialog();

            if(cevap == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = openFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                label1.Text = saveFileDialog1.FileName;
            }
        }
    }
}
