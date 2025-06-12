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

namespace Hata_Yakalama
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
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Tip Dönüşüm hatası oluştu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Tip Dönüşüm hatası oluştu");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Sıfıra bölme hatası oluştu");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(textBox5.Text, textBox4.Text);
                MessageBox.Show(textBox4.TextLength.ToString() + " Byte Yazıldı");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Diske yazma yetkisi yok");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Konum bulunamadı hatası");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Geçersiz karakter hatası");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = File.ReadAllText(textBox5.Text);
                MessageBox.Show(textBox4.TextLength.ToString() + " Byte Okundu");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dosya bulunamadı hatası");
            }
            catch (IOException)
            {
                MessageBox.Show("Dosya kullanımda hatası");
            }
        }
    }
}
