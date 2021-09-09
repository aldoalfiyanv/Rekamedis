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
    public partial class formpasien : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;
        


        public formpasien()
        {
            InitializeComponent();
            registrasi.Enabled = false;
        }
        public static string SetValueFornormedis = "";
        public static string SetValueFornamalengkap = "";
        public static string SetValueForjk = "";
        public static string SetValueForalamat = "";
        public static string SetValueForusia = "";
        public static string SetValueFortgldaftar = "";
        



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

        private void tambah_Click(object sender, EventArgs e)
        {
            normedis.Text = "";
            namadepan.Text = "";
            namalengkap.Text = "";
            noid.Text = "";
            jk.Text = "";
            pendidikan.Text = "";
            agama.Text = "";
            tempatlahir.Text = "";
            usia.Text = "";
            alamat.Text = "";
            rt.Text = "";
            rw.Text = "";
            kelurahan.Text = "";
            provinsi.Text = "";
            kabupaten.Text = "";
            kecamatan.Text = "";
            pasien();
        }

        private void registrasi_Click(object sender, EventArgs e)
        {
            SetValueFornormedis = normedis.Text;
            SetValueFornamalengkap = namalengkap.Text;
            SetValueForjk = jk.Text;
            SetValueForalamat = alamat.Text;
            SetValueForusia = usia.Text;
            SetValueFortgldaftar = tgldaftar.Text;

            registrasips RP = new registrasips();
            RP.Show();
            this.Hide();
            
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            Query("insert into pasien values ('" + this.normedis.Text + "','" + this.tgldaftar.Text + "','" + this.namadepan.Text + "','" + this.namalengkap.Text +"','"+this.noid.Text+
                "','"+this.jk.Text+"','"+this.pendidikan.Text+"','"+this.agama.Text+"','"+this.tempatlahir.Text+"','"+this.tgllahir.Text+ "','" + this.usia.Text + "','" +this.alamat.Text+
                "','"+this.rt.Text+"','"+this.rw.Text+"','"+this.kelurahan.Text+"','"+this.provinsi.Text+"','"+this.kabupaten.Text+"','"+this.kecamatan.Text+"')");
            MessageBox.Show("Input Data Berhasil");
            pasien();

            registrasi.Enabled = true;

        }
        public void ubah()
        {
            try
            {
                konek();
                string ubah = "update pasien SET tgl_daftar = '" + tgldaftar.Text + "',nama_depan = '" + namadepan.Text + "',nama_lengkap = '" + namalengkap.Text+"',no_id = '" + noid.Text +
                "',jenis_kelamin = '" + jk.Text + "',pendidikan = '" + pendidikan.Text + "',agama = '" + agama.Text +  "',tgl_lahir = '" + tgllahir.Text +"',tempat_lahir = '" + tempatlahir.Text +
                "',alamat = '" + alamat.Text + "',rt = '" + rt.Text + "',rw = '" + rw.Text + "',kelurahan = '" + kelurahan.Text + "',provinsi = '" + provinsi.Text + "',kabupaten = '" + kabupaten.Text +
                "',kecamatan = '" + kecamatan.Text + "' WHERE no_rmedis = '" + normedis.Text + "' ";
                cmd = new MySqlCommand(ubah, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                diskonek();
                MessageBox.Show("Update Data Berhasil", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception rizqi)
            {
                MessageBox.Show(rizqi.Message);
            }
        }
        private void ubahdata_Click(object sender, EventArgs e)
        {
            ubah();
            pasien();
        }

        private void tutup_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void tgldaftar_ValueChanged(object sender, EventArgs e)
        {
            
        }
        public void lihat()
        {
            DataTable dt = new DataTable();
            try
            {
                konek();
                string cari = "select*from pasien where no_rmedis = '" + normedis.Text + "'";
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
       public void tampilandata()
        {
            
                konek();
                string str = "select*from pasien where no_rmedis='" + normedis.Text + "'";
                cmd = new MySqlCommand(str, koneksi);
                read = cmd.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    tgldaftar.Text = (read["tgl_daftar"].ToString());
                    namadepan.Text = (read["nama_depan"].ToString());
                    namalengkap.Text = (read["nama_lengkap"].ToString());
                    noid.Text = (read["no_id"].ToString());
                    jk.Text = (read["jenis_kelamin"].ToString());
                    pendidikan.Text = (read["pendidikan"].ToString());
                    agama.Text = (read["agama"].ToString());
                    tempatlahir.Text = (read["tempat_lahir"].ToString());
                    tgllahir.Text = (read["tgl_lahir"].ToString());
                    usia.Text = (read["usia"].ToString());
                    alamat.Text = (read["alamat"].ToString());
                    rt.Text = (read["rt"].ToString());
                    rw.Text = (read["rw"].ToString());
                    kelurahan.Text = (read["kelurahan"].ToString());
                    provinsi.Text = (read["provinsi"].ToString());
                    kabupaten.Text = (read["kabupaten"].ToString());
                    kecamatan.Text = (read["kecamatan"].ToString());
                }


            diskonek();
            
        }
        private void lihatdata_Click(object sender, EventArgs e)
        {
            DataPasien DP = new DataPasien ();
            DP.Show();
        } 

        private void cari_Click(object sender, EventArgs e)
        {
            lihat();
            tampilandata();
            registrasi.Enabled = true;
        }

        private void formpasien_Load(object sender, EventArgs e)
        {
            
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tampilandata();
            }
        }
    }
}
