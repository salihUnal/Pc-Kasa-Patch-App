using System;
using System.Drawing;
using System.Net.Sockets;
using System.IO;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using Tulpep.NotificationWindow;

namespace PcKasaPatchUygulaması
{

    public partial class IntroForm : Form
    {
        public char[] Message { get; private set; }
        public string Response { get; private set; }




        public IntroForm()
        {
            InitializeComponent();

            //MessageBox.Show("en üst taraf");
            //PopupNotifier popup = new PopupNotifier();
            //popup.Image = Properties.Resources.info;
            //popup.TitleText = "Pc Kasa Patch Uygulaması";
            //popup.ContentText = "Uygulama simge durumunda çalışır durumdadır.";
            //popup.TitleColor = Color.Red;
            //popup.ContentColor = Color.Black;
            //popup.BodyColor = Color.White;
            //popup.Popup();

        }

      
     


        private void Form2_Load(object sender, EventArgs e)
        {

            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;  // versiyon bilgisi
            versLbl.Text = String.Format("vers.{0}", appVersion);

           
            versLbl.BackColor = Color.FromArgb(240, 125, 0);    //COLOR versiyon etiket rengi
            tarihLbl.BackColor = Color.FromArgb(240, 125, 0);   //COLOR tarih rengi
            saatLbl.BackColor = Color.FromArgb(240, 125, 0);    //COLOR saat rengi
            AdminBtn.BackColor = Color.FromArgb(0, 87, 167);    //COLOR buton renkleri
            ShopUserBtn.BackColor = Color.FromArgb(0, 87, 167); // buton renkleri
            //BtUserBtn.BackColor = Color.FromArgb(0, 87, 167);   // buton renkleri
            ExitBtn.BackColor = Color.FromArgb(0, 87, 167);     // buton renkleri

           



        }



            private void timer1_Tick(object sender, EventArgs e)
        {


            DateTime now = DateTime.Now;
            this.saatLbl.Text = now.ToLongTimeString();
            this.tarihLbl.Text = now.ToShortDateString();
           

           
        }

  

        private void AdminBtn_Click(object sender, EventArgs e)
        {
                  
            if (Application.OpenForms["LoginFrm"] == null)
            {
                LoginFrm adminfrm = new LoginFrm();
               

                adminfrm.ShowDialog();

            }
            
        }

        private void ShopUserBtn_Click(object sender, EventArgs e)
        {
            

            if (Application.OpenForms["Shopinterface"] == null)
            {

                //this.Hide();
                Shopinterface shopfrm = new Shopinterface();
                shopfrm.ShowDialog();
                
            }

            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
         
                this.WindowState = FormWindowState.Minimized;

            if (FormWindowState.Minimized == WindowState)
            {

                

                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;
                popup.TitleText = "Pc Kasa Patch Uygulaması";
                popup.ContentText = "Uygulama simge durumunda çalışır durumdadır.";
                popup.TitleColor = Color.Red;
                popup.ContentColor = Color.Black;
                popup.BodyColor = Color.White;
                popup.Popup();
                this.ShowInTaskbar = false;


            }
                else
                {

                    miniSimge.Visible = false;
                }

            

           

           
        }

        private void BtUserBtn_Click(object sender, EventArgs e)
        {
            
            //if (Application.OpenForms["Technic_Panel"] == null)
            //{
            //    Technic_Panel technicfrm = new Technic_Panel();
            //    technicfrm.ShowDialog();

            //}
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (Application.OpenForms["introForm"] == null)
            {

               

                this.ShowInTaskbar = true;

                miniSimge.Visible = false;
                WindowState = FormWindowState.Normal;


            }
            else
            { }

               

        }

        private void KapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
