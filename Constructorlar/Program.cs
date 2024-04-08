using System;

namespace Constructorlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructorlar:
            //Sınıfın ismiyle aynı isimli metotlardır.Sınıfların nesneleri oluşturulurken çalışırlar.

            CustomerManager customerManager = new CustomerManager();
            Product product = new Product
            {
                Id = 1,
                Name = "Laptop"
            };

            Product product2 = new Product(2, "Smartphone");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //static metot, sınıf ve constructorlar:
            //Bir nesne oluşturmadan direk kullanabileceğimiz metotlar, sınıflar ve constructorlar için kullanılır.Kullanımı:
            NewClass.Number = 20;
            NewClass.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        private int _sayi = 15;
        public CustomerManager(int sayi)
        {
            _sayi = sayi;
            Console.WriteLine("This number is {0}.",sayi);
        }

        public CustomerManager()
        {
            Console.WriteLine("There is no number.");
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_sayi);
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message.",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Message();
            Console.WriteLine("Added!");
        }
    }



    static class NewClass
    {
        static NewClass()
        {

        }

        public static int Number { get; set; }

        public static void Validate()
        {
            Console.WriteLine("Validation completed.");
        }
    }

    class Manager
    {

        public void DoSomething2()
        {
            Console.WriteLine("Done.");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Done with static class");
        }
    }
}
