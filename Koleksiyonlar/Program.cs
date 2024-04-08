using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar:
            //Listelerin gelişmiş halleridirler. foreach döngüsüyle her elemanı tek tek alınabilir.

            //1-ArrayList: Bu koleksiyon türüne her türlü veri ekleyebiliriz.
            ArrayList arrayList = new ArrayList();

            arrayList.Add("İstanbul"); //Add metotu:  Koleksiyona veri ekler.
            arrayList.Add('A');
            arrayList.Add(true);
            arrayList.Add(12);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //----------------------------------------------------------------------------------------------------------

            //2-Generic Koleksiyonlar: Tip güvenli koleksiyonlardır. Yani sadece tek tip veriyle çalışılır.

            //Tanımlama yolu 1:
            List<string> stringList = new List<string>();
            stringList.Add("Ankara");
            stringList.Add("Eskişehir");

            //Tanımlama yolu 2:
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ali"},
                new Customer {Id  = 2, FirstName = "Baran"}
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.Id);
            }

            //Özellik - metot kullanımları:
            var sonuc1 = customers.Count; //Koleksiyonun eleman sayısını verir.

            var customer2 = new Customer
            {
                Id = 3, FirstName = "Murat"
            };
            customers.Add(customer2); //Koleksiyona veri ekler.

            customers.AddRange(new Customer[2] //Koleksiyona bir listenin veya koleksiyonun içindeki verilerin tamamını ekler.
            { 
                new Customer {Id = 4, FirstName = "Mehtap"},
                new Customer {Id = 5, FirstName = "Fatma"}
            });

            customers.Clear(); //Koleksiyondaki tüm elemanları siler.

            var sonuc2 = stringList.Contains("Eskişehir"); //Parametredeki değer koleksiyonda varsa true, yoksa false döndürür.
            var sonuc3 = customers.Contains(new Customer { Id = 1, FirstName = "Engin" }); //Burda kesinlikle false döner çünkü
                                                                                           //burda yeni bir nesne oluşturuldu.

            var sonuc4 = customers.IndexOf(customer2); //Parametredeki değerin en baştan aramaya başlayarak kaçıncı sırada olduğunu döndürür.

            var sonuc5 = customers.LastIndexOf(customer2); //Parametredeki değerin en sondan aramaya başlayarak kaçıncı sırada olduğunu döndürür.

            customers.Insert(4,customer2); //İlk parametredeki indekse ikinci parametredeki değeri ekler. O sıradan sonraki değerleri kaydırır.

            customers.Remove(customer2); //Parametredeki değerin en baştan arayarak ilk bulduğunu koleksiyondan siler. Bulamazsa hiçbir şey yapmaz.

            customers.RemoveAll(c => c.FirstName == "Murat"); //Parametrede verilen bilgilerin olduğu tüm değerleri koleksiyondan siler. 
                                                              //Bulamazsa hiçbir şey yapmaz.

            //----------------------------------------------------------------------------------------------------------

            //3-Dictionaryler: Anahtar kelime (key) ve anlamlarıyla (value) ile çalışırlar.

            //Tanımlama yöntemi:
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Computer","Bilgisayar");

            var yenisonuc = dictionary["Book"]; //Anahtarı gönderilir ve onun anlamı geri döner. Olmayan anahtar gönderilirse hata verir.

            var yenisonuc2 = dictionary.ContainsKey("Computer"); //Parametredeki anahtar kelime sözlükte varsa true, yoksa false döndürür.

            var yenisonuc3 = dictionary.ContainsValue("Kalem"); //Parametredeki anlam sözlükte varsa true, yoksa false döndürür.

            Console.ReadKey();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
