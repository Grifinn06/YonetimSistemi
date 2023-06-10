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
    public partial class log : Form
    {
        public log()
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

        public void sorgu_check1()
        {
            string check = "Select * From kayit";
            SqlCommand komut = new SqlCommand(check, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        public void sorgu_check2()
        {
            string check = "Select * From Dbidon";
            SqlCommand komut = new SqlCommand(check, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        private void kurumk_Click(object sender, EventArgs e)
        {
            sorgu_check();
        }

        private void bidonk_Click(object sender, EventArgs e)
        {
            sorgu_check1();
        }
        private void atik_Click(object sender, EventArgs e)
        {
            sorgu_check2();
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
