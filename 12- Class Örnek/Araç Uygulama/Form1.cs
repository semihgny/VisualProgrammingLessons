using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Araç_Kütüphane;

namespace Araç_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private class Araba
        {
            public string marka { get; set; } = "Renault";
            public string model { get; set; } = "Clio";
            public uint yıl { get; set; } = 2019;
            public string renk { get; set; } = "Gri";
        }

        Araç oto1 = new Araç();    //DLL içinde

        Araba oto2 = new Araba();  //Form1.cs içinde 

        Otomobil oto3 = new Otomobil(); //Otomobil.cs içinde

        private void button1_Click(object sender, EventArgs e)
        {
            oto1.marka = "Mercedes";
            oto1.model = "E200";
            oto1.yıl = 2021;
            oto1.renk = "Kırmızı";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = oto1.marka;
            textBox2.Text = oto1.model;
            textBox3.Text = oto1.yıl.ToString();
            textBox4.Text = oto1.renk;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oto2.marka = "BMW";
            oto2.model = "5.20";
            oto2.yıl = 2020;
            oto2.renk = "Yeşil";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = oto2.marka;
            textBox6.Text = oto2.model;
            textBox7.Text = oto2.yıl.ToString();
            textBox8.Text = oto2.renk;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oto3.marka = "Ferrari";
            oto3.model = "F50";
            oto3.yıl = 2021;
            oto3.renk = "Sarı";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Text = oto3.marka;
            textBox10.Text = oto3.model;
            textBox11.Text = oto3.yıl.ToString();
            textBox12.Text = oto3.renk;
        }
    }
}
