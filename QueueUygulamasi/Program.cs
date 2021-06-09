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
            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için ESC tuşuna basınız.");
            secim = Console.ReadKey();

            if (secim.Key==ConsoleKey.Escape)
            {

            Console.WriteLine();

            while (kuyruk.Count>0)
            {
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
            }
            Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı.");
            }
            Console.WriteLine("Program bitti.");
            Console.ReadKey();
        }
    }
}
