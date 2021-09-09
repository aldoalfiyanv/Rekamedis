using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekamedis
{
    public partial class riwayat : Form
    {
        public riwayat()
        {
            InitializeComponent();
        }

        private void riwayat_Load(object sender, EventArgs e)
        {

            label9.Text = formpasien.SetValueFornormedis;
            label10.Text = formpasien.SetValueFornamalengkap;
            label11.Text = formpasien.SetValueForjk;
            label12.Text = formpasien.SetValueForalamat;
            label13.Text = formpasien.SetValueForusia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
