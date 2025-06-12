using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = 
                listBox1.Items[listBox1.SelectedIndex - 1].ToString();

            listBox1.SelectedIndex--;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -
                Convert.ToUInt32(toolStripTextBox1.Text);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition =
                 axWindowsMediaPlayer1.Ctlcontrols.currentPosition +
                 Convert.ToUInt32(toolStripTextBox1.Text);

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = 
                listBox1.Items[listBox1.SelectedIndex + 1].ToString();

            listBox1.SelectedIndex++;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string dosya in openFileDialog1.FileNames)
                    listBox1.Items.Add(dosya);

                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int ss, dd, nn;
                double toplamsüre, geçensüre, kalansüre;

                toplamsüre = axWindowsMediaPlayer1.currentMedia.duration;
                geçensüre = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                kalansüre = toplamsüre - geçensüre;


                ss = (int) kalansüre / 3600;

                kalansüre = kalansüre % 3600;
                dd = (int)kalansüre / 60;

                nn = (int)kalansüre % 60;

                toolStripLabel1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                toolStripLabel2.Text = String.Format("{0:00}:{1:00}:{2:00}", ss, dd, nn);
                toolStripLabel3.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            }
        }
    }
}
