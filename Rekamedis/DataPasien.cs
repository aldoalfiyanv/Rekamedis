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
    public partial class DataPasien : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;

        public DataPasien()
        {
            InitializeComponent();
            pasien();
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
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            diskonek();
            return dt;
        }



        public void Query(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
            finally
            {
                koneksi.Close();
            }

        }
        public void lihat()
        {
            DataTable dt = new DataTable();
            try
            {
                konek();
                string cari = "select*from pasien where no_rmedis = '" + textBox1.Text + "' "+"'||'"+"nama_depan='"+textBox1.Text+"'"+"'||'"+"nama_lengkap='"+textBox1.Text+"'"+"'||'"+"jenis_kelamin='"+textBox1.Text+"'";
                cmd = new MySqlCommand(cari, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                diskonek();
                MessageBox.Show("Pencarian Berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception rizqi3)
            {
                MessageBox.Show(rizqi3.Message);
            }
        }
        private void DataPasien_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lihat();
            pasien();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrasips RPS = new registrasips();
            RPS.Show();
            this.Hide();
        }
    }
}
