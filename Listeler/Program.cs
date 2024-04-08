using System;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listeler:

            //Tek boyutlu listeler:
            //Tanımlama yöntemi 1:
            string[] liste = new string[3]; //Burdaki 3 ifadesi listenin en çok 3 elemanlı olabileceğini gösterir.
            liste[0] = "Eleman 1";
            liste[1] = "Eleman 2";
            liste[2] = "Eleman 3";

            //Tanımlama yöntemi 2:
            string[] liste2 = { "Eleman1", "Eleman2", "Eleman3" }; //Bu tür bir listeye daha sonra eleman ekleyemeyiz.

            foreach (var eleman in liste2) //foreach = Listelerin içinde dolaşılmasını sağlayan döngüdür.
            {
                Console.WriteLine(eleman);
            }

            //Çok boyutlu listeler:
            //Tanımlama yöntemi:
            string[,] bolgeler = new string[7, 3] //Son köşeli parantezdeki sayılardan ilki satır sayısını ikincisi kolon sayısını belirtir.
            {
                { "İstanbul", "Kocaeli", "Bursa" },
                { "İzmir", "Manisa", "Aydın" },
                { "Antalya", "Adana", "Mersin" },
                { "Ankara", "Eskişehir", "Konya" },
                { "Rize", "Trabzon", "Samsun" },
                { "Erzurum", "Kars", "Artvin" },
                { "Şanlıurfa", "Diyarbakır", "Şırnak" }
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++) //GetUpperBound metodunun parametresi listenin hangi boyutunu aldığımızı belirtir.
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("*****");
            }

            Console.ReadKey();
        }
    }
}
