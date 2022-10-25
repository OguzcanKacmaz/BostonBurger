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
    public partial class MenuYonetimi : Form
    {
        public MenuYonetimi()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            SiparisYonetimi.Menuler.Add(new Menu() { MenuAdi = txtMenuAdi.Text, MenuFiyati = nudFiyat.Value });
            MessageBox.Show("Menü Eklendi");
            txtMenuAdi.Text = "";
            nudFiyat.Value = nudFiyat.Minimum;
        }
    }
}
