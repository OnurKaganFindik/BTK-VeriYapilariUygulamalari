using System;
using System.Collections.Generic;

namespace SortedSetKumeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme İşlemleri
            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RastgeleSayiUret(100));

            //var B = new SortedSet<int>() { 1, 2, 3, 6 };
            var B = new SortedSet<int>(RastgeleSayiUret(100));

            #region yazdırma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{ s,5}");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{ s,5}");
            }
            Console.WriteLine();
            #endregion

            //Union-Birleşimi
            //A.UnionWith(B);
            //Console.WriteLine("\n\nA ve B kümesinin Birleşimi");


            //Kesişimi
            //A.IntersectWith(B);
            //Console.WriteLine("\n\nA ve B kümesinin Kesişimi");


            //A.ExceptWith(B);
            //Console.WriteLine("\n\nSadece A");


            //A.SymmetricExceptWith(B);
            //Console.WriteLine("\n\nKesişim dışındaki elemanlar");

            ////Alt Kümesi mi? sorgusu
            //A.IsProperSubsetOf(B);


            Console.WriteLine();
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("Toplam sayısı : {0}",A.Count);

            Console.WriteLine();
            Console.ReadKey();
        }
        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
            }
                return list;

        }
    }
}
