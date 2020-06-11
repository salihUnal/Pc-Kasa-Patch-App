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
using System.Threading;
using System.Deployment.Application;


namespace PcKasaPatchUygulaması
{

    public partial class PcKasaUpdate : Form
    {

      
        UpdateClass forupdate = new UpdateClass();
        //UpdateCheckInfo bilgi;
        IntroForm introfrm = new IntroForm();
        Trigger_Update_Dialog triggerUpdatefrm = new Trigger_Update_Dialog();
        


        public PcKasaUpdate()
        {
            InitializeComponent();
        }

        [Obsolete]
        public void Form1_Load(object sender, EventArgs e)
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



        private void button1_Click_1(object sender, EventArgs e) //// pc kasa programı (java) ları kapatmak için kullanılan kod
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

            

            MessageBox.Show("Pc Kasa Kapatıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

       

        private void button1_Click_2(object sender, EventArgs e)   ////pc kasa çalıştırma kodu
        {
            Process process = new Process();

            process.StartInfo.WorkingDirectory = @"C:\42Apps\PCKASA\";
            process.StartInfo.FileName = "run.bat";

            process.Start();


            MessageBox.Show("Pc Kasa Açılıyor", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      

        private void BtnDb_Click(object sender, EventArgs e)   //// pc kasa db dosyası silme kodu
        {

            if (Application.OpenForms["Pc_Kasa_Dialog"] == null)
            {
                Pc_Kasa_Dialog pckasafrm = new Pc_Kasa_Dialog();

                pckasafrm.ShowDialog();

            }

        }

        private void BtnDosyaKontrol_Click(object sender, EventArgs e)  //// lib dizinindeki  dosya sayısını görüntüleme
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


            
        }

        private void BtnTrigger_Click(object sender, EventArgs e)    ////trigger update işlem kodu
        {



            if (Application.OpenForms["Trigger_Update_Dialog"] == null)
            {

                triggerUpdatefrm.ShowDialog();

            }


           

        }

        private void button1_Click_3(object sender, EventArgs e)
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
                   

                    triggerUpdatefrm.ShowDialog();

                }

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

       


        private void uygulamayıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

     

        private void uygulamaBtnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //ApplicationDeployment, güncelleştirme bilgilerine erişmemizi sağlayacak olan bir sınıftır.
            //    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            //    //CheckForDetailedUpdate metodu ile güncelleme var mı? yok mu? kontrol ediyoruz.
            //    UpdateCheckInfo info = ad.CheckForDetailedUpdate();
            //    if (info.UpdateAvailable)
            //    {
            //        if (DialogResult.Yes == MessageBox.Show($@"Şu anki versiyonunuz: {ad.CurrentVersion.ToString()} Yeni versiyon: {info.AvailableVersion.ToString()} kullanılabilir durumda. Yüklemek istiyor musunuz?",
            //            "Bilgi",
            //            MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Information,
            //            MessageBoxDefaultButton.Button1))
            //        {
            //            if (ad.Update())
            //            {
            //                MessageBox.Show("Program Başarıyla Güncellendi. Şimdi yeniden Başlatılacak.");
            //                Application.Restart();
            //            }
            //            else
            //                MessageBox.Show("Güncelleme Sırasında Hata Oluştu");
            //        }
            //    }
            //    else
            //        MessageBox.Show("Güncelleme bulunmamaktadır.");
            //}
            //catch
            //{
            //    MessageBox.Show("Sunucuyla bağlantı sağlanamadı.");
            //}

            

            UpdateCheckInfo info;
            if (ApplicationDeployment.IsNetworkDeployed)
            {

                MessageBox.Show("Uygulamanın yeni sürümü şu anda indirilemiyor.\n\nLütfen ağ bağlantınızı kontrol edin veya daha sonra tekrar deneyin.");
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("Uygulamanın yeni sürümü şu anda indirilemiyor.\n\nLütfen ağ bağlantınızı kontrol edin veya daha sonra tekrar deneyin. Error: " + dde.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Uygulamanın yeni bir sürümü kontrol edilemiyor. Güncelleme dağıtımı bozuk. Lütfen uygulamayı yeniden yayınlayın ve tekrar deneyin. Error: " + ide.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("Bu uygulama güncellenemiyor. Güncellenebilir bir uygulama değil. Error: " + ioe.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (info.UpdateAvailable)
                {
                    if (MessageBox.Show("Daha yeni bir sürüm mevcuttur. Şimdi güncellemek ister misiniz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ad.Update();
                            Application.Restart();
                        }
                    catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("En son sürüme sahipsiniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void admCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            introfrm.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.saatLbl.Text = now.ToLongTimeString();
            this.tarihLbl.Text = now.ToShortDateString();
        }

        

        private void admshoplistBtn_Click(object sender, EventArgs e)
        {

           

            if (Application.OpenForms["Shops_List"] == null)
            {

                Shops_List shoplst = new Shops_List();

                //this.Hide();
                ////yeni.TopMost = true;
                shoplst.ShowDialog();

            }


        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supportBtn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["support_info"] == null)
            {

                support_info supportInfo = new support_info();

                supportInfo.ShowDialog();

            }

          
        }

        private void appsetupBtn_Click(object sender, EventArgs e)
        {
            //string localFile = @"C:\42Apps";
            //string kaynakFile = @"\\10.10.97.121\pckasabatch\42Apps";
            //string moveFile = @"C:\42Apps(old)";
            //string cacertsLocal = @"C:\Program Files\Java\jre7\lib\security\cacerts";
            //string cacertsKaynak = @"\\10.10.97.121\pckasabatch\Pc Kasa Kurulum\cacerts";
            //bool dizinverisi = Directory.Exists(localFile);
            //if (localFile != null && localFile.Length >0)
            //{
            //    int i = 0;

            //    //Directory.Move(@"C:\42Apps", "42Apps(old" +i++ +")");
            //    File.Copy(kaynakFile, localFile);
            //    File.Copy(cacertsKaynak, cacertsLocal);
            //}

            //else { }


            //string localDirectory = @"C:\"; // no need to get the folder name as it will be the same than the source one
            //string sourceDirectory = @"\\10.10.97.121\pckasabatch\Pc Kasa Kurulum\42Apps";
            //string directoryName = Path.GetDirectoryName(sourceDirectory); // getting only the name of the folder

            //string tempDirPath = Path.Combine(localDirectory, directoryName); // creating a temp variable which will be used to check if the folder exists
            //string dirPath = tempDirPath; // saving for the renaming
            //string tempDirName = directoryName;

            //int inc = 0;
            //int i = 0;
            //// we create a loop to check the first non existing folder name
            //while(Directory.Exists(tempDirPath))
            //{
            //    tempDirName = $"{directoryName}(old{i})";
            //    tempDirPath = Path.Combine(localDirectory, directoryName);
            //    i++;
            //}

            //if (inc != 0) // if the folder has to be renames
            //{
            //    Directory.Move(dirPath, tempDirPath);
            //}

            //Directory.Move(sourceDirectory, dirPath);


            string localcacert = @"C:\Program Files\Java\jre7\lib\security"; // no need to get the folder name as it will be the same than the source one
            string sourceCacert = @"\\10.10.97.121\pckasabatch\Pc Kasa Kurulum\cacerts";
            string directoryName = Path.GetDirectoryName(sourceCacert); // getting only the name of the folder

            string tempDirPath = Path.Combine(localcacert, directoryName); // creating a temp variable which will be used to check if the folder exists
            string dirPath = tempDirPath; // saving for the renaming
            string tempDirName = directoryName;

            int inc = 0;
            int i = 0;
            // we create a loop to check the first non existing folder name
            while (Directory.Exists(tempDirPath))
            {
                tempDirName = $"{directoryName}(old{i})";
                tempDirPath = Path.Combine(localcacert, directoryName);
                i++;
            }

            if (inc != 0) // if the folder has to be renames
            {
                Directory.Move(dirPath, tempDirPath);
            }

            Directory.Move(sourceCacert, dirPath);
        }
    }
}
     

                   

    
       