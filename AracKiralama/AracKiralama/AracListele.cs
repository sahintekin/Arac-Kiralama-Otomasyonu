using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AracKiralama
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=AHMET\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Urus");
                cbxSeri.Items.Add("Aventador");

            }
            else if (cbxMarka.SelectedIndex == 1)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("T10X");
                cbxSeri.Items.Add("T10S");
                cbxSeri.Items.Add("T8CX");

            }
            else if (cbxMarka.SelectedIndex == 2)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("S600");
                cbxSeri.Items.Add("CLA200");
                cbxSeri.Items.Add("E200");

            }
            else if (cbxMarka.SelectedIndex == 3)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("911");
                cbxSeri.Items.Add("Taycan");
                cbxSeri.Items.Add("Macan");

            }

        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void btnGuncellee_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                baglanti.Open();

                string komutCumlesi = "UPDATE Araclar SET Marka = @Marka, Seri = @Seri, Model = @Model, Renk = @Renk, Kilometre = @Kilometre, Yakıt = @Yakıt, Kira_Ucreti = @Ucret, Durumu = @Durumu WHERE Plaka=@Plaka";

                SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
                komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                komut.Parameters.AddWithValue("@Marka", cbxMarka.SelectedItem);
                komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
                komut.Parameters.AddWithValue("@Model", txtModel.Text);
                komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@Kilometre", txtKilometre.Text);
                komut.Parameters.AddWithValue("@Yakıt", cxbYakıt.SelectedItem);
                komut.Parameters.AddWithValue("@Ucret", txtKira.Text);
                komut.Parameters.AddWithValue("@Durumu", cxbDurumu.SelectedItem);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Arac_Listele();
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void btnSill_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Delete From Araclar Where Plaka='" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSeri.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKilometre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cxbYakıt.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtKira.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cxbDurumu.SelectedItem = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           
        }
    }
}
