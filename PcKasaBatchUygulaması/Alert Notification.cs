using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PcKasaPatchUygulaması
{
    public class Alert_notification : IDisposable
    {


        Timer timer1 = new Timer();
        Label label1 = new Label();

        void LabelHolder(Form frm)
        {
            timer1.Interval = 3000;
            timer1.Enabled = true;
            label1 = new Label()
            {

                AutoSize = false ,
                Width = 250 ,
                Height = 50 ,
                ForeColor =     Color.White,
                TextAlign =ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.MiddleRight,
                Location = new Point(frm.Width / 2, frm.Height / 2)


            };

            frm.Controls.Add(label1);
            timer1.Tick += Timer_Tick;

        }

        public void Save (Form frm, string mesaj)
        {
            MessageBox.Show("3");

            label1.BackColor = Color.Green;
            label1.Text = mesaj;
           // label1.Image = PcKasaPatchUygulaması.Properties.Resources.info;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            MessageBox.Show("4");
            timer1.Start();
            label1.Visible = false;

        }

        public void Dispose()
        {
            this.Dispose();

        }
    }
}
