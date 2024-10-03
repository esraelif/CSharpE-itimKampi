using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("------Fiya Listesi----------");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice= 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("------------ Elma  Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("------------ Portkal  Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("------------ Çilek  Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("------------ Patates  Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("------------ Domates  Birim Fiyatı:" + tomatoPrice + "TL");

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram =26.50;
            //strawberryGram= 0.750;
            //potatoGram =4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat:" + applePrice + "-Gramaj:" + appleGram + "-Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat:" + orangePrice + "-Gramaj:" + orangeGram + "-Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyat:" + strawberryPrice + "-Gramaj:" + strawberryGram + "-Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat:" + potatoPrice + "-Gramaj:" + potatoGram + "-Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyat:" + tomatoPrice + "-Gramaj:" + tomatoGram + "-Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice +potatoTotalPrice+ tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat:" + shoppingTotalPrice);
            #endregion

            #region  Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentitiNumber;
            //Console.WriteLine("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No");
            //passengerIdentitiNumber=Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu:" + passengerName + "" + passengerSurname);








            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //int shoesPrice,computerPrice, chairPrice, tvPrice;
            //shoesPrice= 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen  aldıgınız ayakkabı sayısını giriniz");
            //shoesount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız bilgisayar sayısıı giriniz");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız sandalyegiriniz");
            //chairCount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen aldıgınız tv sayısını giriniz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesount * shoesPrice + tvCount * tvPrice + chairCount * chairPrice + computerCount * computerPrice;
            //Console.WriteLine();
            //Console.WriteLine("Tolam ödemeniz gereken Tutar:" + totalPrice);

            #endregion

            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız:" + result);

            #endregion

            #region Klavyeden karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsietinizi seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet:"+ gender);
            #endregion
            Console.Read();
        }
    }
}
