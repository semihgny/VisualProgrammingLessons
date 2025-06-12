using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Media;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        
        protected override void OnStart(string[] args)
        {
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(HerSaniyeÇalışacakKod);
            timer.Enabled = true;
        }

        private void HerSaniyeÇalışacakKod(object sender, ElapsedEventArgs e)
        {
            if(DateTime.Now.Second == 30)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "c:\\ses.wav";
                player.Play();
            }

        }

        protected override void OnStop()
        {

        }
    }
}
