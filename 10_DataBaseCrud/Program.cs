using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud ---> Create - Read - Update - Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");            
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LUSKAN\\SQLSVR; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //// Dakika 09:24

            //Console.Write("Kategori Başarılı Bir Şekilde Eklendi!!!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productionPrice;
            ////bool    productStatus:

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productionPrice=decimal.Parse(Console.ReadLine()); 

            //SqlConnection connection = new SqlConnection("Data source=LUSKAN\\SQLSVR;initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection );

            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productionPrice);
            //command.Parameters.AddWithValue("productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı");



            //Console.Read();

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=LUSKAN\\SQLSVR;initial catalog=EgitimKampiDb;integrated security=true ");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //    Console.Write(item.ToString() + " ");                 
            //    }
            //    Console.WriteLine();                           

            //}

            //connection.Close();

            //Console.Read();
            #endregion

            #region Ürün Silme

            //Console.Write("Silenecek Ürün: ");

            //int prductId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=LUSKAN\\SQLSVR;initial catalog=EgitimKampiDb;integrated security=true ");

            //connection.Open();

            //SqlCommand command = new SqlCommand ("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId",prductId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Silme İşlemi Başarılı");



            //Console.Read();
            #endregion

            #region Ürün Güncelleme

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            
                        
            //SqlConnection connection = new SqlConnection("Data source=LUSKAN\\SQLSVR;initial catalog=EgitimKampiDb;integrated security=true ");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productName", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Tamam");


            //Console.Read();
            #endregion
        }
    }
}
