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
using System.Threading;
using System.Runtime.InteropServices;

namespace PcKasaPatchUygulaması
{
    public partial class Trigger_Update_Dialog : Form
    {

               
        public Trigger_Update_Dialog()
        {
            
            InitializeComponent();
            Success suc = new Success();
        }

       



        public void okbutonu_Click(object sender, EventArgs e)
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

                }


                //progressBar1.Visible = true;


                int s = 10000;
                System.Threading.Thread.Sleep(s);



                string update_db_yolu = @"C:\42Apps\APPUPD\db\updater.db3";
                if (System.IO.File.Exists(update_db_yolu))
                {

                    System.IO.File.Delete(update_db_yolu);



                }

                else
                {

                    MessageBox.Show("Dosya Bulunamadı", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }





                Process process = new Process();

                process.StartInfo.WorkingDirectory = @"C:\42Apps\APPUPD\";
                process.StartInfo.FileName = "run.bat";
                process.Start();


                int y = 25000;
                System.Threading.Thread.Sleep(y);

                HttpWebRequest istek = (HttpWebRequest)WebRequest.Create("http://localhost:12021/triggerUpdate");

                istek.Method = "GET";
                istek.Timeout = 1000000;

                HttpWebResponse yanit = (HttpWebResponse)istek.GetResponse();

                string responseString = new StreamReader(yanit.GetResponseStream()).ReadToEnd();


                suc.ShowDialog();

            //MessageBox.Show("Update tamamlandı ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process processpckasa = new Process();

                processpckasa.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
                processpckasa.StartInfo.FileName = "run.bat";

                processpckasa.Start();


                Close();
             

          


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okbutonu_KeyDown(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                MessageBox.Show("Enter tuşuna basmayın");

                // burada ne yapmak istiyorsan yap işte.

            }
        }

        private void Trigger_Update_Dialog_Load(object sender, EventArgs e)
        {

            


        }

    }
}
