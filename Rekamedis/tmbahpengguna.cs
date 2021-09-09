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
    public partial class tmbahpengguna : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;

        public tmbahpengguna()
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
        public DataTable pengguna()
        {
            string sql = "select * from pengguna";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
            }
            catch (Exception kiki)
            {
                MessageBox.Show(kiki.Message);
            }
            diskonek();
            return dt;
        }
        public void Query(string query)
        {
            konek();
            cmd = new MySqlCommand(query, koneksi);
            adp = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Query("insert into pengguna values('" + this.iduser.Text + "','" + this.namauser.Text + "','" + this.jabatan.Text + "','" + this.sandi.Text + "')");
            MessageBox.Show("Input data berhasil");
            pengguna();
            iduser.Text = " ";
            namauser.Text = " ";
            jabatan.Text = " ";
            sandi.Text = " ";
        }
        public void ubah()
        {

            try
            {
                konek();
                string ubah = "update pengguna SET sandi = '" + sandi.Text + "' WHERE id_user = '" + iduser.Text + "' ";
                cmd = new MySqlCommand(ubah, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                diskonek();
                MessageBox.Show("Update berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception kiki1)
            {
                MessageBox.Show(kiki1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ubah();
            pengguna();
        }

        private void jabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
