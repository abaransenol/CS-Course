using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //Product nesnelerinden oluşan liste döndüren tür:

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            //Yukarıdaki kod bağlantıyı nesne yapar.

            if (connection.State == ConnectionState.Closed) //Eğer bağlantı kapalıysa
            {
                connection.Open(); //Bağlantıyı aç
            }

            SqlCommand command = new SqlCommand("Select * from Products", connection); //Burda komut verilir ve bağlantı nesnesine aktarılır.
            SqlDataReader reader = command.ExecuteReader(); //Komutun çıktısını okur.

            List<Product> products = new List<Product>(); //Product listesi oluşturulur.

            while (reader.Read()) //Komutta eleman olduğu sürece yap.
            {
                Product product = new Product //product nesnesi oluşturulur ve değerler verilir.
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };
                products.Add(product); //product nesnesi products listesine eklenir.
            }

            reader.Close(); //Komutun çıktısı kapatılır.
            connection.Close(); //Bağlantı kapatılır.

            return products; //products listesi geri döndürülür. Devamı için (bkz. Form1.cs)

        }

        public DataTable GetAll2()
        {
            //dataTable döndüren tür (çok yer kapladığı için tercih edilmez.)

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Products",connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable(); //dataTable nesnesi oluşturulur.
            dataTable.Load(reader); //dataTable'a reader eklenir.

            reader.Close();
            connection.Close();

            return dataTable; //dataTable geri döndürülür.

        }
    }
}
