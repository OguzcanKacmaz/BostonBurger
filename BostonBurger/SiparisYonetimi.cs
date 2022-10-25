using BostonBurger.Enumlar;
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
    public partial class SiparisYonetimi : Form
    {
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> onaylananSiparisler = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King", MenuFiyati=78.25M},
            new Menu{MenuAdi="Double King Chicken", MenuFiyati=69.75M},
            new Menu{MenuAdi="Steakhouse", MenuFiyati=72.50M},
            new Menu{MenuAdi="Whooper", MenuFiyati=70.00M},
            new Menu{MenuAdi="Whooper Jr.", MenuFiyati=67.75M},
            new Menu{MenuAdi="Chicken Royal", MenuFiyati=71.25M}
        };
        public static List<EkstraMalzeme> ekstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraMalzemeAdi="Ketçap", Fiyati=2.50M},
            new EkstraMalzeme{EkstraMalzemeAdi="Mayonez", Fiyati=2.50M},
            new EkstraMalzeme{EkstraMalzemeAdi="Hardal", Fiyati=2.75M},
            new EkstraMalzeme{EkstraMalzemeAdi="BBQ", Fiyati=3.00M},
            new EkstraMalzeme{EkstraMalzemeAdi="Ranch", Fiyati=2.00M},
            new EkstraMalzeme{EkstraMalzemeAdi="Buffalo", Fiyati=2.25M}
        };

        public SiparisYonetimi()
        {
            InitializeComponent();
            if (tumSiparisler.Count > 0)
            {
                foreach (var item in tumSiparisler)
                {
                    lbxMenu.Items.Add(item);
                    TutarHesapla();
                }
            }
        }

        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            int x = 20;
            int y = 16;
            int adet = 0;
            foreach (var item in Menuler)
                cmbMenu.Items.Add(item);
            cmbMenu.SelectedIndex = 0;

            foreach (var item in ekstraMalzemeler)
            {
                adet++;
                
                if (adet % 4 == 0)
                {
                    x += 150;
                    y = 16;
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = item.EkstraMalzemeAdi;
                    checkbox.Tag = item;
                    checkbox.Location = new Point(x, y);
                    checkbox.Height = 30;
                    checkbox.Width = 150;
                    pnlMalzeme.Controls.Add(checkbox);
                }
                else if (adet < 5)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = item.EkstraMalzemeAdi;
                    checkbox.Tag = item;
                    checkbox.Location = new Point(x, y);
                    checkbox.Height = 30;
                    checkbox.Width = 150;
                    pnlMalzeme.Controls.Add(checkbox);
                    y += 35;
                }
                else
                {
                    y += 35;                    
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = item.EkstraMalzemeAdi;
                    checkbox.Tag = item;
                    checkbox.Location = new Point(x, y);
                    checkbox.Height = 30;
                    checkbox.Width = 150;
                    pnlMalzeme.Controls.Add(checkbox);

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EkstraMalzeme> secilenEkstraMalzemeler = new List<EkstraMalzeme>();
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenu.SelectedItem;
            if (rbKucuk.Checked)
                yeniSiparis.SiparisBoyut = Boyut.Kucuk;
            else if (rbOrta.Checked)
                yeniSiparis.SiparisBoyut = Boyut.Orta;
            else
                yeniSiparis.SiparisBoyut = Boyut.Buyuk;

            foreach (CheckBox item in pnlMalzeme.Controls)
            {
                if (item.Checked)
                {
                    secilenEkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
                }
            }
            yeniSiparis.EkstraMalzemeler = secilenEkstraMalzemeler;
            yeniSiparis.Adet = (int)nudAdet.Value;
            yeniSiparis.Hesapla();
            tumSiparisler.Add(yeniSiparis);


            lbxMenu.Items.Add(yeniSiparis);
            TutarHesapla();
        }
        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxMenu.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxMenu.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            return toplamTutar;
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Toplam sipariş tutarı : {TutarHesapla()}\r\nSatın almayı tamamlamak istiyor musunuz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < lbxMenu.Items.Count; i++)
                {
                    Siparis gelenSiparis = (Siparis)lbxMenu.Items[i];
                    onaylananSiparisler.Add(gelenSiparis);
                }
                lbxMenu.Items.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlanmıştır. Afiyet Olsun.");
            }
            else
                MessageBox.Show("İptal Edildi.");
        }


        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

