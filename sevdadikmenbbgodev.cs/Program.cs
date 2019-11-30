using System;

namespace sevdadikmenbbgodev.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int basla;
            Console.WriteLine("Sayiyi Roma Rakamina Cevirmek Icin :1 \nRoma Rakamini Sayiya Cevirmek Icin :0");
            basla = Convert.ToInt16(Console.ReadLine());


            if (basla == 1)
            {
                int sayi;
                Console.WriteLine("Sayi giriniz...");
                sayi = Convert.ToInt32(Console.ReadLine());

                int birler = 0;
                int onlar = 0;
                int yuzler = 0;
                int binler = 0;


                string[] dizibirler = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                string[] dizionlar = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] diziyuzler = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] dizibinler = { "M", "MM", "MMM" };




                if (sayi < 1 && sayi > 3999)
                {
                    Console.WriteLine("Hatali Sayi...");
                    Console.ReadKey();
                }

                else if (sayi < 10)
                {
                    birler = sayi;
                    Console.WriteLine("Sonuc=" + dizibirler[birler - 1]);
                    Console.ReadKey();

                }
                else if (sayi > 10 && sayi < 100)
                {
                    onlar = sayi / 10;
                    birler = sayi % 10;
                    Console.WriteLine("Sonuc=" + dizionlar[onlar - 1] + dizibirler[birler - 1]);
                    Console.ReadKey();
                }
                else if (sayi > 100 && sayi < 1000)
                {
                    yuzler = sayi / 100;
                    onlar = (sayi - (yuzler * 100)) / 10;
                    birler = sayi % 10;
                    Console.WriteLine("Sonuc=" + diziyuzler[yuzler - 1] + dizionlar[onlar - 1] + dizibirler[birler - 1]);
                    Console.ReadKey();

                }
                else if (sayi > 1000 && sayi < 4000)
                {
                    binler = sayi / 1000;
                    yuzler = (sayi - (binler * 1000)) / 100;
                    onlar = (sayi - ((binler * 1000) + (yuzler * 100))) / 10;
                    birler = sayi % 10;
                    Console.WriteLine("Sonuc=" + dizibinler[binler - 1] + diziyuzler[yuzler - 1] + dizionlar[onlar - 1] + dizibirler[birler - 1]);
                    Console.ReadKey();

                }
            }
            else if (basla == 0)
            {

                int deger = 0;
                int x1 = 0, x2 = 0, x3 = 0;
                string romaRakami;
                Console.WriteLine("roma rakamini giriniz...");
                romaRakami = Console.ReadLine();
                for (int i = 0; i < romaRakami.Length; i++)
                {
                    x2 = x1;
                    string harf = romaRakami.Substring(i, 1);
                    if (harf == "I")
                    {
                        x1 = 1;
                    }
                    else if (harf == "V")
                    {
                        x1 = 5;
                    }
                    else if (harf == "X")
                    {
                        x1 = 10;
                    }
                    else if (harf == "L")
                    {
                        x1 = 50;
                    }
                    else if (harf == "C")
                    {
                        x1 = 100;
                    }
                    else if (harf == "D")
                    {
                        x1 = 500;
                    }
                    else if (harf == "M")
                    {
                        x1 = 1000;
                    }

                    if (x1 > x2)
                    {
                        x3 = (-2) * x2;
                    }
                    else
                    {
                        x3 = 0;
                    }
                    deger = deger + x1 + x3;
                }
                Console.WriteLine(deger);
                Console.ReadKey();
            }

        }

        }

    }
           
