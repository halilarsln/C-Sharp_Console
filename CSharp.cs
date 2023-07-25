using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Merhaba Dünya");
            //Console.Write("Benim Adım Halil");

            //Console.WriteLine("Mesleğim Makine Mühendisliği");

            //Console.WriteLine("Kişi tanıtım kartı");
            //Console.WriteLine();
            //Console.WriteLine("Adınız:Halil");
            //Console.WriteLine("Soyadınız:Arslan");
            //Console.WriteLine("Meslek:Yazılım Mühendisliği");

            //Değişkenler
            //Bellek --> geçici bellek
            // sayısal,alfabetik,lojik veriler,karakerler...

            //(s1+s2+s3) / 3 = sonuc

            //string

            //Değişken_türü Değişken_ismi ;

            //string city;
            //city = "Dublin";
            //Console.Write(city);

            //string capital, country;
            //capital = "Ankara";
            //country = "Türkiye";
            //Console.Write(capital+" "+country);

            //camel Case
            //string nameSurname;
            //nameSurname = "Halil Arslan";
            //Console.Write(nameSurname);

            //string job;
            //job = "Software Engineer";
            //Console.Write("Your Job:" + job);

            //int değişkenler

            //int number;
            //number = 20;
            //Console.WriteLine(number);

            //int n1, n2, total;
            //n1 = 10;
            //n2 = 20;
            //total = n1 + n2;
            //Console.WriteLine(total);

            //int number1, number2, addition, extraction,multiplation, division;
            //number1 = 20;
            //number2 = 45;
            //addition = (number1 + number2);
            //extraction = (number1 - number2);
            //multiplation = (number1 * number2);
            //division = (number1 / number2);
            //Console.WriteLine("toplam="+addition);
            //Console.WriteLine("çıkarma="+extraction);
            //Console.WriteLine("çarpma="+multiplation);
            //Console.WriteLine("bölme="+division);

            //Console.Write("Lütfen adınızı giriniz:");
            //string ad;
            //ad= Console.ReadLine();

            //Console.Write("Hoş geldiniz" + ad);

            //string ulke, sehir;
            //Console.Write("ulke:");
            //ulke = Console.ReadLine();
            //Console.Write("Şehir:");
            //sehir = Console.ReadLine();
            //Console.Write(ulke + " " + sehir);

            //Convert Cast
            //Convert.DÖNÜŞÜMTÜRÜ(dÖNÜŞTÜRELECEK_DEĞER);

            //int sayi;
            //Console.Write("Sayıyı Girin:");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //Console.Write(sayi);

            //int kisa, uzun, çevre,alan;
            //Console.Write("Kısa Kenar:");
            //kisa=Convert.ToInt32(Console.ReadLine());
            //Console.Write("Uzun kenar:");
            //uzun=Convert.ToInt32(Console.ReadLine());
            //alan = kisa * uzun;
            //çevre = 2 * (kisa + uzun);
            //Console.Write("Alan:" + alan +" "+ "çevre:" + çevre);

            //double
            //double sayi=4.63;
            //Console.WriteLine(sayi);
            //Console.ReadLine();

            //int s1, s2, s3, ort;
            //Console.Write("Sınav1:");
            //s1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav2:");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav3:");
            //s3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ortalama:");
            //ort = Convert.ToInt32(Console.ReadLine());
            //ort = (s1 + s2 + s3) / 3;
            //Console.Write("Ortalama:" + ort);

            //char değişkenler(tek karakter)
            //char sehir;
            //sehir = 'a';
            //Console.WriteLine(sehir);

            //char karakter;
            //Console.WriteLine("karakter girişi yapınız");
            //karakter=Convert.ToChar(Console.ReadLine());
            //Console.Write(karakter);

            //Karar Yapıları
            //if else
            //if the wather is rainy
            //you take your umbrella
            //else/you dont take your umbrella

            //şifre kontrolü
            //operatör
            //scope

            //string sifre;
            //Console.Write("şifreyi girin:");
            //sifre=Console.ReadLine();
            //if (sifre == "abc")
            //{
            //    Console.WriteLine("şifre başarılı sisteme hoş geldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz");
            //}

            //int s1, s2, ort;
            //string durum;

            //Console.WriteLine("Sınav1:");
            //s1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sınav2:");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //ort = (s1 + s2) / 2;
            //if (ort >= 50)
            //{
            //    durum = "geçti";
            //}
            //else
            //{
            //    durum = "kaldı";
            //}
            //Console.WriteLine("ögrenci sınav durumu:" + durum);

            //Operatörler
            /*
             == eşit mi
            <= küçük veya eşit mi
            >= büyük veya eşit mi
            != eşit değilse
            && ve
            || veya
            = atama
            + - * / aritmetik
            % mod operatörü

            */


            //string kullanici, şifre;
            //Console.WriteLine("kullanıcı adı:");
            //kullanici = Console.ReadLine();
            //Console.WriteLine("şifre:");
            //şifre = Console.ReadLine();
            //if (kullanici =="admin" && şifre == "1234")
            //{
            //    Console.WriteLine("başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("giriş hatalı");
            //}

            //Switch Case

            //0-35 35-50 51-70 71-85 86-100

            //örnekler

            //string fruit;
            //Console.WriteLine("Enter your fruit name:");
            //fruit=Console.ReadLine();
            //switch (fruit)
            //{
            //    case "apple":Console.Write("elma");break;
            //    case "orange":Console.Write("portakal");break;
            //    case "strawberry":Console.Write("çilek");break;
            //    case "melon":Console.Write("kavun");break;
            //    default:Console.Write("bulunamadı");break;
            //}

            //Döngüler

            //For-While Do While  Foreach

            //For

            //1: Başlangıc 2:Bitiş  3:Artış ve Azalış Miktarı

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}

            //for (int i = 1; i<21;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 24; i+=7)
            //{
            //    Console.WriteLine(i);
            //}


            //faktoriyel

            //int sonuc = 1;
            //for (int i = 1; i <= 5; i++) 
            //{
            //    sonuc=sonuc*i;
            //}
            //Console.WriteLine(sonuc);

            //while --> şart saglandıgı surece
            //int sayi = 1;
            //while (sayi<=10)
            //{
            //    Console.WriteLine("Merhaba");
            //    sayi++;
            //}

            //Diziler

            //[]
            //Indez-dizinin sırası --> 0

            //string[] sehirler = { "kütahya", "denizli", "bursa", "milano", "paris" };
            ///*
            // dizinin adı sehirer
            //dizimizin eleman sayısı 5
            //dizimiz 0. indexinde bulunan elaman adana
            //dizimizin son eleman index değeri 4
            //dizinin 2. indexinde bulunan eleman kiev
            //*/

            //Console.WriteLine(sehirler[3]);

            //Foreach

            int[] sayilar = { 47, 26, 35, 39, 78, 89 };
            foreach (int i in sayilar)
            {
                if (i %3 == 0)
                {
                    Console.WriteLine(i);
                }
            }






















            Console.ReadLine();
        }
    }
}
