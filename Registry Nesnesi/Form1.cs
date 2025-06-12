using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry_Nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey anahtar = Registry.LocalMachine.OpenSubKey("Software\\microsoft\\windows nt\\currentversion");

                label1.Text = anahtar.GetValue("ProductName").ToString();
                label2.Text = anahtar.GetValue("CurrentVersion").ToString();

                anahtar = Registry.LocalMachine.OpenSubKey("Software\\microsoft\\Internet Explorer\\");
                label3.Text = anahtar.GetValue("Version").ToString();

                anahtar = Registry.LocalMachine.OpenSubKey("Software\\microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe\\");
                label4.Text = anahtar.GetValue("Path").ToString();
            }
            catch
            {
                MessageBox.Show("Anahtar okunamadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.CreateSubKey("Software\\Bizim Program\\Çeşitli");

            anahtar.SetValue("Ad Soyad", "Mustafa İlhan", RegistryValueKind.String);
            anahtar.SetValue("Yaş", 22, RegistryValueKind.DWord);
            anahtar.SetValue("Kayıt Tarihi", DateTime.Now.ToString(), RegistryValueKind.String);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            RegistryKey anahtar = Registry.LocalMachine.OpenSubKey("Software\\microsoft\\windows nt\\currentversion");

            foreach (string değeradı in anahtar.GetValueNames())
                listBox1.Items.Add(değeradı);

            for (i = 0; i < anahtar.ValueCount; i++)
                listBox2.Items.Add(anahtar.GetValue(listBox1.Items[i].ToString()));

        }

        private void button4_Click(object sender, EventArgs e)
        {

            RegistryKey anahtar = Registry.LocalMachine.OpenSubKey("Software");

            foreach (string değeradı in anahtar.GetSubKeyNames())
                listBox3.Items.Add(değeradı);

        }


        private void button5_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software\\microsoft\\Notepad");
            listBox4.Items.Add("Sol: " + anahtar.GetValue("iWindowPosX").ToString());
            listBox4.Items.Add("Üst: " + anahtar.GetValue("iWindowPosY").ToString());
            listBox4.Items.Add("Genişlik: " + anahtar.GetValue("iWindowPosDX").ToString());
            listBox4.Items.Add("Yükseklik: " + anahtar.GetValue("iWindowPosDY").ToString());

//            listBox4.Items.Add("Yazıtipi adı: " + anahtar.GetValue("lfFaceName").ToString());
  //          listBox4.Items.Add("Yazıtipi boyutu: " + ((int)anahtar.GetValue("iPointSize") / 10).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software\\Bizim Program\\Özel");
                label5.Text = anahtar.GetValue("Çalışma sayısı").ToString();
                label6.Text = anahtar.GetValue("Son çalışma zamanı").ToString();
            }
            catch
            {
                RegistryKey anahtar = Registry.CurrentUser.CreateSubKey("Software\\Bizim Program\\Özel");
                anahtar.SetValue("Çalışma sayısı", 0, RegistryValueKind.DWord);
                anahtar.SetValue("Son çalışma zamanı", DateTime.Now.ToString(), RegistryValueKind.String);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            int çalışmasayısı;
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software\\Bizim Program\\Özel", true);

            çalışmasayısı = Convert.ToInt32(anahtar.GetValue("Çalışma sayısı").ToString());
            çalışmasayısı++;
            anahtar.SetValue("Çalışma sayısı", çalışmasayısı, RegistryValueKind.DWord);
            anahtar.SetValue("Son çalışma zamanı", DateTime.Now.ToString(), RegistryValueKind.String);
        }
    }
}
