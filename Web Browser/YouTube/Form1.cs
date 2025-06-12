using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string url;
        public string videoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(url);
                
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            url = textBox1.Text;
            webBrowser1.DocumentText = String.Format("<meta http-equiv=\"X-UA-Compatible\" Content=\"IE=Edge\" />" +
                "\n<iframe\nwidth=\"{0}\"\nheight=\"{1}\"\nsrc=\"https://www.youtube.com/embed/{2}?autoplay=1\"" +
                "\nframeborder=\"0\" \nallow=\"acceleromter; autplay; encrypt-media; gryscope; picture-in-picture\" " +
                "allowfullscreen>\n</iframe>", Width-300, Height-300, videoID);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                textBox1.Visible = !textBox1.Visible;
                button1.Visible = !button1.Visible;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = videoID.ToString();

        }
    }
}
