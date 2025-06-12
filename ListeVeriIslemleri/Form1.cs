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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = listBox1.SelectedIndex.ToString();
            //label2.Text = listBox1.SelectedItem.ToString();
            //label2.Text = listBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedIndex.ToString();
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(listBox1.SelectedIndex, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(textBox2.Text);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            
            int adet = listBox1.Items.Count;
            for (int i = 0; i < adet; i++) 
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                comboBox1.Items.Add(listBox1.Items[i]);
            
            int adet = listBox1.Items.Count;
            for (int i = 0; i < adet; i++)
                listBox1.Items.RemoveAt(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] liste = new string[listBox1.Items.Count];

            listBox1.Items.CopyTo(liste, 0);
            File.WriteAllLines("d:\\dosya.txt", liste);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] liste = new string[listBox1.Items.Count];
            liste = File.ReadAllLines("d:\\dosya.txt");
            listBox1.Items.AddRange(liste);

            
        }
    }
}
