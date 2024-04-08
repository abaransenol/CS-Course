using System;

namespace Stringler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringler:
            //Stringler birleşmiş karakter dizileridir.
            string sehir = "Ankara";
            string sehir2 = "Eskişehir";
            Console.WriteLine(sehir[4]);

            //Her karakteri alt alta yazma kodu:
            foreach (var item in sehir2)
            {
                Console.WriteLine(item);
            }

            //Stringler toplanabilirler:
            string toplam = sehir + sehir2;
            string toplam2 = String.Format("{0} {1}", sehir, sehir2);


            //Stringlerle ilgili metotlar:
            string cumle = "I am Ali Baran";

            var sonuc = cumle.Length ; //Cümlenin uzunluğunu alır.

            var cumle2 = cumle.Clone(); //Cümlenin kopyasını oluşturur.
            Console.WriteLine(cumle2);
            cumle = "I am Baran";
            Console.WriteLine(cumle2); //Ana cümle değişse de klonu değişmez ayrı bir değişken olmuş olur.

            bool sonuc1 = cumle.EndsWith("n"); //Cümlenin parantez içindeki diziyle bitip bitmediğini kontrol eder.
            bool sonuc2 = cumle.StartsWith("I am"); //Cümlenin parantez içindeki diziyle başlayıp başlamadığını kontrol eder.

            var sonuc3 = cumle.IndexOf("am"); //Cümlede parantez içinde yazılan yerin ilk kaçıncı karakterden başladığını döndürür.
                                              //Bulamazsa -1 döndürür. Birden fazla olursa ilk karakterin yerini söyler.

            var sonuc4 = cumle.LastIndexOf(" "); //IndexOf ile aynıdır fakat aramaya sondan başlar.

            var sonuc5 = cumle.Insert(0,"Hi! "); //Cümlenin 1. parametredeki indeksindeki karakterden itibaren 2. parametredeki karakterleri ekler.

            var sonuc6 = cumle.Substring(5,4); //Cümlenin 1. parametredeki indeksindeki karakterden itibaren 2. parametredeki sayıya kadarki karakterleri alır.

            var sonuc7 = cumle.ToLower(); //Cümleyi tamamen küçük harfli yapar.

            var sonuc8 = cumle.ToUpper(); //Cümleyi tamamen büyük harfli yapar.

            var sonuc9 = cumle.Replace(" ", "-"); //Cümlede olan 1. parametredeki karakterleri 2. parametredekilerle değiştirir.

            var sonuc10 = cumle.Remove(4); //Cümlede 1. parametredeki indexten sonraki karakterleri siler.
                                           //2 parametresi varsa 1. parametreden sonraki 2. parametredeki kadar karakteri siler.

            Console.ReadKey();
        }
    }
}
