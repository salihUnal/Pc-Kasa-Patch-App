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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void sucOkBtn_Click(object sender, EventArgs e)
        {

            Trigger_Update_Dialog trigupd = new Trigger_Update_Dialog();
            trigupd.Close();
            
            this.Close();
        }
    }
}
