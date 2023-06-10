using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoY
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-FADN4SL\\SQLEXPRESS;Initial Catalog=GeriDonusum;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public void sorgu_check()
        {
            string check = "Select * From kayit";
            SqlCommand komut = new SqlCommand(check, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sorgu = "insert into kayit(bidont,atikt,kilo,teslimarac,tadres) values (@bidont,@atikt,@kilo,@teslimarac,@tadres)";
                    SqlCommand komut = new SqlCommand(sorgu, connect);

                    komut.Parameters.AddWithValue("@bidont", txt_btur.Text);
                    komut.Parameters.AddWithValue("@atikt", txt_atik.Text);
                    komut.Parameters.AddWithValue("@kilo", txt_kilo.Text);
                    komut.Parameters.AddWithValue("@teslimarac", txt_arac.Text);
                    komut.Parameters.AddWithValue("@tadres", txt_tadres.Text);

                    komut.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Kayıt Edildi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void deletexx(int id)
        {
            string deleted = "Delete From  kayit Where ID = @id";
            SqlCommand komut = new SqlCommand(deleted, connect);
            connect.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            connect.Close();
        }

        private void deletedx_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                deletexx(id);
                sorgu_check();
                MessageBox.Show("Silindi.");
            }
        }

        int i = 0;

        private void editx_Click(object sender, EventArgs e)
        {
            connect.Open();
            string guncelle = ("Update kayit Set bidont = @bidont , atikt = @atikt , kilo = @kilo, teslimarac = @teslimarac, tadres = @tadres where ID=@id");

            SqlCommand komut = new SqlCommand(guncelle, connect);

            komut.Parameters.AddWithValue("@bidont", txt_btur.Text);
            komut.Parameters.AddWithValue("@atikt", txt_atik.Text);
            komut.Parameters.AddWithValue("@kilo", txt_kilo.Text);
            komut.Parameters.AddWithValue("@teslimarac", txt_arac.Text);
            komut.Parameters.AddWithValue("@tadres", txt_tadres.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
            MessageBox.Show("Kayıtlar başarıyla güncellendi");
            komut.ExecuteNonQuery();
            connect.Close();
            sorgu_check();
        }

        private void checkx_Click(object sender, EventArgs e)
        {
            sorgu_check();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txt_btur.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_atik.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_kilo.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_arac.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_tadres.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arayuz add = new arayuz();
            add.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
