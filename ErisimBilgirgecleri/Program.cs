using System;

namespace ErisimBilgirgecleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim bildirgeçleri
            //private: Sadece tanımlandığı blokta kullanılabilir.
            //protected: Sadece tanımlandığı sınıfta ve bu sınıfın kalıtım yaptığı bir sınıf varsa o sınıfta kullanılabilir.
            //internal: Oluşturulduğu projede kullanılabilir.Sınıflar default olarak bu erişim bildirgecine sahiptir.
            //public: Belli işlemlerle tüm projelerde kullanılabilir.(İşlemler için bkz.= AccessModifiers projesi)

            //Bilgi: Sınıflar private ve protected tanımlanamaz fakat iç içe sınıflarda içteki sınıflar private veya protected olabilir.
        }
    }

    public class Customer
    {
        protected int Id { get; set; }
        private int newID { get; set; }
    }

    class Student : Customer
    {
        public void Method1()
        {
            Id = 1;
        }

        private class NestedClass1
        {

        }
    }

    class Course : CourseManager
    {
        public void Method2()
        {
            Deneme = 1;
        }

        protected class NestedClass1
        {
            
        }
    }
}
