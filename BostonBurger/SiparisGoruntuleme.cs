using BostonBurger.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BostonBurger
{
    public partial class SiparisGoruntuleme : Form
    {
        public SiparisGoruntuleme()
        {
            InitializeComponent();
        }

        private void SiparisGoruntuleme_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;
            int satilanUrun = 0;

            foreach (Siparis siparis in SiparisYonetimi.onaylananSiparisler)
            {
                ciro += siparis.ToplamTutar;
                satilanUrun += siparis.Adet;
                foreach (EkstraMalzeme ekstraMalzeme in siparis.EkstraMalzemeler)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.Fiyati;
                }
                //satisAdedi += siparis.Adet;
                lstSiparisGoruntule.Items.Add(siparis);
            }
            foreach (Siparis adet in SiparisYonetimi.tumSiparisler)
            {
                satisAdedi += adet.Adet;
            }
            lblCiro.Text = ciro.ToString("c2");
            lblEkstraMalzemeFiyat.Text = ekstraMalzemeGeliri.ToString("c2");
            lblToplamSiparis.Text = satisAdedi.ToString();
            lblSiparisAdet.Text = satilanUrun.ToString();
        }
    }
}
