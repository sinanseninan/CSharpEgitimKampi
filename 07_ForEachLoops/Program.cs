using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Döngüsü

            // 4 parametre alır. 1.Değişken türü 2.değişken adı 3.in 4.liste,dizi,koleksiyon

            //string[] cities = { "Kepsut", "Burhaniye", "Edremit", "Gömeç" };

            //foreach (string city in cities) 
            //{

            //    Console.WriteLine(city);

            //}

            //int[] numbers = { 1, 2, 3,4,564,10394,5466 };

            //foreach (int number in numbers) 
            //{
            //    if (number % 2 == 0)
            //    {
            //       Console.WriteLine(number);
            //    } 

            //}

            //int[] numbers = { 1, 2, 3, 4, 564, 10394, 5466 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //  total += i;

            //}
            //Console.WriteLine(total);

            //List <int> numbers = new List<int>()
            //{

            //    1,2,3,4,5,6

            //};

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi
            Console.Write(" **** C# Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Kullanıcıdan Sınıfta Bulunan Öğrenci Sayısını Alma

            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfta Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine() ;
            Console.WriteLine("-------------------------------");

            // Öğrenci İsimlerini ve Not Ortalamaları Saklayacak Diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++) 
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Girin: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her Öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. Sınav Notunu Girin: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları Toplama
                }
                Console.WriteLine();
                 
                studentExamAvg[i] = totalExamResult/3;
            }

            // Öğrencileri geçip kalma durumu

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");


                // Öğrencinin ortalaması ve geçip kalma durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }
            }

            #endregion
            //Console.Read();


        }
    }
}
