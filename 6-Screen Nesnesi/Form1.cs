using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var ekran in Screen.AllScreens)
            {
                listBox1.Items.Add(ekran.Bounds.Width.ToString() );
                listBox1.Items.Add(ekran.Bounds.Height.ToString() );
            }

            /*
            label1.Text = Screen.AllScreens[0].Bounds.X.ToString();
            label2.Text = Screen.AllScreens[0].Bounds.Y.ToString();
            label3.Text = Screen.AllScreens[0].Bounds.Width.ToString();
            label4.Text = Screen.AllScreens[0].Bounds.Height.ToString();

            label5.Text = Screen.AllScreens[0].WorkingArea.X.ToString();
            label6.Text = Screen.AllScreens[0].WorkingArea.Y.ToString();
            label7.Text = Screen.AllScreens[0].WorkingArea.Width.ToString();
            label8.Text = Screen.AllScreens[0].WorkingArea.Height.ToString();
            */
            
            label1.Text = Screen.PrimaryScreen.Bounds.Location.X.ToString();
            label2.Text = Screen.PrimaryScreen.Bounds.Location.Y.ToString();
            label3.Text = Screen.PrimaryScreen.Bounds.Size.Width.ToString();
            label4.Text = Screen.PrimaryScreen.Bounds.Size.Height.ToString();

            label5.Text = Screen.PrimaryScreen.WorkingArea.Location.X.ToString();
            label6.Text = Screen.PrimaryScreen.WorkingArea.Location.Y.ToString();
            label7.Text = Screen.PrimaryScreen.WorkingArea.Size.Width.ToString();
            label8.Text = Screen.PrimaryScreen.WorkingArea.Size.Height.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, w, h;
            x = Screen.PrimaryScreen.Bounds.Size.Width / 10;
            y = Screen.PrimaryScreen.Bounds.Size.Height / 10;
            w = Screen.PrimaryScreen.Bounds.Size.Width * 0.8;
            h = Screen.PrimaryScreen.Bounds.Size.Height  0.8;

            label1.Text = x.ToString();
            label2.Text = y.ToString();
            label3.Text = w.ToString();
            label4.Text = h.ToString();

            this.Left = Convert.ToInt32( x);
            this.Top = Convert.ToInt32(y);
            this.Width = Convert.ToInt32(w);
            this.Height = Convert.ToInt32(h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(resim);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(resim.Width, resim.Height));

            pictureBox1.Image = resim;
            resim.Save("D:\\ekran.bmp");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(this.Width - 14, this.Height - 7);
            Graphics grafik = Graphics.FromImage(resim);
            grafik.CopyFromScreen(this.Left + 7, this.Top, 0, 0, new Size(this.Width - 14, this.Height - 7));

            pictureBox1.Image = resim;
            resim.Save("D:\\form.jpg");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
