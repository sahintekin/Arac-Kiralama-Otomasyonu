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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace AracKiralama
{
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=AHMET\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True";

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar Where Durumu ='Bos'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbxArac.Items.Add(read["Plaka"]);
            }
        }

        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Sozlesme";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();
           
        }

        private void cbxArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar Where Plaka like  '" + cbxArac.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtMarka.Text = read["Marka"].ToString();
                txtSeri.Text = read["Seri"].ToString();
                txtModel.Text = read["Model"].ToString();
                txtRenk.Text = read["Renk"].ToString();
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dateTimeDonus.Text) - DateTime.Parse(dateTimeCıkıs.Text);
            int gunhesap = gunfarki.Days;
            txtGun.Text = gunhesap.ToString();
            txtTutar.Text = (gunhesap * int.Parse(txtKiraUcret.Text)).ToString();
        }

        private void cxbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select Kira_Ucreti From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cxbKiraSekli.SelectedIndex == 0)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 1).ToString();
                }
                else if (cxbKiraSekli.SelectedIndex == 1)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.80).ToString();
                }
                else if (cxbKiraSekli.SelectedIndex == 2)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.50).ToString();
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                baglanti.Open();

                string komutCumlesi = "Insert Into Sozlesme Values(@TcNo, @AdSoyad, @Telefon, @EhliyetNo, @EhliyetTarihi, @Plaka, @Marka, @Seri, @Model, @Renk, @KiraSekli, @Kira_Ucreti, @KiralandıgıGunSayısı, @Tutar, @CıkısTarihi, @Donus_Tarihi)";
                SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
                komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
                komut.Parameters.AddWithValue("@EhliyetTarihi", txtEhliyetT.Text);
                komut.Parameters.AddWithValue("@Plaka", cbxArac.SelectedItem);
                komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
                komut.Parameters.AddWithValue("@Model", txtModel.Text);
                komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@KiraSekli", cxbKiraSekli.SelectedItem);
                komut.Parameters.AddWithValue("@Kira_Ucreti", txtKiraUcret.Text);
                komut.Parameters.AddWithValue("@KiralandıgıGunSayısı", txtGun.Text);
                komut.Parameters.AddWithValue("@Tutar", txtTutar.Text);
                komut.Parameters.AddWithValue("@CıkısTarihi", dateTimeCıkıs.Text);
                komut.Parameters.AddWithValue("@Donus_Tarihi", dateTimeDonus.Text);

                string komutCumlesiUp = "Update Araclar set Durumu = 'Dolu' Where Plaka = '" + cbxArac.SelectedItem + "'";
                SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);

                komut.ExecuteNonQuery();
                komutUp.ExecuteNonQuery();

                baglanti.Close();
                Sozlesme_Listele();
                Arac_Listele();
                MessageBox.Show("KAYIT BAŞARILI :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }





        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Musteriler where TcNO Like '" + txtTcAra.Text + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTc.Text = read["TcNo"].ToString();
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtTelefon.Text = read["Telefon"].ToString();
            }
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesiSatis = "INSERT INTO Satis VALUES (@TcNo, @AdSoyad, @Telefon, @Plaka, @KiraSekli, @Kira_Ucreti, @Tutar, @CıkısTarihi, @Donus_Tarihi)";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);

            komutSatis.Parameters.AddWithValue("@TcNo", satir.Cells["TcNO"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@AdSoyad", satir.Cells["AdSoyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Telefon", satir.Cells["Telefon"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@KiraSekli", satir.Cells["KiraSekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Kira_Ucreti", satir.Cells["Kira_Ucreti"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Tutar", satir.Cells["Tutar"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@CıkısTarihi", satir.Cells["CıkısTarihi"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Donus_Tarihi", satir.Cells["Donus_Tarihi"].Value.ToString());

            komutSatis.ExecuteNonQuery();

            MessageBox.Show("ARAC TESLİM EDİLDİ :)");



        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null)
            {
                string plaka = selectedRow.Cells["Plaka"].Value.ToString();
                DialogResult result = MessageBox.Show("Seçili sözleşmeyi silmek istiyor musunuz?", "Sözleşme Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                        baglanti.Open();

                        string deleteSozlesmeKomutCumlesi = "DELETE FROM Sozlesme WHERE Plaka = @Plaka";
                        SqlCommand deleteSozlesmeKomut = new SqlCommand(deleteSozlesmeKomutCumlesi, baglanti);
                        deleteSozlesmeKomut.Parameters.AddWithValue("@Plaka", plaka);
                        deleteSozlesmeKomut.ExecuteNonQuery();

                        string deleteSatisKomutCumlesi = "DELETE FROM Satis WHERE Plaka = @Plaka";
                        SqlCommand deleteSatisKomut = new SqlCommand(deleteSatisKomutCumlesi, baglanti);
                        deleteSatisKomut.Parameters.AddWithValue("@Plaka", plaka);
                        deleteSatisKomut.ExecuteNonQuery();

                        baglanti.Close();
                        Sozlesme_Listele();
                       
                        MessageBox.Show("Sözleşme ve Satış başarıyla silindi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek bir sözleşme seçin.");
            }
             




        }
    }
}




