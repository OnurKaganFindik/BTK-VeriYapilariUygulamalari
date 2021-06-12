using System;
using System.Collections.Generic;

namespace SortedSetUygulamasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(5, 15));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();
            //Listedeki benzersiz elemanları bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayıların listesi\n");
            foreach(var sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine("Benzersiz {0} sayı var",benzersizSayiListesi.Count);

        }
    }
}
