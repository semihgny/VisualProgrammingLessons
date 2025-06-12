 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Zamanı_Nesne_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button düğme = new Button();
        Label etiket = new Label();
        TextBox metinkutusu = new TextBox();

        CheckBox cb = new CheckBox();



        private void düğme_tıklandı(object sender, EventArgs e)
        {

            label1.Text = "Düğme tıklandı";
        }

        private void fare_basıldı(object sender, MouseEventArgs e)
        {

            label2.Text = "Fare basıldı = " + e.X + ", " + e.Y;
        }

        private void fare_bırakıldı(object sender, MouseEventArgs e)
        {
            label3.Text = "Fare bırakıldı = " + e.X + ", " + e.Y; ;
        }

        private void karakter_basıldı(object sender, KeyPressEventArgs e)
        {
            label4.Text = "basılan karakter = " + e.KeyChar;
        }

        private void tuş_basıldı(object sender, KeyEventArgs e)
        {
            label5.Text = "basılan tuş = " + e.KeyValue;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            düğme.Parent = panel1;
            düğme.Left = 200;
            düğme.Top = 150;
            düğme.Text = "Tamam";
            düğme.Click += new EventHandler(düğme_tıklandı);
            düğme.MouseDown += new MouseEventHandler(fare_basıldı);
            düğme.MouseUp += new MouseEventHandler(fare_bırakıldı);
            düğme.KeyPress += new KeyPressEventHandler(karakter_basıldı);
            düğme.KeyDown += new KeyEventHandler(tuş_basıldı);

            etiket.Parent = this;
            etiket.Text = "Adı Soyadı";
            etiket.Left = 200;
            etiket.Top = 100;

            metinkutusu.Parent = this;
            metinkutusu.Left = 300;
            metinkutusu.Top = 100;

            cb.Parent = this;
            
        }
    }
}
