using System;

namespace AbstractSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract sınıflar:
            //Aslında içi boş virtual metotlardır.Interfaceler ile kalıtımların birleşimlerinden oluşurlar.
            //Interfaceler gibi soyutturlar, nesneleri olmaz.
            //Kalıtım gibi birden fazla implemente edilemezler.
            //Kullanımı aşağıdaki gibidir:

            Database database = new Oracle();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Delete();

            Console.ReadKey();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Code");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle Code");
        }
    }
}
