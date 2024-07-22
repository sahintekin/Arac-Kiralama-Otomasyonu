using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm=new MusteriEkle(); 
            musterieklefrm.ShowDialog();
        }

        private void btnMusterilist_Click(object sender, EventArgs e)
        {
            MusteriListele musterilistelerm = new MusteriListele();
            musterilistelerm.ShowDialog();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle Araceklefrm = new AracEkle();
            Araceklefrm.ShowDialog();
        }

        private void btnAraclist_Click(object sender, EventArgs e)
        {
            AracListele AracListelefrm = new AracListele();
            AracListelefrm.ShowDialog();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            Sozlesme Sozlesmefrm = new Sozlesme();
            Sozlesmefrm.ShowDialog();
        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            Satis Satisfrm = new Satis();
            Satisfrm.ShowDialog();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
