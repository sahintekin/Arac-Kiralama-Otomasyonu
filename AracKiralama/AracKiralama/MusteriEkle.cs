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

namespace AracKiralama
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=AHMET\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True";

        private void btnCıkıs2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "INSERT INTO Musteriler Values(@TcNo,@AdSoyad,@Email,@Telefon,@Adres) ";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@TcNo", txtTcKimlik.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı :)");



        }

        private void txtTcKimlik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTcKimlik.Text = string.Empty;
            txtAdsoyad.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtAdres.Text = string.Empty;
        }

        private void txtTcKimlik_TextChanged(object sender, EventArgs e)
        {
           
            string text = txtTcKimlik.Text;

            if (text == "0")
            {
                MessageBox.Show("Geçersiz değer! 0 ile başlayamaz.");
                txtTcKimlik.Text = "";
            }
        }
    }
}

