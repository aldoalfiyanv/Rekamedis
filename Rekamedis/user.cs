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
    public partial class user : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;

        public user()
        {
            InitializeComponent();
            pengguna();
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
            string sql = "select*from pengguna";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Query("insert into pengguna values ('" + this.iduser.Text + "','" + this.namauser.Text + "','" + this.jabatan.Text + "','" + this.sandi.Text + "')");
            MessageBox.Show("Input Data Berhasil");
            pengguna();
        }

        public void hapus()
        {
            try
            {
                konek();
                string del = "delete from pengguna where id_user = '" + iduser.Text + "' ";
                cmd = new MySqlCommand(del, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                diskonek();
                MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception rizqi2)
            {
                MessageBox.Show(rizqi2.Message);
            }
        }
        private void happus_Click(object sender, EventArgs e)
        {
            hapus();
            pengguna();
        }

        public void cari()
        {
            DataTable dt = new DataTable();
            try
            {
                konek();
                string cari = "select*from pengguna where id_user = " + iduser.Text + "' ";
                cmd = new MySqlCommand(cari, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = cari;
                diskonek();
                MessageBox.Show("Pencarian Berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception rizqi3)
            {
                MessageBox.Show(rizqi3.Message);
            }
        }
        private void golet_Click(object sender, EventArgs e)
        {
            cari();
            pengguna();
        }
        public void ubah()
        {
            try
            {
                konek();
                string ubah = "update pengguna SET nama_user = '" + namauser.Text + "',jabatan = '" + jabatan.Text + "',sandi = '" + sandi.Text + "' WHERE id_user = '" + iduser.Text + "' ";
                cmd = new MySqlCommand(ubah, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                diskonek();
                MessageBox.Show("Update Data Berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception rizqi4)
            {
                MessageBox.Show(rizqi4.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ubah();
            pengguna();
        }
      
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            konek();
            Query("select * from pengguna where " + comboBox1.Text + " = '" + textBox5.Text + "' ");
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            diskonek();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            iduser.Text = "";
            namauser.Text = "";
            jabatan.Text = "";
            sandi.Text = "";
            pengguna();
        }

        private void metu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            iduser.Text = row.Cells["id_user"].Value.ToString();
            namauser.Text = row.Cells["nama_user"].Value.ToString();
            jabatan.Text = row.Cells["jabatan"].Value.ToString();
            sandi.Text = row.Cells["sandi"].Value.ToString();
        }
    }
}
