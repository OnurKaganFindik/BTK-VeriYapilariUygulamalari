using System;
using System.Collections.Generic;


namespace DictionaryUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var telefonKodlari = new Dictionary<int, string>();
           

            //Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(332, "Konya");
            telefonKodlari.Add(424, "Elazığ");
            telefonKodlari.Add(466, "Art");

            //Erişim
            telefonKodlari[466]= "Artvin";

            //ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkar'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");

            }
            //ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");

            }
            telefonKodlari.Remove(322);

            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);

            }


            Console.ReadKey();
        }
    }
}
