using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Emirhan";
            musteri1.Soyadi = "Aslan";
            musteri1.TcNo = "41650607090";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345677890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
          
            // Base sınıf inherit ettiği classları bellekte referans eder.Yani base class referans tutucudur

        }
    }
}
