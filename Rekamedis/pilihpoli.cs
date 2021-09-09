using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rekamedis
{
    public partial class pilihpoli : Form
    {
        

        public pilihpoli(string jabatan)
        {
            InitializeComponent();
            if (jabatan == "SUPER ADMIN")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }

            else if (jabatan == "POLI GIGI")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (jabatan == "POLI REMAJA")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (jabatan == "POLI BALITA")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (jabatan == "POLI UMUM")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (jabatan == "POLI KIA")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
            }
            else 
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 utama = new Form1();
            utama.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formpasien PS = new formpasien();
            PS.Show();
            this.Hide();
            
        }

        private void pilihpoli_Load(object sender, EventArgs e)
        {

        }
    }
}
