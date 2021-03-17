using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TcNo="12345678910";
            musteri1.Adi = "Ali";
            musteri1.Soyadi ="Veli";
            musteri1.YasadiğiSehir="İstabul";
            musteri1.Yasi = 20;

            Musteri musteri3 = new Musteri();
            musteri3.TcNo = "11111111111";
            musteri3.Adi = "Muhammet";
            musteri3.Soyadi = "Veli";
            musteri3.YasadiğiSehir = "Ankara";
            musteri3.Yasi = 22;

            Musteri musteri4 = new Musteri();
            musteri4.TcNo = "22222222222";
            musteri4.Adi = "Mustafa";
            musteri4.Soyadi = "Veli";
            musteri4.YasadiğiSehir = "Antalya";
            musteri4.Yasi = 23;

            Musteri[] musteri = new Musteri[] { musteri1, musteri3, musteri4 };

          

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriEkleme(musteri4);
            Console.WriteLine("-------------------------------");
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriListeleme(musteri3);
            musteriManager.MusteriListeleme(musteri3);
            Console.WriteLine("---------------------------------------");
            musteriManager.MusteriSilme(musteri4);
            musteriManager.MusteriSilme(musteri4);
            musteriManager.MusteriSilme(musteri4);



        }
    }
}
