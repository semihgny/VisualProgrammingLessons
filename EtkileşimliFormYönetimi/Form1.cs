using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            Form3 frm3 = new Form3();
            cevap = frm3.ShowDialog();

            if(cevap == DialogResult.OK) 
            { 
                label1.Text = "Onaylandı";
            }
            else if(cevap == DialogResult.Cancel) 
            {
                label1.Text = "İptal edildi";
            }
            else
            {
                label1.Text = "Yok sayıldı";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 Başlatılıyor");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form1 Kapatılıyor");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form1 Kapatıldı");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = e.X.ToString();
            label4.Text = e.Y.ToString();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Girildi";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "Çıkıldı";
        }

        int sayaç = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Text = e.X.ToString();
            label7.Text = e.Y.ToString();
            sayaç++;
            label8.Text = sayaç.ToString();
        } 
        
        private void Form1_Move(object sender, EventArgs e)
        {
            label9.Text = this.Location.X.ToString();
            label10.Text = this.Location.Y.ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label11.Text = this.Size.Width.ToString();
            label12.Text = this.Size.Height.ToString();
        }

    }
}
