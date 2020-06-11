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
    public partial class Technic_Panel : Form
    {
        public Technic_Panel()
        {
            InitializeComponent();
        }

        private void Technic_Panel_Load(object sender, EventArgs e)
        {
            kurulum2.Visible = false;
            soruncoz2.Visible = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
          
          
        }

      

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kurulum1_Load(object sender, EventArgs e)
        {

        }

        private void Kurulum1_Load_1(object sender, EventArgs e)
        {

        }

        private void Btnkurulum_Click(object sender, EventArgs e)
        {
            kurulum2.Visible = true;
            soruncoz2.Visible = false;
            
        }

        private void Soruncoz1_Load(object sender, EventArgs e)
        {

        }

        private void Btnsoruncoz_Click(object sender, EventArgs e)
        {
            kurulum2.Visible = false;
            soruncoz2.Visible = true;
        }
    }
}
