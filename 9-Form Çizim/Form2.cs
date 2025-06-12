using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Çizim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Image resim2 = Image.FromFile("Çiçek.jpg");

        private void Form2_Resize(object sender, EventArgs e)
        {
            Graphics FormGrafik = CreateGraphics();
            FormGrafik.DrawImage(resim2, 0, 0, this.Width, this.Height);
        }


        private void Form2_Shown(object sender, EventArgs e)
        {
            Graphics FormGrafik = CreateGraphics();
            FormGrafik.DrawImage(resim2, 0, 0, this.Width, this.Height);
        }
    }
}
