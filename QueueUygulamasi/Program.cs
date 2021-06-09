using System;
using System.Collections.Generic;

namespace QueueUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö',
            };
            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5 } kuyruk eklensin mi?");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5}kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
                    Console.WriteLine();

                }

            }
            Console.ReadKey();
        }
    }
}
