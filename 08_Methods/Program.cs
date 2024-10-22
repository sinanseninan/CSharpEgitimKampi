using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metodlar

            // Birşeyin Metod olabilmesi için () gerekli
            // 1. Geriye değer döndürmeyen -- Void Metot (Belli İşlemler için  


            //void CustomerList() 
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Sinan Şeninan");
            //    Console.WriteLine("Dilek Şeninan");

            //}

            //CustomerList();
            //CustomerList();

            //void Sum() 
            //{
            //    int x=1; int y=2 ;
            //    int z = x + y ;
            //    Console.WriteLine(z);                                  
            //}
            //Sum();


            //Console.Read();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName) 
            //{

            //    Console.WriteLine(customerName);                

            //}

            //WriteMethod("Sinan Şeninan");

            //void CustomerCard(string name, string surName) 
            //{
            //    Console.WriteLine("Müşteri: " + name + "  " + surName);

            //}

            //CustomerCard("Sinan", "Şeninan");
            //CustomerCard("Dilek", "Şeninan");


            //Console.Read();
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum (int number1, int number2,int number3) 
            // {

            //     int result=number1 + number2 + number3;
            //     Console.WriteLine(result);          

            // }
            // Sum(4, 5, 6);

            //Console.Read();
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName() 
            //{
            //    return "Sinan Şeninan";            
            //}

            //CustomerName();

            //string StudentCard() 
            //{
            //    string name = "Sinan";
            //    string surname ="Şeninan";
                 
            //    return name + " " + surname;
            
            //}

            //Console.WriteLine(StudentCard());




            Console.Read();
            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor) 
            //{
            //    string cardInfo = "Ülke : " + countryName + "Başkent:  " + capital + " Bayrak Rengi  " + flagColor;  
            //   return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("Ülke adını girin: ");
            //x= Console.ReadLine(); 
            //Console.Write("Başkenti girin: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak rengini girin: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y, z));
            //Console.WriteLine(CountryCard("Türkiye", " Ankara", "Kırmızı"));


            //Console.Read();
            #endregion

           

        }
    }
}
