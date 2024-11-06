using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarası: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            string connectionString = "Data Source=LUSKAN\\SQLSVR;Initial Catalog=EgitimKampiDb;Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "";
                if (tableNumber == "1")
                {
                    query = "SELECT * FROM TblCategory";
                }
                else if (tableNumber == "2")
                {
                    query = "SELECT * FROM TblProduct";
                }
                else if (tableNumber == "3")
                {
                    query = "SELECT * FROM TblOrder";
                }
                else if (tableNumber == "4")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                }
                else
                {
                    Console.WriteLine("Geçersiz tablo numarası.");
                    return;
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
