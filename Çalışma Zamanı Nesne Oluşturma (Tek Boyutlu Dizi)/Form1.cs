using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Zamanı_Nesne_Oluşturma__Tek_Boyutlu_Dizi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] düğmeler = new Button[10];
        CheckBox cb = new CheckBox();

        private void tıkla(object sender, EventArgs e)
        {
            if (sender.GetType() == cb.GetType()) (sender as CheckBox).BackColor = Color.Red;
            if (sender.GetType() == düğmeler[0].GetType()) (sender as Button).BackColor = Color.Blue;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                düğmeler[i] = new Button();
                düğmeler[i].Parent = this;
                düğmeler[i].Name = "Düğme" + i.ToString();
                düğmeler[i].Left = 100;
                düğmeler[i].Top = i * 30;
                düğmeler[i].Text = "Düğme" + (i + 1).ToString();
                düğmeler[i].Click += new EventHandler(tıkla);
            }

            cb.Parent = this;
            cb.Click += new EventHandler(tıkla);
        }
    }
}
