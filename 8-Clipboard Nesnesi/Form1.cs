using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Clipboard.GetImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) label1.Text = "Pano içeriği metin";
            if (Clipboard.ContainsImage()) label1.Text = "Pano içeriği resim";
            if (Clipboard.ContainsFileDropList()) label1.Text = "Pano içeriği dosya listesi";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StringCollection strCol = new StringCollection();

            for (int i = 0; i < textBox3.Lines.Length; i++)
                strCol.Add(textBox3.Lines[i].ToString());

            Clipboard.SetFileDropList(strCol);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            StringCollection strCol = Clipboard.GetFileDropList();
            foreach (string str in strCol)
                listBox1.Items.Add(str);
        }
    }
}
