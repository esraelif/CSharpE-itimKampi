﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElse
            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlış");
            //}



            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi igiriniz:");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}else
            //{
            //    Console.Write("Girdiğiniz veriler yanlış");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı girdiniz");
            //}



            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav1:  ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir mevcut degil");
            //}



            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.Write("bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümğnden kalan: " + result);


            //Console.Write("LÜtfen sayıyı  giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number %2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    {
            //        Console.Write("Sayı tektir");
            //    }
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' |team=='G')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //Console.WriteLine(team);
            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("*************C# Eğitim Kampı Restoran***********");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine("1-Ana Yemekler: ");
            //Console.WriteLine("2-Çorbalar: ");
            //Console.WriteLine("3-Pizzalar: ");
            //Console.WriteLine("4-İçecekler: ");
            //Console.WriteLine("5-Tatlılar: ");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Lütfen detayını görmek istediğiniz menüyü seçin ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Ana Yemekler --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- Ana Yemekler --------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Çorbalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-KEzogelin Çorbası");
            //    Console.WriteLine("-------- Çorbalar --------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Pizzalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------- Pizzalar  --------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İçecekler --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-KOLA");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //;
            //    Console.WriteLine("-------- İçecekler --------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Tatlılar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Triliçe");

            //    Console.WriteLine("-------- Tatlılar --------");
            //    Console.WriteLine();

            //}

            #endregion

            #region SwitchCase

            //Console.Write("Lütfen ay Girişi Yapınız,: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Agustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;

            //}

            #endregion

            #region switchCase Calculator

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.Sayıyı Giriniz");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz");
            //number2= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz:");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}
            #endregion

            Console.Read();
           
        }
    }
}
