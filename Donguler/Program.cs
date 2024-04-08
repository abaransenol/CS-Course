using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            //1-for döngüsü
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            //2-while döngüsü
            int numara = 100;
            while (numara <= 0)
            {
                Console.WriteLine(numara);
            }

            //3-do while döngüsü
            int yeninumara = 10;
            do
            {
                Console.WriteLine(yeninumara);
            } while (yeninumara < 10);

            //4-foreach döngüsü
            string[] ogrenciler = { "Ali", "Baran", "Şenol" };
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            
            //Örnek:Asal sayı programı
            //Yöntem 1

            Console.Write("Sayı gir:");
            int sayi = Convert.ToInt16(Console.ReadLine());

            while (sayi < 2)
            {
                Console.Write("Lütfen 2den büyük bir sayı girin:");
                sayi = Convert.ToInt16(Console.ReadLine());
            }

            int sayac = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi == 2)
                {
                    Console.WriteLine("{0} sayısı asaldır.");
                }
                else
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }
                }
            }

            //Yöntem 2
            if (sayac > 0)
            {
                Console.WriteLine("{0} sayısı asal değildir.",sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı asaldır",sayi);
            }

            if (AsalMi(9))
            {
                Console.WriteLine("Bu bir asal sayı.");
            }
            else
            {
                Console.WriteLine("Bu bir asal sayı değil.");
            }

            Console.ReadKey();
        }

        private static bool AsalMi(int number)
        {
            bool sonuc = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    sonuc = false;
                    i = number;
                }
            }
            return sonuc;
        }
    }
}
