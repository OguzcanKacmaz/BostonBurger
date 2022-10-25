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
    public partial class MalzemeYonetimi : Form
    {
        public MalzemeYonetimi()
        {
            InitializeComponent();
        }

        private void btnekstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            SiparisYonetimi.ekstraMalzemeler.Add(new EkstraMalzeme() { EkstraMalzemeAdi = txtMalzemeAdi.Text, Fiyati = nudMalzemeFiyat.Value });
            MessageBox.Show("Ekstra malzeme eklendi");
            txtMalzemeAdi.Text = "";
            nudMalzemeFiyat.Value = nudMalzemeFiyat.Minimum;
        }
    }
}
