using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            Console.WriteLine("---------------------");

            //ILoggerService database = new DatabaseLoggerService();
            ILoggerService database2 = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(), new FileLoggerService());
            basvuruManager.BasvuruYap(tasitKrediManager, database2);

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager,konutKrediManager };
            //basvuruManager.BasvuruBilgileriOnGosterim(krediler);

        }
    }
}
