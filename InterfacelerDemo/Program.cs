using System;

namespace InterfacelerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıf birden fazla interface implemente edebilir.
            //Buna çoklu implementasyon denir.

            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEater[] eaters = new IEater[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eater in eaters)
            {
                eater.Eat();
            }
        }
    }


    interface IWorker
    {
        void Work();
    }
    interface IEater
    {
        void Eat();
    }
    interface IGetSalarier
    {
        void GetSalary();
    }

    class Manager : IWorker, IEater, IGetSalarier
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEater, IGetSalarier
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
