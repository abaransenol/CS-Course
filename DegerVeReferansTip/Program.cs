using System;
using System.Data;

namespace DegerVeReferansTip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değer ve Referans Tip:

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            //Yukarıdaki işlemde number2, number1'in değerini kopyalıyor yani onun bellekteki yerini göstermiyor.

            Console.WriteLine(number2);
            //Bu yüzden number1 değiştirilip number2 ekrana yazdırıldığında number1'in ilk değeri ekrana yazılıyor.
            //----------------------------------------------------------------------------------------------------//

            string[] cities = new string[] { "Ankara", "Adana", "Antalya" };
            string[] cities2 = new string[] { "Bursa", "Bilecik", "Bartın" };
            cities2 = cities;
            cities[0] = "İstanbul";
            //Burdaysa durum bambaşka. Burda cities2 dizisi cities dizisinin referansını alıyor yani onun bellekteki yerini gösteriyor.

            Console.WriteLine(cities2[0]);
            //Bu yüzden cities dizisinin 0. elemanı değiştirilip cities2 dizisinin 0 elemanı ekrana yazılırsa cities dizisinin yeni
            //0. elemanı ekrana yazılıyor.

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            dataTable2 = dataTable;
            //Burdaki işlemde de yine dataTable2, dataTable'ın referansını alıyor. Fakat bu işlem performansı düşürür.

            //Eğer böyle bir işlem yapılacaksa aşağıdaki gibi yapılması performansı düşürmez:
            DataTable dataTable3 = new DataTable();
            DataTable dataTable4;
            dataTable4 = dataTable3;
        }
    }
}
