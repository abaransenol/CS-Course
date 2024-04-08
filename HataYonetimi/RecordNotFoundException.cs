using System;
using System.Collections.Generic;
using System.Text;

namespace HataYonetimi
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message):base(message) //Burda constructor şeklinde mesajı gönderebiliriz.
        {

        }
    }
}
