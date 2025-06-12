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

namespace RSS_TCMB_Döviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string USD, EUR, GBP;

        private void button1_Click(object sender, EventArgs e)
        {
            string bugün = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmldoc = new XmlDocument();
            xmldoc.Load(bugün);

            string tarih =  xmldoc.SelectSingleNode("Tarih_Date").Attributes["Tarih"].Value;

            USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;

            textBox1.Text = tarih;

            textBox2.Text = USD;
            textBox3.Text = EUR;
            textBox4.Text = GBP;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToSingle(USD) * Convert.ToSingle(textBox5.Text) / 10000);
        }

    }
}
