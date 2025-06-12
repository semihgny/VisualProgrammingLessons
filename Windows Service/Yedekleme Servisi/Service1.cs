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
using System.IO;

namespace WindowsService2
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
            timer.Elapsed += new ElapsedEventHandler(Dosyayedekle);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void Dosyayedekle(object sender, ElapsedEventArgs e)
        {
            if( (DateTime.Now.Hour == 17) && (DateTime.Now.Minute == 0)  && (DateTime.Now.Second==0) )
                 File.Copy("c:\\ses.wav", "d:\\ses.wav");
        }

        protected override void OnStop()
        {
        }
    }
}
