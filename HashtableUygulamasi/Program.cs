using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen string ifadelerden özel karakterleri ayırma


            Console.WriteLine("Başlık giriniz:");
            string baslik = Console.ReadLine();

            //kucultme
            baslik = baslik.ToLower();
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g'},
                {'.','-'},
            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik);
            Console.ReadKey();
        }
    }
}
