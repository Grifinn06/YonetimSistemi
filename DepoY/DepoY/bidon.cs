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
    public partial class bidon : Form
    {
        public bidon()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-FADN4SL\\SQLEXPRESS;Initial Catalog=GeriDonusum;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public void sorgu_check()
        {
            string check = "Select * From Dbidon";
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
                    string sorgu = "insert into Dbidon(Dbidonsayi,Dbidondeform,Dbidonbos,Dbidondolu,Tenekesayi) values (@Dbidonsayi,@Dbidondeform,@Dbidonbos,@Dbidondolu,@Tenekesayi)";
                    SqlCommand komut = new SqlCommand(sorgu, connect);

                    komut.Parameters.AddWithValue("@Dbidonsayi", txt_toplam.Text);
                    komut.Parameters.AddWithValue("@Dbidondeform", txt_deform.Text);
                    komut.Parameters.AddWithValue("@Dbidonbos", txt_bos.Text);
                    komut.Parameters.AddWithValue("@Dbidondolu", txt_dolu.Text);
                    komut.Parameters.AddWithValue("@Tenekesayi", txt_teneke.Text);

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
            string deleted = "Delete From  Dbidon Where DID = @id";
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
            string guncelle = ("Update Dbidon Set Dbidonsayi = @Dbidonsayi , Dbidondeform = @Dbidondeform , Dbidonbos = @Dbidonbos, Dbidondolu = @Dbidondolu, Tenekesayi = @Tenekesayi where DID=@id");

            SqlCommand komut = new SqlCommand(guncelle, connect);

            komut.Parameters.AddWithValue("@Dbidonsayi", txt_toplam.Text);
            komut.Parameters.AddWithValue("@Dbidondeform", txt_deform.Text);
            komut.Parameters.AddWithValue("@Dbidonbos", txt_bos.Text);
            komut.Parameters.AddWithValue("@Dbidondolu", txt_dolu.Text);
            komut.Parameters.AddWithValue("@Tenekesayi", txt_teneke.Text);
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
            txt_toplam.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_deform.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_bos.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_dolu.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_teneke.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
        private void back_Click(object sender, EventArgs e)
        {
            arayuz add = new arayuz();
            add.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
