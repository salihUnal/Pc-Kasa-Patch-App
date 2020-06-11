using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcKasaPatchUygulaması
{
    public partial class Update_Progress : Form
    {
        public Update_Progress()
        {
            InitializeComponent();
            Trigger_Update_Dialog trigupd = new Trigger_Update_Dialog();
        }


        

        public void Update_Progress_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Trigger_Update_Dialog trigupd = new Trigger_Update_Dialog();
            //return ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            int i = 1;

            i++;
            if (i == 1)
            {

                //trigupd.Close();
                timer1.Stop();
                //this.Close();


            }

        }
    }
}
