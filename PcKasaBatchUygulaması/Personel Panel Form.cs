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
using System.Security.Principal;


namespace PcKasaPatchUygulaması
{
    public partial class Shopinterface : Form
    {
        public Shopinterface()
        {
            InitializeComponent();


        }

        IntroForm intro = new IntroForm();


        private void Form5_Load(object sender, EventArgs e)
        {


            // IP Adress sınıfında olusturduğumuz örneğimize DNS deki ip            
            // adreslerini alıyoruz ve bunları listemize yadırıyoruz

            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }



            string pcuser = Environment.UserName;
            string bilgisayarAdi = Dns.GetHostName();
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
           

            magazalabel.Text = pcuser + Environment.NewLine + ipAdresi + Environment.NewLine + mac;

          
        }





        private void BtnDb_Click(object sender, EventArgs e)
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

			if (Application.OpenForms["Pc_Kasa_Dialog"] == null)
			{
				Pc_Kasa_Dialog pckasafrm = new Pc_Kasa_Dialog();

				pckasafrm.ShowDialog();

			}
		}

        private void BtnDosyaKontrol_Click(object sender, EventArgs e)
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
                MessageBox.Show("Sorun Düzeltildi. Pc Kasa Uygulaması Açılıyor. Lütfen giriş yaparak kontrol edin. " +
                    "Sorun devam ediyor ise Pc kasa destek hattını arayabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



            Process process = new Process();

            process.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
            process.StartInfo.FileName = "run.bat";

            process.Start();





        }

        private void PcKasaDosyaKontrolBtn_Click(object sender, EventArgs e)
        {

                      
            string[] dosyalar = Directory.GetFiles(@"C:\42Apps\PCKASA\lib");
            string onay;
            onay = "Güncelleme Yapacak Mısınız?";


            DialogResult secim = new DialogResult();   //// satır sırasını değiştirmemn gerek
            secim = MessageBox.Show(onay + "\n" + "59 adet Dosya olması gerekiyor!!!  Dizindeki dosya Adeti =  " + dosyalar.Length, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (secim == DialogResult.Yes)
            {

                if (Application.OpenForms["Trigger_Update_Dialog"] == null)
                {
                    Trigger_Update_Dialog triggerUpdatefrm = new Trigger_Update_Dialog();

                    triggerUpdatefrm.ShowDialog();

                }

            }
        }

        private void BtnPcKasa_Click(object sender, EventArgs e)
        {


            Process process = new Process();

            process.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
            process.StartInfo.FileName = "run.bat";

            process.Start();


            MessageBox.Show("Pc Kasa Açılıyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnPcKasaKapat_Click(object sender, EventArgs e)
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

                MessageBox.Show("Pc Kasa Kapatıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ScannerFrm"] == null)
            {

                ScannerFrm scan = new ScannerFrm();

                scan.ShowDialog();

            }

        }

        private void PersonBtnTrigger_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Trigger_Update_Dialog"] == null)
            {
                Trigger_Update_Dialog triggerUpdatefrm = new Trigger_Update_Dialog();

                triggerUpdatefrm.ShowDialog();

            }

        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.saatLbl.Text = now.ToLongTimeString();
            this.tarihLbl.Text = now.ToShortDateString();
        }

        private void shpshoplistBtn_Click(object sender, EventArgs e)
        {

            Shops_List shoplst = new Shops_List();

            //this.Hide();
            ////yeni.TopMost = true;
            shoplst.ShowDialog();
        }

        private void shpCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //intro.Show();
        }

        private void supportBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["support_info"] == null)
            {

                support_info supportInfo = new support_info();

                supportInfo.ShowDialog();

            }
        }
    }

}

      
