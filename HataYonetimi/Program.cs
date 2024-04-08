using System;
using System.Collections.Generic;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hata Yönetimi:
            //Basit Kullanım (Profesyonel kullanım 2 tane sonra):
            try
            {
                //Hata verebilecek kod buraya yazılır.
                string[] list = new string[3] { "Baran", "Said", "Emin" };
                list[3] = "Enis";
            }
            catch (IndexOutOfRangeException ex) //Parametre olarak hatanın ismi gönderilebilir.
            {
                //Hata sonucu yapılacak kodlar buraya yazılır.
                Console.WriteLine("Bir hata oluştu: {0}",ex.Message); //Bu metot hatanın mesajını gönderir.
            }

            catch (Exception ex) //Hatanın ismi bilinmiyorsa Exception gönderilebilir.
            {
                Console.WriteLine(ex.InnerException); //Bu metot (varsa) hatanın ayrıntılarını gönderir.
            }

            //---------------------------------------------------------------------
            //Kendi hata sınıfımızı yazma: (bkz.RecordNotFoundException.cs)

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //---------------------------------------------------------------------
            //Profesyonel Kullanım:

            HandleException(() => //Delege gönderme ileriki konularda öğrenilecek.
            {
                Find();
            });

            Console.ReadKey();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> list = new List<string>
            {
                "Baran",
                "Şenol"
            };

            string dene = "Ali";

            if (!list.Contains(dene))
            {
                throw new RecordNotFoundException("Record not found.");
            }

            else
            {
                Console.WriteLine("Record {0} is found!",dene);
            }
        }
    }
}
