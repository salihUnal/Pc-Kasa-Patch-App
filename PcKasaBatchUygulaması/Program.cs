using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace PcKasaPatchUygulaması
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool kontrol;
           
           

            Mutex mutex = new Mutex(true, "Program", out kontrol); //Örnek Mutex nesnesi oluşturalım. 
            if (kontrol == false)
            {

              
                MessageBox.Show("Bu program zaten çalışıyor.");
                return;
            }

        

          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new IntroForm());
            //Application.Run(new PcKasaUpdate());
            // Application.Run(new LoginFrm());
            Application.Run(new PcKasaUpdate());
            ///Application.Run(new ShopInterfaceFrm());
            //Application.Run(new Shops_List());
            GC.KeepAlive(mutex); //Nesneyi kaldırıyoruz.



        }




       
        private static void  Kapat_Click(object sender, EventArgs e)
        {


            Application.Exit();

        }

    }
}
