using System;
using System.Collections.Generic;
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

            // Degişken türü [] Dizi Adı=new Degişken türü[Eleman Sayısı]
            //string[] colors = new string[4];
            //colors[0]="mavi";
            //colors[1] = "sari";
            //colors[2] = "yesil";
            //colors[3] = "beyaz";
            //Console.WriteLine(colors[3]);





            //string[] cities = new string[5];
            //cities[0] = "Ankara";
            //cities[1] = "Berlin";
            //cities[2] = "Münster";
            //cities[3] = "Sam";
            //cities[4] = "Washington";
            //Console.WriteLine(cities[5]);




            //int[] numbers = new int[10];
            //numbers[0] = 12;
            //numbers[5] = 56;
            //numbers[7] = 123;
            //numbers[8] = 563;
            //numbers[9] = 963;
            //Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[1]);

            //string[] cities = { "Prag", "Roma", "Atina", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "pembe", "turuncu", "beyaz","mavi","yeşil" };
            //for (int i=0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 11, 25, 36 ,125,459,758,1254,369,895,6985};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbols = { 'a', 'b', 'c', 'd' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}




            //Dizideki en büyük sayıyı bulma:
            //int[] myArray = { 47, 85, 96, 41, 23, 789, 63, 86, 21 };
            //int maximumNumber = myArray[0];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maximumNumber)
            //    {
            //        maximumNumber = myArray[i];

            //    }

            //} 
            //Console.WriteLine(maximumNumber);




            //string[] people = { "esra", "elif", "arif", "hakan", "kaan", "zehra" };
            //Console.WriteLine(people.Length);



            //küçükten büyüğe dogru sıralama
            //int[] number = { 56, 12, 85, 63, 45, 36, 18, 97 };
            //Array.Sort(number);
            //for(int i=0;i<number.Length;i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            //diziyi tersten sıralama yapar
            //int[] number = { 56, 12, 85, 63, 45, 36, 18, 97 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}









            #endregion

            #region Dizi Metotlar
            //string[] people = { "ali", "aysegül", "aslı", "ibrahim", "murat", "yeşim" };
            //int index = Array.IndexOf(people, "aslı");
            //Console.WriteLine(index);




            //int[] numbers = { 52, 36, 89, 65, 41, 28, 39, 17, 91, 37 };
            //Console.WriteLine("Dizinin En büyük Elemanı " + numbers.Max() + " Dizinin en küçük elemanı " + numbers.Min());




            #endregion

            #region Kullanıcıdan Veri Alarak
            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Sehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //sayıları toplatma
            //            int[] numbers = { 10, 20, 30, 40, 50 };
            //            int sum = 0;
            //            for(int i = 0; i < numbers.Length; i++)
            //            {
            //                sum += numbers[i]
            //;            }
            //            Console.WriteLine(sum);


            //sayıları tek ve cift listeleme
            int[] numbers = { 18, 25, 31, 40, 59, 65, 72, 87, 96 };
            Console.WriteLine("Çift Sayılar");
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
            Console.Read();

                
        }
    }
}
