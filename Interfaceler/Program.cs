using System;

namespace Interfaceler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler sayesinde farklı uygulamaları (veritabanı gibi) kendi projemize
            //kolayca entegre edebiliriz.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            //Örnek: Elimizdeki bir bilgiyi tüm veri tabanlarına nasıl göndeririz?
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadKey();
        }
        private static void InterfacesIntro()
        {

            //Interfaceler:
            //Sınıfların soyut halleridirler.Sınıflara implemente edilirler.
            PersonManager personManager = new PersonManager();
        Student student = new Student
        {
            Id = 1,
            Name = "Baran",
            SchoolName = "ŞMŞFL"
        };
        personManager.Add(student);
            personManager.Add2(new Customer {Id = 1, Address = "Eskişehir", Name = "Murat"});
        }
    }

    interface IPerson
    {
        //public kullanılmaz.
        int Id { get; set; }
        string Name { get; set; }
    }
    class Customer : IPerson
    {
        //public kullanılır.
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SchoolName { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            //Burda parametre olarak tüm IPerson implemente etmiş sınıflardan nesne gönderebiliyoruz.
            //Gönderilen nesnenin sınıfına özel özellikler kullanılamaz.
            Console.WriteLine(person.Name);
        }
        public void Add2(Customer customer)
        {
            //Burdaysa parametre olarak sadece customer sınıfından nesne gönderebiliyoruz.
            Console.WriteLine(customer.Address);
        }
    }
}
