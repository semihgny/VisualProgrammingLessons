using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService3
{
    public partial class Service3 : ServiceBase
    {
        public Service3()
        {
            InitializeComponent();
        }

        FileSystemWatcher izleyici;
        string klasorYolu = @"D:\Izlenecek Klasor";
        string logYolu = @"D:\log.txt";


        protected override void OnStart(string[] args)
        {
            if (!Directory.Exists(klasorYolu))
                Directory.CreateDirectory(klasorYolu);

            if (!Directory.Exists(Path.GetDirectoryName(logYolu)))
                Directory.CreateDirectory(Path.GetDirectoryName(logYolu));

            izleyici = new FileSystemWatcher(klasorYolu);

            izleyici.Created += DosyaOlusturuldu;
            izleyici.Deleted += DosyaSilindi;
            izleyici.Renamed += DosyaAdıDeğişti;

            izleyici.EnableRaisingEvents = true;

            LogYaz("Servis başlatıldı.");

        }

        private void DosyaOlusturuldu(object sender, FileSystemEventArgs e)
        {
            LogYaz($"Yeni dosya: {e.Name}, Oluşturulma zamanı: {DateTime.Now}");
        }

        private void DosyaSilindi(object sender, FileSystemEventArgs e)
        {
            LogYaz($"Silinen dosya: {e.Name}, Silme zamanı: {DateTime.Now}");
        }

        private void DosyaAdıDeğişti(object sender, FileSystemEventArgs e)
        {
            LogYaz($"Yeniden adlandırıldı: {e.Name}, Adlandırma zamanı: {DateTime.Now}");
        }


        private void LogYaz(string mesaj)
        {
            File.AppendAllText(logYolu, $"{DateTime.Now}: {mesaj}{Environment.NewLine}");
        }


        protected override void OnStop()
        {
            izleyici.Dispose();
            LogYaz("Servis durduruldu.");

        }
    }
}
