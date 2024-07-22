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
    public partial class AracEkle : Form
    {

        private string baglantiCumlesi = @"Data Source=AHMET\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True";

        public AracEkle()
        {
            InitializeComponent();
        }

        private void btnCıkıs3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakıt,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

           komut.Parameters.AddWithValue( "@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", txtKm.Text);
            komut.Parameters.AddWithValue("@Yakıt", cxbYakıt.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txtKira.Text);
            komut.Parameters.AddWithValue("@Durum", cxbDurumu.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç kaydedildi :)");
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

        private void txtPlaka_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPlaka.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtRenk.Text = string.Empty;
            txtKm.Text = string.Empty;
            txtKira.Text = string.Empty;
            
        }
    }
}
