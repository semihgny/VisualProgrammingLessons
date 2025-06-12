using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) timer1.Enabled = true;
            else timer1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) timer2.Enabled = true;
            else timer2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) timer3.Enabled = true;
            else timer3.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) timer4.Enabled = true;
            else timer4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.Text = Convert.ToString(DateTime.Now);

            int kırmızı = rnd.Next(256);
            int yeşil = rnd.Next(256);
            int mavi = rnd.Next(256);

            label2.Text = Convert.ToString(kırmızı);
            label3.Text = Convert.ToString(yeşil);
            label4.Text = Convert.ToString(mavi);

            this.BackColor = Color.FromArgb(kırmızı, yeşil, mavi);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            float şeffaflık = rnd.Next(100);
            şeffaflık = şeffaflık / 100;

            label5.Text = Convert.ToString(şeffaflık);
            this.Opacity = şeffaflık;
        }

        float x = 0;
        bool ileri = true;

        private void timer4_Tick(object sender, EventArgs e)
        {
            float şeffaflık;
            şeffaflık = x / 100;
            
            if (ileri) x++; else x--;
            
            label6.Text = Convert.ToString(şeffaflık);
            label7.Text = Convert.ToString(x);
            this.Opacity = şeffaflık;
            progressBar1.Value = Convert.ToByte(x);


            if (ileri & x == 100) ileri = !ileri;
            if (!ileri & x == 0) ileri = !ileri;
        }
        int sayı;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayı = rnd.Next(100);
            listBox1.Items.Add(sayı.ToString());
        }
    }
}
