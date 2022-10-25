using BostonBurger.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.Siniflar
{
    public class Siparis
    {
        public Boyut SiparisBoyut { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public Menu SeciliMenu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.MenuFiyati;

            if (SiparisBoyut == Boyut.Orta)
                ToplamTutar += ToplamTutar * 0.10M;

            else if (SiparisBoyut == Boyut.Buyuk)
                ToplamTutar += ToplamTutar * 0.25M;

            ToplamTutar += EkstraMalzemeler.Sum(x => x.Fiyati);

            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            string ekstralar ="Ekstra Malzemeler : \n\r";
            if (EkstraMalzemeler.Count == 0)
                return $"Menü Adı : {SeciliMenu.MenuAdi}, Adet : {Adet}, Menu Boyutu : {SiparisBoyut} Toplam Tutar : {ToplamTutar}";

            foreach (var malzemeler in EkstraMalzemeler)
            {
                ekstralar+=malzemeler.EkstraMalzemeAdi+"\n\r";
            }

            return $"Menü Adı : {SeciliMenu.MenuAdi}, Adet : {Adet}, Menu Boyutu : {SiparisBoyut}, {ekstralar} ,Toplam Tutar : {ToplamTutar} ";
        }

    }

}
