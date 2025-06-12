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

namespace Metin_Dosyası_Okuma_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                File.WriteAllText(textBox2.Text, textBox1.Text);
                MessageBox.Show(textBox1.TextLength + " Byte Yazıldı");
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = File.ReadAllText(textBox2.Text);
                MessageBox.Show(textBox1.TextLength.ToString() + " Byte Okundu");
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Create(textBox3.Text);
            //FileStream dosya = File.OpenWrite(textBox3.Text);

            byte[] metin = new UTF8Encoding(true).GetBytes(textBox1.Text);
            dosya.Write(metin, 0, metin.Length);

            dosya.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FileStream dosya = File.Open(textBox3.Text, FileMode.Open);
            //FileStream dosya = File.OpenRead(textBox3.Text);

            byte[] veri = new byte[dosya.Length];
            dosya.Read(veri, 0, Convert.ToInt32(dosya.Length));

            textBox1.Text = Encoding.Default.GetString(veri);

            dosya.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter yazıcı = new StreamWriter(textBox4.Text);
            yazıcı.WriteLine(textBox1.Text);
            yazıcı.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader okuyucu = new StreamReader(textBox4.Text);
            string okunan = "";
            while (!okuyucu.EndOfStream)
            {
                okunan += okuyucu.ReadLine() + "\r\n";
            }
            okuyucu.Close();
            textBox1.Text = okunan;
        }
    }
}
