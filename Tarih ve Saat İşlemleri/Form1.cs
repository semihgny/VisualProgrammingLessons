using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarih_ve_Saat_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman, u_zaman, l_zaman;

            zaman = DateTime.Now;

            //Tarih
            label1.Text = zaman.ToString();
            label2.Text = zaman.ToShortDateString();
            label3.Text = zaman.ToLongDateString();

            label4.Text = zaman.Day.ToString();
            label5.Text = zaman.Month.ToString();
            label6.Text = zaman.Year.ToString();

            label7.Text = zaman.DayOfWeek.ToString();
            label8.Text = zaman.DayOfYear.ToString();

            //Saat
            label9.Text = zaman.ToShortTimeString();
            label10.Text = zaman.ToLongTimeString();
            label11.Text = zaman.TimeOfDay.ToString();

            label12.Text = zaman.Hour.ToString();
            label13.Text = zaman.Minute.ToString();
            label14.Text = zaman.Second.ToString();
            label15.Text = zaman.Millisecond.ToString();

            //Universal Time UTC
            u_zaman = zaman.ToUniversalTime();
            label16.Text = u_zaman.ToString();

            //Local Time
            l_zaman = u_zaman.ToLocalTime();
            label17.Text = l_zaman.ToString();

            label18.Text = zaman.ToFileTime().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime t1, t2;
            TimeSpan geçensüre;

            t1 = Convert.ToDateTime(textBox1.Text);
            t2 = DateTime.Now;
            textBox2.Text = t2.ToString();

            geçensüre = t1 - t2;

            label19.Text = geçensüre.ToString();
            label20.Text = geçensüre.Days.ToString();
            label21.Text = geçensüre.Hours.ToString();
            label22.Text = geçensüre.Minutes.ToString();
            label23.Text = geçensüre.Seconds.ToString();
            label24.Text = geçensüre.Milliseconds.ToString();
        }
    }
}
