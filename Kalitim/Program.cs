using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım
            //Interfacelerin tek başına anlamı yokken kalıtım yapılan sınıfın tek başına anlamı vardır.
            //Hem kalıtım hem implementasyon yapılacaksa önce kalıtım sonra implementasyonlar yapılır.
            //Bir sınıfa birden fazla kalıtım yapılamaz.

            Person[] persons = new Person[3]
            {
                new Student {Name = "Ali" },
                new Customer {Name = "Baran"},
                new Person {Name = "Şenol"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadKey();
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string School { get; set; }
        }
    }
}
