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
    public partial class registrasips : Form
    {
        string database = ("server = localhost; database = rekamedis; uid = root; pwd = ''; convert zero datetime = true ");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public MySqlDataReader read;
        

        public registrasips()
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

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            diskonek();
            return dt;
        }
        public DataTable regpasien()
        {
            string sql = "select*from regpasien";
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

        public DataTable pembayaran()
        {
            string sql = "select*from pembayaran";
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


        private void button1_Click(object sender, EventArgs e)
        {
            
            if(tujuanpoli.Text=="POLI GIGI")
            {
               

                poligigi pg = new poligigi();
                pg.Show();
                this.Hide();
            }else if(tujuanpoli.Text=="POLI REMAJA")
            {
                poliremaja pr = new poliremaja();
                pr.Show();
                this.Hide();
            }else if(tujuanpoli.Text=="POLI BALITA")
            {
                polibalita pb = new polibalita();
                pb.Show();
                this.Hide();
            }else if(tujuanpoli.Text=="POLI UMUM")
            {
                poliumum pu = new poliumum();
                pu.Show();
                this.Hide();
            }else if(tujuanpoli.Text=="POLI KIA")
            {
                polikia pk = new polikia();
                pk.Show();
                this.Hide();
            }else if(tujuanpoli.Text=="POLI LANSIA")
            {
                polilansia pl = new polilansia();
                pl.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Tujuan Poli Belum Ada", "Informasi", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registrasips_Load(object sender, EventArgs e)
        {
            
                pasien();
                normedis1.Text = formpasien.SetValueFornormedis;
                nama.Text = formpasien.SetValueFornamalengkap;
                jk1.Text = formpasien.SetValueForjk;
                usia1.Text = formpasien.SetValueForusia;
                tgldaftar1.Text = formpasien.SetValueFortgldaftar;
                tujuanpoli.Text = Form2.SetValueForJABATAN;
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}
