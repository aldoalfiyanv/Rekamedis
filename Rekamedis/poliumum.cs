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
    public partial class poliumum : Form
    {
        string database = ("server = localhost; uid = root; database = rekamedis; pwd =''; ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;

        public poliumum()
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
        public void Query(String query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception kiki)
            {
                MessageBox.Show(kiki.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        public DataTable pasien()
        {
            string sql = "select*from pasien";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception rizqi)
            {
                MessageBox.Show(rizqi.Message);
            }
            diskonek();
            return dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            riwayat R = new riwayat();
            R.Show();
        }

        private void poliumum_Load(object sender, EventArgs e)
        {
            pasien();
            rmedis.Text = formpasien.SetValueFornormedis;
            nama.Text = formpasien.SetValueFornamalengkap;
            a.Text = formpasien.SetValueForjk;
        }
    }
}
