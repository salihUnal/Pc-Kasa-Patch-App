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
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Management;

namespace PcKasaPatchUygulaması
{
    public partial class Pc_Kasa_Dialog : Form
    {
        public Pc_Kasa_Dialog()
        {
            InitializeComponent();
        }

        private void okbutonu_Click(object sender, EventArgs e)
        {
            Process[] pro = Process.GetProcessesByName("java");
            Process[] proc = Process.GetProcessesByName("javaw");
            if (pro.Length > 0 || proc.Length > 0)
            {

                foreach (Process r in proc)
                {
                    r.Kill();
                }

                foreach (Process p in pro)
                {
                    p.Kill();
                }



                string db_yolu = @"C:\42Apps\PCKASA\db\teknosa.db";
                if (System.IO.File.Exists(db_yolu))
                {

                    System.IO.File.Delete(db_yolu);

                }

                else
                {

                    MessageBox.Show("Dosya Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            Process process = new Process();

            process.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
            process.StartInfo.FileName = "run.bat";

            process.Start();


            MessageBox.Show("Pc Kasa Açılıyor. Giriş yaparak verilerin güncellenmesini bekleyin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}
