using System;
using System.Collections.Generic;

namespace DictionaryUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            var personalListesi = new Dictionary<int, Personel>() 
            {
                {110, new Personel("Mehmet", "Sonsoz", 7500) },
                {120,new Personel("Ahmet","Can",9000) }
            };
            personalListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
            foreach (var p in personalListesi)
            {
                Console.WriteLine(p);
            }



            Console.ReadKey();
        }
    }
}
