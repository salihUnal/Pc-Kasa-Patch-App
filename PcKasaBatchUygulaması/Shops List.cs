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
    public partial class Shops_List : Form
    {
        public Shops_List()
        {
            InitializeComponent();
        }


       

        private void Shops_List_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'magazalarDataSet.__Magazalar_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this._Magazalar_TableAdapter.Fill(this.magazalarDataSet.@__Magazalar_);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    
    }
}
