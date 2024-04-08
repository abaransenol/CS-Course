using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar:
            //Aşağıda nesneleri bulunan sınıflar projeye eklenmiştir.

            //Nesnelerin metot tanımlama ve kullanma yolları:

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //Nesnelerin property tanımlama ve kullanma yolları:
            //Yöntem 1:

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "Şenol";
            customer.City = "Ankara";

            //Yöntem 2:

            Customer customer2 = new Customer()
            {
                City = "Eskişehir",
                Id = 2,
                FirstName = "Baran",
                LastName = "Şenol"
            };

            Console.ReadKey();
        }
    }
}
