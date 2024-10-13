using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    interface class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!!!");
            //}
            //else                
            //{
            //    Console.WriteLine("Şifre Yanlış!!!");
            //}

            //Console.Read();

            //string capital, country;

            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı Veri");

            //double number;
            //Console.Write("Sayıyı Girin: ");
            //number = double.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı Veri");
            //}

            //double exam1, exam2, exam3, average;
            //string result = "Hata!!!";

            //Console.Write("Sınav-1:");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Sınav-2:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Sınav-3:");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavları Ortalaması: " +  average);

            //if (average>0 & average<=50)
            //{
            //    result = " **Sonuç vasat**";
            //}
            //if (average > 50 & average <= 69)
            //{
            //    result = " **Sonuç Orta**";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " **Sonuç İyi**";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = " **Sonuç Çok İyi**";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapın: ");
            //city= Console.ReadLine();

            //if(city=="Adana" | city=="Ankara" | city== " Bursa" | city== "Trabzon") 
            //{
            //    Console.Write("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.Write("Kayıtlarda Yok");
            //}

            //Console.Write("Lütfen Kullanıcı Adı Girin: ");
            //string userName=Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.Write("Kullanıcı Adı Kabul Edilemez!!!!");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldin");
            //}

            #endregion

            #region Mode İşlemleri

            //double number;
            //number = 26;
            //double result = number % 5; // Mode sembolü programlamada '%' ile belirtilir.
            //Console.WriteLine(result);

            //Console.Write("1.Sayıyı Gir: ");
            //double number1=double.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı Gir: ");
            //double number2=double.Parse(Console.ReadLine());

            //double result = number1 % number2;
            //Console.Write(("1.Sayının 2.Sayıya Bölümünden Kalan: " + result));

            //Console.Read();

            //Console.Write("Sayıyı Gir: ");
            //double number = double.Parse(Console.ReadLine());

            //if (number % 2==0)
            //{
            //    Console.Write("Sayı Çift"); 
            //}
            //else 
            //{
            //    Console.Write("Sayı Tek");
            //}

            //char team;
            //Console.Write("Takım Sembolü Girin:");
            //team = char.Parse(Console.ReadLine());  

            //if (team =='g' & team == 'G') 
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team =='b' & team == 'B') 
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else 
            //{
            //    Console.Write("Hatalı Veri");
            //}
            #endregion

            #region Örnep Proje Uygulaması

            //Console.WriteLine("*** Restorant ***");
            //Console.WriteLine();
            //Console.WriteLine("----------------");                   
            //Console.WriteLine("1-Ana Yemek:");
            //Console.WriteLine("2-Çorba:");
            //Console.WriteLine("3-Pizza:");
            //Console.WriteLine("4-İçecek:");
            //Console.WriteLine("5-Tatlı:");
            //Console.WriteLine("----------------");

            //string menuItem;
            //Console.Write("Detay için Menü Seç:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Ana Yemekler------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tavuk");
            //    Console.WriteLine("2-Kızartma");
            //    Console.WriteLine("3-Pilav");
            //    Console.WriteLine("4-Somon");
            //    Console.WriteLine("5-Patlıcan");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Çorba------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Tarhana");
            //    Console.WriteLine("3-Kelle Paça");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Pizzalar------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık");
            //    Console.WriteLine("2-Peynirli");
            //    Console.WriteLine("3-Sade");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Soda");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tulumba");
            //    Console.WriteLine("2-Revani");
            //    Console.WriteLine("3-Baton Pasta");

            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı Veri Girişi");
            //}
            #endregion

            #region Switch Case Yapıları

            //Console.Write("Ay Girişi Yapın: ");
            //double mountNumber = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //switch (mountNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;
            //}
            #endregion

            #region HESAP MAKİNESİ (SWİTCH CASE İLE)

            //double number1, number2, result;
            //char symbol;
            //Console.Write("1.Sayı:");
            //number1=double.Parse(Console.ReadLine());
            //Console.Write("2.Sayı:");
            //number2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen İşlemi belirtin:");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Sonuç: " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Sonuç: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Sonuç: + " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Sonuç: + " result); break;

            //}
            //Console.Read();
            #endregion








        }
    }
}
