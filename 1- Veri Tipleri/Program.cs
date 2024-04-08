using System;

namespace _1__Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri Tipleri:

            //1-int: Tam sayıları tutar. Sınırlar: -2147483648 ile +2147483647
            int sayi1 = 25;
            Console.WriteLine(sayi1);

            //2-long: Tam sayıları tutar. Sınırlar: -9223372036854775808 ile +9223372036854775807
            long sayi2 = 50;
            Console.WriteLine(sayi2);

            //3-short: Tam sayıları tutar. Sınırlar: -32768 ile 32767
            short sayi3 = 10;
            Console.WriteLine(sayi3);

            //4-byte: Doğal sayıları tutar. Sınırlar: 0 ile 255
            byte sayi4 = 5;
            Console.WriteLine(sayi4);

            //5-double: Ondalıklı sayıları ve tam sayıları tutar. Sınırlar: Virgülden sonraki 15 basamak
            double sayi5 = 2.5;
            Console.WriteLine(sayi5);

            //6-decimal:Ondalıklı sayıları ve tam sayıları tutar.Eğer ondalıklıysa değerin sonuna 'm' koyulur.
            //Sınırlar: Virgülden sonraki 28 basamak
            decimal sayi6 = 1.25m;
            Console.WriteLine(sayi6);

            //7-char: Karakteri tutar.
            char karakter1 = 'A';
            Console.WriteLine(karakter1);

            //8-string: Karakter dizileri tutar.
            string karakterDizisi1 = "Ankara";
            Console.WriteLine(karakterDizisi1);

            //9-bool: Mantıksal ifadeleri tutar.
            bool ifade1 = true;
            Console.WriteLine(ifade1);

            //10-var: Yazılan değerin türünü alır ve tutar.
            var deger1 = "Selam";
            Console.WriteLine(deger1);

            //11-enum: Karakter dizisi listeleri tutar. class'ın dışında tanımlanır.int türüne dönüşebilir.
            Console.WriteLine(karakterDizisiListesi1.Mersin);
            Console.WriteLine((int)karakterDizisiListesi1.Eskişehir);
        }
    }
    enum karakterDizisiListesi1
    {
        İstanbul,Ankara,İzmir,Eskişehir,Mersin
    }
}
