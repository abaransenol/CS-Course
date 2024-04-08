using System;

namespace SanalMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sanal Metotlar
            //Eğer bir işlem çoğu yerde aynı bazı yerlerde ufak değişiklikler olursa ve o değişiklik olan metotlar
            //sanal metot olarak tanımlanırsa değişiklik yapılacak yerde override edilebilirler (üzerine yazılabilirler).
            //override edilirken base.<metotismi>(); şeklinde bir kod yazılırsa override edilmeden önceki kod çalıştırılabilir.

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
        }
    }

    class MySql : Database
    {

    }
}
