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
    public partial class Form2 : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;
        string password, jabatan;

        public Form2()
        {
            InitializeComponent();
            
        }
        public static string SetValueForJABATAN = "";


        private void label2_Click(object sender, EventArgs e)
        {

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
        public void Query(string query)
        {
            koneksi = new MySqlConnection(database);
            konek();
            cmd = new MySqlCommand(query, koneksi);
            adp = new MySqlDataAdapter(cmd);
            read = cmd.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {
                password = read.GetString("sandi");
                jabatan = read.GetString("jabatan");

            }
            diskonek();
        }
        
        private void login_Click(object sender, EventArgs e)
        {
            Query("select * from pengguna where nama_user = '" + username.Text + "';");
            if (password == pss.Text)
            {
                SetValueForJABATAN = level.Text;
                pilihpoli PP = new pilihpoli(jabatan);
                PP.Show();
                this.Hide();
                
                
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form1 utama = new Form1();
                utama.Show();
                this.Hide();
            }
        }

        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
