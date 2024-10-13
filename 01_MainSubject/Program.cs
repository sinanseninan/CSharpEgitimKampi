using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("***** Yemek Kategorileri ***** ");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar:");
            //Console.WriteLine("2-Ana Yemekler:");
            //Console.WriteLine("3-Soğuk Başlangıçlar:");
            //Console.WriteLine("4-Salatalar:");
            //Console.WriteLine("5-Tatlılar:");
            //Console.WriteLine("6-İçecekler:");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri ***** ");

            #endregion

            #region String Değişkenker

            //// String Değişkenler
            //// değişken_türü değişken_adı;

            ////string name;
            ////name = "Sinan";
            ////Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Sinan";
            //customerSurname = "Şeninan";
            //customerPhone = "+90 507 940 10 09";
            //customerEmail = "deneme@gmail.com";
            //district = "Merkez";
            //city = "Hakkari";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("İlçe: " + district + " İl: " + city);
            //Console.WriteLine("-------------------");

            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //customerName = "Dilek";
            //customerSurname = "Şeninan";
            //customerPhone = " +90 507 940 10 08";
            //customerEmail = " deneme@hotmail.com";
            //district = "Karesi";
            //city = "Balıkesir";
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("İlçe: " + district + " İl: " + city);
            //Console.WriteLine("-------------------");


            //customerName = " Servet";
            //customerSurname = "Şeninan";
            //customerPhone = "+90 532 383 18 49";
            //customerEmail = "servet@gmail.com";
            //district = "Burhaniye";
            //city = "Balıkesir";

            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("İlçe: " + district + " İl: " + city);
            //Console.WriteLine("-------------------");

            #endregion

            #region Int Değişkenler

            //// int değişkenler - tam sayı türünde

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine(" **** Restoran Menü Fiyatı **** ");
            Console.WriteLine();
            Console.WriteLine(" -----Hamburger Fiyatı: " + hamburgerPrice + " TL.");
            Console.WriteLine(" -----Kola Fiyatı: " + cokePrice + " TL.");
            Console.WriteLine(" -----Su Fiyatı: " + waterPrice + " TL.");
            Console.WriteLine(" -----Kızartma Fiyatı: " + friesPrice + " TL.");
            Console.WriteLine(" -----Pizza Fiyatı: " + pizzaPrice + " TL.");
            Console.WriteLine(" -----Limonata Fiyatı: " + lemonadePrice + " TL.");
            Console.WriteLine(" -----Kola ve Pizza: " + (cokePrice + pizzaPrice) + " TL.");
            Console.WriteLine();
            Console.WriteLine(" **** Restoran Menü Fiyatı **** ");

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int totolprice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;


            Console.WriteLine(" ------ ---------- ------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Su tutarı: " + totalWaterPrice);
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice);
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice;
            Console.WriteLine("Toplam: " + totalPrice);

            #endregion


            Console.Read();
        }
    }
}




