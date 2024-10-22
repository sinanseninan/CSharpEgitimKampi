using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // 2.4.6.8 // Sarı Mavi Turuncu // Adana Ankara Balıkesir
            // Değişken Türü [] DiziAdı = new DeğişkenTürü [ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "white";
            //colors[3] = "blue";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Liyon";
            //cities[2] = "Kahire";
            //cities[3] = "Balıkesir";
            //cities[4] = "Bursa";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 2727;
            //numbers[3] = 24;
            //numbers[7] = 478; // index'e değer ataması yapılmassa default olarak "0" değerini alır.

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "İzmir", "Bursa", "Çankırı", "Antalya", "Şırnak" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz","Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i<numbers.Length; i++) 
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}  

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);            
            //}  

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 }; // Dizi İçerisindeki en büyük sayıyı yaz
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //       maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Sinan", "Dilek", "Göktuğ", "Servet", "Yücel" };
            //Console.WriteLine(persons.Length);

            //int[] number = { 54, 45, 62, 78, 51, 14, 786, 454 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{ 
            //    Console.WriteLine(number[i]);
            //}


            #endregion

            #region Dizi Metodları (.) Sonrası Yeni Metodlar

            //string[] persons = { "Sinan", "Mehmet", "Ayse", "Mehmet" };
            //int index = Array.IndexOf(persons, "Sinan");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());
            //int sum = numbers.Max() + numbers.Min();
            //Console.WriteLine("Dizinin iiki lemenı toplamı: " +sum);

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}.Şehri Girin: ");
            //    cities[i] = Console.ReadLine();                    

            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write(cities[i]);

            //}          

            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++) 
            //{
            //    sum += number[i];
            //}
            //    Console.WriteLine(sum);


            //int[] number = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar: ");
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //for (int i = 0; i < number.Length; i++)
            //{ 
            //    if(number[i] %2 == 0) { Console.WriteLine(number[i]); }

            //}
            //Console.WriteLine("Tek Sayılar: ");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 1) { Console.WriteLine(number[i]); }

            //}
            #endregion
            







        }
    }
}
