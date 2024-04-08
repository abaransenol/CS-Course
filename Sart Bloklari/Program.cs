using System;

namespace Sart_Bloklari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şart Blokları:

            //1-if/else if/else:
            var deger1 = 10;
            if (deger1 > 10)
            {
                Console.WriteLine("Değer 10'dan büyük.");
            }
            else if (deger1 < 0)
            {
                Console.WriteLine("Değer 0'dan küçük.");
            }
            else
            {
                Console.WriteLine("Değer 0 ila 10 arasında.");
            }

            //Bilgi: "&&" ifadesi "ve" anlamına gelir. Örnek: deger1 > 10 && deger1 > 100
            //Bilgi: "||" ifadesi "veya" anlamına gelir. Örnek: deger1 < 10 || deger1 > 0

            //2-switch-case-default:
            var deger2 = 25;
            switch (deger2)
            {
                case 10:
                    Console.WriteLine("Değer = 10");
                    break;
                case 25:
                    Console.WriteLine("Değer = 25");
                    break;
                case 50:
                    Console.WriteLine("Değer = 50");
                    break;
                default:
                    Console.WriteLine("Değer 10,25 veya 50 değil.");
                    break;
            }
        }
    }
}
