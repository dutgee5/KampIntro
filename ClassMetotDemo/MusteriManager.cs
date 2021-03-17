using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Sayın müşterimiz isminiz eklenmiştir. " + musteri.Adi + " " + musteri.Soyadi);
           
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Sayın müşterimiz isminiz listelenmiştir. " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Sayın müşterimiz isminiz silinmiştir. " + musteri.Adi + " " + musteri.Soyadi);
        }

    }
}
