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

        private void tamam_tıklandı(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void iptal_tıklandı(object sender, EventArgs e)
        {
            MessageBox.Show("Nasılsınız?");
        }

        private void yardım_tıklandı(object sender, EventArgs e)
        {
            //MessageBox.Show("İyi misiniz?");
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Fare basıldı";
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Fare bırakıldı";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "Fare girdi";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "Fare çıktı";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyData == Keys.F1) label3.Text = "Yardım tuşuna basıldı";
            else label3.Text = e.KeyData + " tuşuna basıldı";

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
            label3.Text = e.KeyData + " tuşu bırakıldı";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           label3.Text = e.KeyChar + " karakterine basıldı";
        }
    }
}
