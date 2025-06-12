using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belge_Yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = pageSetupDialog1.ShowDialog();

            if (cevap == DialogResult.OK) printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;

            label1.Text = pageSetupDialog1.PageSettings.PaperSize.Width.ToString();
            label2.Text = pageSetupDialog1.PageSettings.PaperSize.Height.ToString();
            if (pageSetupDialog1.PageSettings.Landscape) label3.Text = "Yatay";
            else label3.Text = "Dikey";

            //label1.Text = printDocument1.DefaultPageSettings.PaperSize.Width.ToString();
            //label2.Text = printDocument1.DefaultPageSettings.PaperSize.Height.ToString();

            /*
            if (cevap == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.PaperSize = pageSetupDialog1.PageSettings.PaperSize;
                printDocument1.DefaultPageSettings.Landscape = pageSetupDialog1.PageSettings.Landscape;
                printDocument1.DefaultPageSettings.Margins.Top = pageSetupDialog1.PageSettings.Margins.Top;
                printDocument1.DefaultPageSettings.Margins.Bottom = pageSetupDialog1.PageSettings.Margins.Bottom;
                printDocument1.DefaultPageSettings.Margins.Left = pageSetupDialog1.PageSettings.Margins.Left;
                printDocument1.DefaultPageSettings.Margins.Right = pageSetupDialog1.PageSettings.Margins.Right;
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = printDialog1.ShowDialog();
            if (cevap == DialogResult.OK) printDocument1.Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = pageSetupDialog1.PageSettings.PaperSize.Width.ToString();
            label2.Text = pageSetupDialog1.PageSettings.PaperSize.Height.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font yazıtipi1 = new Font("Times New Roman", 12, FontStyle.Bold ^ FontStyle.Italic);
            Font yazıtipi2 = new Font("Arial", 20, FontStyle.Italic ^ FontStyle.Underline);

            Pen kalem1 = new Pen(Color.Red, 5);
            Pen kalem2 = new Pen(Brushes.Blue, 10);

            SolidBrush fırça1 = new SolidBrush(Color.Green);
            SolidBrush fırça2 = new SolidBrush(Color.Blue);

            Point nokta1 = new Point(100, 100);
            Point nokta2 = new Point(100, 200);

            Rectangle dörtgen = new Rectangle(100,100,200,200);
            
            Image resim = Image.FromFile("araba.jpg");

            e.Graphics.DrawString("Mustafa", yazıtipi1, fırça1, nokta1);
            e.Graphics.DrawString("İlhan", yazıtipi2, fırça2, nokta2);

            e.Graphics.DrawRectangle(kalem1, dörtgen);
            e.Graphics.DrawEllipse(kalem2, 400, 150, 300, 200);

            e.Graphics.DrawImage(resim, 500, 500, 200, 200);

            e.Graphics.DrawRectangle(kalem1, 0, 0,
                pageSetupDialog1.PageSettings.PaperSize.Width,
                pageSetupDialog1.PageSettings.PaperSize.Height);

            e.Graphics.DrawString(richTextBox1.Text,
                richTextBox1.Font, Brushes.Black,
                new Rectangle(100, 700, pageSetupDialog1.PageSettings.PaperSize.Width - 200, pageSetupDialog1.PageSettings.PaperSize.Height - 200));
        }
    }
}
