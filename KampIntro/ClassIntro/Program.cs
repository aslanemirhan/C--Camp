using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Emirhan Aslan";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.EgitmenAdi = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 97;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.EgitmenAdi = "Murat Kurtboğan";
            kurs3.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.EgitmenAdi + " , İzlenme Oranı : " + kurs.IzlenmeOrani);
            }

        }

    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
