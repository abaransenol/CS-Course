using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLog();
            customerManager.Add();

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }

    class FileLog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class SmsLog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms.");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
