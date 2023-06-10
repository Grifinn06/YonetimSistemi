using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoY
{
    public partial class Kurumk : Form
    {
        public Kurumk()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-FADN4SL\\SQLEXPRESS;Initial Catalog=GeriDonusum;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public void sorgu_check()
        {
            string check = "Select * From kkayit";
            SqlCommand komut = new SqlCommand(check, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void kaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string sorgu = "insert into kkayit(KurumAdi,KurumYetkili,KurumNumarasi,KurumAdres) values (@KurumAdi,@KurumYetkili,@KurumNumarasi,@KurumAdres)";
                    SqlCommand komut = new SqlCommand(sorgu, connect);

                    komut.Parameters.AddWithValue("@KurumAdi", txt_kadi.Text);
                    komut.Parameters.AddWithValue("@KurumYetkili", txt_kyetkili.Text);
                    komut.Parameters.AddWithValue("@KurumNumarasi", txt_no.Text);
                    komut.Parameters.AddWithValue("@KurumAdres", txt_kadres.Text);

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
            string deleted = "Delete From  kkayit Where Kurumid = @id";
            SqlCommand komut = new SqlCommand(deleted, connect);
            connect.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            connect.Close();
        }
        private void deletedx_Click_1(object sender, EventArgs e)
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
        private void editx_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            string guncelle = ("Update kkayit Set KurumAdi = @KurumAdi , KurumYetkili = @KurumYetkili , KurumNumarasi = @KurumNumarasi, KurumAdres = @KurumAdres where Kurumid=@id");

            SqlCommand komut = new SqlCommand(guncelle, connect);

            komut.Parameters.AddWithValue("@KurumAdi", txt_kadi.Text);
            komut.Parameters.AddWithValue("@KurumYetkili", txt_kyetkili.Text);
            komut.Parameters.AddWithValue("@KurumNumarasi", txt_no.Text);
            komut.Parameters.AddWithValue("@KurumAdres", txt_kadres.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
            MessageBox.Show("Kayıtlar başarıyla güncellendi");
            komut.ExecuteNonQuery();
            connect.Close();
            sorgu_check();
        }
        private void checkx_Click_1(object sender, EventArgs e)
        {
            sorgu_check();
        }
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txt_kadi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_kyetkili.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_no.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_kadres.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void back_Click(object sender, EventArgs e)
        {
            arayuz add = new arayuz();
            add.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
