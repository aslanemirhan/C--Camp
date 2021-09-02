using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Lenovo";
            urun1.Fiyati = 7800;
            urun1.Aciklama = "64 GB Ram";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "HP";
            urun2.Fiyati = 9200;
            urun2.Aciklama = "128 GB Ram";

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati);
                Console.WriteLine("---------------------------------------");
               
            }

            Console.WriteLine("----------------METOTLAR-------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("----------------------------------------------------");

            sepetManager.Ekle2("Armut", "Mersin Arumutu", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 8);

    

        }
    }
}
