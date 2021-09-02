using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type-safety 
            // Do not repeat yourself

            string kategorietiketi = "Kategoriler";
            int ogrenciSayisi = 150;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategorietiketi);

            Console.WriteLine(faizOranı);
        }
    }
}
