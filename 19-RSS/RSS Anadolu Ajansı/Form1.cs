using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Anadolu_Ajansı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;

            XmlTextReader xmloku = new XmlTextReader("https://www.aa.com.tr/tr/rss/default?cat=guncel");
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            while (xmloku.Read())
            {
                metin = xmloku.Name;

                if (metin == "title")
                    listBox1.Items.Add(xmloku.ReadString());
                if (metin == "description")
                    listBox2.Items.Add(xmloku.ReadString());
                if (metin == "link")
                    listBox3.Items.Add(xmloku.ReadString());
            }
            /*
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(0);

            listBox2.Items.RemoveAt(0);

            listBox3.Items.RemoveAt(0);
            listBox3.Items.RemoveAt(0);
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWebBrowser1.Silent = true;
            
            textBox1.Text = listBox2.Items[listBox1.SelectedIndex].ToString();

            axWebBrowser1.Navigate(listBox3.Items[listBox1.SelectedIndex].ToString());
        }
    }
}
