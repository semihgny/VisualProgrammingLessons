using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Çizim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string metin = "Mustafa İlhan";
        int paintOlayıSayacı, resizeOlayıSayacı;

        Point nokta1 = new Point(50, 200);
        Point nokta2 = new Point(50, 300);

        Point[] noktalar1 = new Point[5]
        {
            new Point (150,200),
            new Point (250,150),
            new Point { X = 350, Y = 200 },
            new Point (300,300),
            new Point (200,300)
        };

        Point[] noktalar2 = new Point[3]
        {
            new Point (900,150),
            new Point (850,200),
            new Point (900,300)
        };

        Pen kalem1 = new Pen(Brushes.Red);
        Pen kalem2 = new Pen(Color.Blue);
        Pen kalem3 = new Pen(Brushes.Green, 5);
        Pen kalem4 = new Pen(Color.Yellow, 10);

        Font yazıtipi1 = new Font("Comic Sans MS", 10);
        Font yazıtipi2 = new Font("Arial", 20, FontStyle.Bold);
        Font yazıtipi3 = new Font("Times New Roman", 30, FontStyle.Bold ^ FontStyle.Italic);
        Font yazıtipi4 = new Font("Calibri", 40, FontStyle.Italic, GraphicsUnit.Millimeter);
        Font yazıtipi5 = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);

        Rectangle kare = new Rectangle(100, 100, 200, 200);
        Rectangle diktörtgen = new Rectangle(200, 200, 500, 300);

        SolidBrush kırmızıfırça = new SolidBrush(Color.Red);
        SolidBrush yeşilfırça = new SolidBrush(Color.Green);

        Image resim1 = new Image();

        resim1 = Image.FromFile("Araba.jpg");



        Image resim2 = Image.FromFile("Çiçek.jpg");

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics FormGrafik = this.CreateGraphics();

            FormGrafik.DrawString(metin, yazıtipi1, Brushes.Fuchsia, 50, 50);
            FormGrafik.DrawString(metin, yazıtipi2, kırmızıfırça, 50, 100);
            FormGrafik.DrawString(metin, yazıtipi3, yeşilfırça, nokta1);
            FormGrafik.DrawString(metin, yazıtipi4, Brushes.Blue, nokta2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, x1, y1, w, h;
            x = Width;
            y = Height;
            x1 = x / 10;
            y1 = y / 10;
            w = Convert.ToInt32(x * 0.8);
            h = Convert.ToInt32(y * 0.7);

            Graphics FormGrafik = this.CreateGraphics();

            FormGrafik.DrawRectangle(new Pen(Brushes.Red), 100, 200, 200, 300);

            Pen k1 = new Pen(Brushes.Red);

            Point p1 = new Point(100,200);

            Rectangle d1 = new Rectangle(p1, 300, 400);
            FormGrafik.DrawRectangle(k1, d1);








            FormGrafik.DrawLine(kalem2, x1, y1, x1 + w, y1 + h);
            FormGrafik.DrawLine(kalem3, x1 + w, y1, x1, y1 + h);

            FormGrafik.DrawEllipse(kalem4,
                 x1 + Convert.ToInt32(w / 4),
                 y1 + Convert.ToInt32(h / 4),

                 Convert.ToInt32(w / 2),
                 Convert.ToInt32(h / 2));

            FormGrafik.DrawPolygon(kalem1, noktalar1);
            FormGrafik.DrawCurve(kalem2, noktalar2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics FormGrafik = this.CreateGraphics();

            FormGrafik.DrawImage(resim1, 600, 50, 200, 200);
            FormGrafik.DrawImage(resim2, 600, 300, 200, 200);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pen kalem = new Pen(Brushes.Red, 2);
            Graphics FormGrafik = this.CreateGraphics();

            for (int i = 1; i < 10; i++)
            {
                FormGrafik.DrawLine(new Pen(Color.Blue, 5), Width / 10 * i, 0, Width / 10 * i, Height);
                FormGrafik.DrawLine(kalem, 0, Height / 10 * i, Width, Height / 10 * i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            resizeOlayıSayacı++;
            label2.Text = resizeOlayıSayacı.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SolidBrush fırça = new SolidBrush(Color.Red);
            HatchBrush özelfırça = new HatchBrush(HatchStyle.NarrowVertical, Color.Red, Color.Yellow );

            Graphics FormGrafik = this.CreateGraphics();
            FormGrafik.FillRectangle(fırça, 50, 50, 250, 200);

            FormGrafik.FillRectangle(özelfırça, 50, 300, 250, 200);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics FormGrafik = this.CreateGraphics();
            
            FormGrafik.DrawImage(resim1, 600, 100, 200, 200);
            FormGrafik.DrawImage(resim2, 600, 300, 200, 200);

            paintOlayıSayacı++;
            label1.Text = paintOlayıSayacı.ToString();
        }
    }
}
