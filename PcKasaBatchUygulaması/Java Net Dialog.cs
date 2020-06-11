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
    public partial class Java_Net_Dialog : Form
    {
        public Java_Net_Dialog()
        {
            InitializeComponent();
        }

        private void okbutonu_Click(object sender, EventArgs e)
        {



            Process[] pro = Process.GetProcessesByName("java");
            Process[] proc = Process.GetProcessesByName("javaw");
            if (pro.Length > 0 || proc.Length > 0)
            {
                foreach (Process p in pro)
                {
                    p.Kill();
                }
                foreach (Process r in proc)
                {
                    r.Kill();
                }

            }
                string[] dosyalar = Directory.GetFiles("C:\\42Apps\\DOCSRV\\lib", "pckasa-documentServer-apps*.jar");

            if (dosyalar != null && dosyalar.Length > 0)
            {
                File.WriteAllText("C:\\42Apps\\DOCSRV\\lib\\run.txt", dosyalar[0]);
                MessageBox.Show("Sorun Düzeltildi. Pc Kasa Uygulaması Açılıyor.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            Process process = new Process();

            process.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
            process.StartInfo.FileName = "run.bat";

            process.Start();

            this.Close();

        }

        private void Java_Net_Dialog_Load(object sender, EventArgs e)
        {

        }
    }
}
