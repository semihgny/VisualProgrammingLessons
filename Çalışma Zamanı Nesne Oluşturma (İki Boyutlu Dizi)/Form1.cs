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

namespace Çalışma_Zamanı_Nesne_Oluşturma__İki_Boyutlu_Dizi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] düğmeler = new Button[5, 8];

        int x, y;
        int s;

        Random r = new Random();

        private void tıkla(object sender, EventArgs e)
        {

            s = r.Next(8);
            s = s % 8;
            this.Text = Convert.ToString(s);
            switch (s)
            {
                case 0: (sender as Button).Image = Image.FromFile("meyveler\\karpuz.jpg"); break;
                case 1: (sender as Button).Image = Image.FromFile("meyveler\\portakal.jpg"); break;
                case 2: (sender as Button).Image = Image.FromFile("meyveler\\elma.jpg"); break;
                case 3: (sender as Button).Image = Image.FromFile("meyveler\\çilek.jpg"); break;
                case 4: (sender as Button).Image = Image.FromFile("meyveler\\armut.jpg"); break;
                case 5: (sender as Button).Image = Image.FromFile("meyveler\\muz.jpg"); break;
                case 6: (sender as Button).Image = Image.FromFile("meyveler\\ananas.jpg"); break;
                case 7: (sender as Button).Image = Image.FromFile("meyveler\\üzüm.jpg"); break;
            }
            label1.Text += s.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                for (y = 0; y < 8; y++)
                for (x = 0; x < 5; x++)
                {

                    düğmeler[x, y] = new Button();

                    this.Controls.Add(düğmeler[x, y]);

                    düğmeler[x, y].Name = "düğme" + Convert.ToString(x + 1) + Convert.ToString(y + 1);
                    düğmeler[x, y].Size = new Size(50, 50);
                    düğmeler[x, y].Location = new Point(x * 50, y * 50);

                    düğmeler[x, y].Text = Convert.ToString(x + 1) + ", " + Convert.ToString(y + 1);
                    düğmeler[x, y].Click += new EventHandler(tıkla);

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1000);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
