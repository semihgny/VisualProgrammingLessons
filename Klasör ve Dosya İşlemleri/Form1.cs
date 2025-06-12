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

namespace Klasör_ve_Dosya_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("Klasör " + Directory.GetCreationTime(textBox1.Text) + " tarihinde oluşturulmuş.");
            }
            else
            {
                Directory.CreateDirectory(textBox1.Text);
                MessageBox.Show("Klasör oluşturuldu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Delete(textBox1.Text, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo kaynakklasör = new DirectoryInfo(textBox1.Text);
            DirectoryInfo hedefklasör = new DirectoryInfo(textBox2.Text);

            if (!hedefklasör.Exists) Directory.CreateDirectory(textBox2.Text);
            foreach (FileInfo dosya in kaynakklasör.GetFiles())
                dosya.CopyTo(Path.Combine(hedefklasör.ToString(), dosya.Name), true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Directory.Move(textBox1.Text, textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Directory.Move(textBox1.Text, textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.Create(textBox4.Text).Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete(textBox4.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.Copy(textBox4.Text, textBox5.Text + Path.GetFileName(textBox4.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.Move(textBox4.Text, textBox5.Text + Path.GetFileName(textBox4.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            File.Move(textBox4.Text, Path.GetDirectoryName(textBox4.Text) + "\\" + textBox5.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = File.GetCreationTime(textBox3.Text).ToString();
            label2.Text = File.GetLastWriteTime(textBox3.Text).ToString();
            label3.Text = File.GetLastAccessTime(textBox3.Text).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            File.SetCreationTime(textBox3.Text, Convert.ToDateTime(dateTimePicker1.Value));
            File.SetLastWriteTime(textBox3.Text, Convert.ToDateTime(dateTimePicker2.Value));
            File.SetLastAccessTime(textBox3.Text, Convert.ToDateTime(dateTimePicker3.Value));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FileAttributes attributes = File.GetAttributes(textBox3.Text);

            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                checkBox2.Checked = true;
            else checkBox2.Checked = false;

            if ((attributes & FileAttributes.System) == FileAttributes.System)
                checkBox3.Checked = true;
            else checkBox3.Checked = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FileAttributes attributes = File.GetAttributes(textBox3.Text);

            if (checkBox1.Checked)
                File.SetAttributes(textBox3.Text, attributes | FileAttributes.Hidden);
            else
                File.SetAttributes(textBox3.Text, attributes ^ FileAttributes.Hidden);


            if (checkBox2.Checked)
                File.SetAttributes(textBox3.Text, attributes | FileAttributes.ReadOnly);
            else
                File.SetAttributes(textBox3.Text, attributes ^ FileAttributes.ReadOnly);


            if (checkBox3.Checked)
                File.SetAttributes(textBox3.Text, attributes | FileAttributes.System);
            else
                File.SetAttributes(textBox3.Text, attributes ^ FileAttributes.System);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            var yığın = new Stack<TreeNode>();
            var kökklasör = new DirectoryInfo(textBox1.Text);
            var düğüm = new TreeNode(kökklasör.Name) { Tag = kökklasör };

            yığın.Push(düğüm);

            while (yığın.Count > 0)
            {
                var geçerlidüğüm = yığın.Pop();
                var klasörbilgisi = (DirectoryInfo)geçerlidüğüm.Tag;

                foreach (var klasör in klasörbilgisi.GetDirectories())
                {
                    var altklasördüğümü = new TreeNode(klasör.Name) { Tag = klasör };
                    geçerlidüğüm.Nodes.Add(altklasördüğümü);
                    yığın.Push(altklasördüğümü);
                }

                foreach (var file in klasörbilgisi.GetFiles())
                    geçerlidüğüm.Nodes.Add(new TreeNode(file.Name));
            }

            treeView1.Nodes.Add(düğüm);
            treeView1.ExpandAll();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string[] klasörler = Directory.GetDirectories(textBox1.Text);
            string[] dosyalar = Directory.GetFiles(textBox1.Text, "*.*");

            listBox1.Items.Clear();
            foreach (string klasör in klasörler)
            {
                listBox1.Items.Add(klasör);
            }

            foreach (string dosya in dosyalar)
            {
                listBox1.Items.Add(dosya);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label4.Text = Path.GetFullPath(textBox6.Text);
            label5.Text = Path.GetPathRoot(textBox6.Text);
            label6.Text = Path.GetDirectoryName(textBox6.Text);
            label7.Text = Path.GetFileName(textBox6.Text);
            label8.Text = Path.GetFileNameWithoutExtension(textBox6.Text);
            label9.Text = Path.GetExtension(textBox6.Text);
            label10.Text = Path.Combine(label5.Text, label6.Text, label7.Text);
            label11.Text = Path.GetRandomFileName();
            label12.Text = Path.GetTempPath();
        }
    }
}
