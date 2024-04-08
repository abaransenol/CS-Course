using System;
using System.Linq;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar:

            ParametresizMetot();
            int sonuc = Topla(20, 30);

            int numara1 = 20;
            int sonuc2 = RefliTopla(ref numara1, 30); //Refli değişken değeri gönderilirse ve bu değer metotta değişirse değişkenin değeri de değişir. 
            Console.WriteLine("{0} , {1}",numara1,sonuc2);

            int sayi1;
            int sonuc3 = OutluTopla(out sayi1,50); //Outlu değişken değeri gönderilirse ve bu değer metotta değişirse değişkenin değeri de değişir.

            //ref ile out farkı:
            //1-Ref için önceden değişkene değer tanımlamak lazım iken out için böyle bir gereklilik yoktur.
            //2-Refli metotta değişken değeri değişmesi şart değilken outlu metotta şarttır.

            Console.WriteLine(OverLoadTopla(15,30));
            Console.WriteLine(OverLoadTopla(15,30,45));

            //Metot aşırı yüklenmesi: Eğer bir metotta isteyen için daha az veya daha çok sayıda parametre kullanmak istersek kullanırız.
            //Aynı metot aşağısına daha a veya daha çok parametreli şekilde aynı isimle tekrar yazılabilir.

            Console.WriteLine(ParamsTopla(2,3,5,67,7,13,23,13,123,41,2,312,2));
            //Params keyword ile bir metottaki parametreye istediğimiz kadar değer gönderebiliriz.
            //bu keyword olan parametre sonuncu parametre olmaz zorundadır.
        }
        static void ParametresizMetot()
        {
            Console.WriteLine("Eklendi!");
            //Void metotlar değer döndürmez.
        }
        static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static int DefaultDegerliTopla(int s1, int s2 = 20)
        {
            return s1 + s2;
        }
        static int RefliTopla(ref int numara1,int numara2)
        {
            numara1 = 50;
            return numara1 + numara2;
        }
        static int OutluTopla(out int sayi1,int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }
        static int OverLoadTopla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int OverLoadTopla(int sayi1,int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        static int ParamsTopla(params int[] sayilar)
        {
            return sayilar.Sum(); //Sum = Toplama metotu
        }
    }
}
