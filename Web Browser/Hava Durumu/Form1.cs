using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hava_Durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kod;

            kod = "<img src=\"http://www.mgm.gov.tr/sunum/tahmin-show-2.aspx?m=" + listBox1.Text + "&basla=1&bitir=5&rC=c1f&rZ=def\" style=\"width:400px; height:100px;\" alt=\"" + listBox1.Text + "\" />";

            webBrowser1.DocumentText = kod;

            textBox1.Text = kod;
        }
    }
}
