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
    public partial class pasienrmedis : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;

        public pasienrmedis()
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
            catch(Exception rizqi)
            {
                MessageBox.Show(rizqi.Message);
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
            catch (Exception rizqi1)
            {
                MessageBox.Show(rizqi1.Message);
            }
            finally
            {
                koneksi.Close();
            }
            
        }
        public void hapus()
        {
            try
            {
                konek();
                string del = "delet from pasien where no_rmedis = " + normedis.Text + "' ";
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
        public void golet()
        {
            DataTable dt = new DataTable();
            try
            {
                konek();
                string cari = "select*from pasien where no_rmedis = " + normedis.Text + "' ";
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
        public void ubah()
        {
            try
            {
                konek();
                string ubah ="update pasien SET tgl_daftar = '"+tgldaftar.Text+"',nama_depan = '"+namadepan.Text+"',nama_lengkap = '"+namalengkap.Text+"',no_id = '"+noid.Text+
                    "',jenis_kelamin = '"+jk.Text+"',pendidikan = '"+pendidikan.Text+"',agama = '"+agama.Text+"',alamat = '"+alamat.Text+"',rt = '"+rt.Text+"',rw = '"+rw.Text+
                    "',kelurahan = '"+kelurahan.Text+"',provinsi = '"+provinsi.Text+"',kabupaten = '"+kabupaten.Text+"',kecamatan = '"+kecamatan.Text+"' WHERE no_rmedis = '"+normedis.Text+"' ";
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
        public DataTable search()
        {
            string sql = "select*from pasien where no_rmedis LIKE'" + this.normedis.Text + "%'";
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
            catch (Exception rizqi5)
            {
                MessageBox.Show(rizqi5.Message);
            }
            diskonek();
            return dt;
        }
        public DataTable search1()
        {
            string sql1 = "select*from pasien where nama_lengkap LIKE'" + this.namalengkap.Text + "%'";
            DataTable dt1 = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql1, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception rizqi5)
            {
                MessageBox.Show(rizqi5.Message);
            }
            diskonek();
            return dt1;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            normedis.Text = " ";
            tgldaftar.Text = " ";
            namadepan.Text = " ";
            namalengkap.Text = " ";
            noid.Text = " ";
            jk.Text = " ";
            pendidikan.Text = " ";
            agama.Text = " ";
            alamat.Text = " ";
            rt.Text = " ";
            rw.Text = " ";
            kelurahan.Text = " ";
            provinsi.Text = " ";
            kabupaten.Text = " ";
            kelurahan.Text = " ";
            pasien();
        }

        private void registrasi_Click(object sender, EventArgs e)
        {
            registrasips regpasien = new registrasips();
            regpasien.Show();
            this.Hide();
        }
        
        private void Simpan_Click(object sender, EventArgs e)
        {
            Query("insert into pasien values ('" + this.normedis.Text + "','" + this.tgldaftar.Text + "','" + this.namadepan.Text + "','" + this.namalengkap.Text + "','" + this.noid.Text + "','" +
                this.jk.Text + "','" + this.pendidikan.Text + "','" + this.agama.Text + "','" + this.alamat.Text + "','" + this.rt.Text + "','" + this.rw.Text + "','" + this.kelurahan.Text + "','" +
                this.provinsi.Text + "','" + this.kabupaten.Text + "','" + this.kecamatan.Text + "')");
            MessageBox.Show("Input Data Berhasil");
            pasien();
            
        }

        private void ubahdata_Click(object sender, EventArgs e)
        {
            ubah();
            pasien();
        }

        private void cari_Click(object sender, EventArgs e)
        {
            golet();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="no_rmedis")
            {
                search();
            }
            else
            {
                search1();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dataGridView1.Rows[e.RowIndex];

            normedis.Text = baris.Cells["no_rmedis"].Value.ToString();
            tgldaftar.Text = baris.Cells["tgl_daftar"].Value.ToString();
            namadepan.Text = baris.Cells["nama_depan"].Value.ToString();
            namalengkap.Text = baris.Cells["nama_lengkap"].Value.ToString();
            noid.Text = baris.Cells["no_id"].Value.ToString();
            pendidikan.Text = baris.Cells["pendidikan"].Value.ToString();
            agama.Text = baris.Cells["agama"].Value.ToString();
            tgllahir.Text = baris.Cells["tgl_lahir"].Value.ToString();
            tempatlahir.Text = baris.Cells["tempat_lahir"].Value.ToString();
            alamat.Text = baris.Cells["alamat"].Value.ToString();
            rt.Text = baris.Cells["rt"].Value.ToString();
            rw.Text = baris.Cells["rw"].Value.ToString();
            kelurahan.Text = baris.Cells["kelurahan"].Value.ToString();
            provinsi.Text = baris.Cells["provinsi"].Value.ToString();
            kabupaten.Text = baris.Cells["kabupaten"].Value.ToString();
            kecamatan.Text = baris.Cells["kecamatan"].Value.ToString();
        }
    }
}
