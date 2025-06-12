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

namespace Web_Tarayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Uri adres = new Uri("http://" + toolStripComboBox1.Text);
            toolStripComboBox1.Text = adres.ToString();
            webBrowser1.Navigate(adres);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void baskıÖnizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        private void geçmişiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader dosya = new StreamReader("adresler.txt");
            string satır;
            while ((satır = dosya.ReadLine()) != null)
                toolStripComboBox1.Items.Add(satır);
            dosya.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter dosya = new StreamWriter("adresler.txt");
            foreach (var item in toolStripComboBox1.Items)
            {
                dosya.WriteLine(item.ToString());
            }
            dosya.Close();
        }

        private void toolStripComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) toolStripButton4_Click(sender, e);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);

            toolStripComboBox1.Text = webBrowser1.Url.ToString();

        }

    }
}
