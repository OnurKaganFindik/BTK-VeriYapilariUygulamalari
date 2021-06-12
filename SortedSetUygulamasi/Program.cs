using System;
using System.Collections.Generic;

namespace SortedSetUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanımlanacak elemenların benzersiz olması gerekiyor
            //Elemanlar sıralı şekilde tutulur ve sıralama ekleme sırasında yapılır.
            //Add()-Ekleme-bool, Remove()-Silme, RemoveWhere(-koşul(lambda)-)-koşula uygun yapıları setten çıkarma
            //Kümelerdeki kesişim-birleşim-ayrım-altkümeler gibi özllerikler için daha çok kullanılır.

            //Tanımlama
            var list = new SortedSet<string>();

            if(list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme Başarısız");
            }

            Console.WriteLine("{0}", list.Add("Ahmet")==true? "Ahmet eklendi" :"Ekleme başarısız.");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            //Tek tek silme
            list.Remove("Sule");

            ////Şartlı silme-(içine A olanları silme)
            //list.RemoveWhere(deger => deger.Contains("A"));

            //(F ile başlayanları silme)
            list.RemoveWhere(deger => deger.StartsWith("F"));



            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Eleman sayisi  :{0,3}",list.Count);

        }
    }
}
