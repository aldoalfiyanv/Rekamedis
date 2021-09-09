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
    public partial class Form1 : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;

        public Form1()
        {
            InitializeComponent();
            
        }
        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void diskonek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about abt = new about();
            abt.Show();
            this.Hide();
        }
        
        private void tambahPenggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user pengguna = new user();
            pengguna.Show();
            this.Hide();

        }
    }
}
