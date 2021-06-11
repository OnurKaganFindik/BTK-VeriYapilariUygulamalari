using System;
using System.Collections.Generic;

namespace SortedDictionaryUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                {"HTML",new List<int>(){8,10,12} },
                {"CSS",new List<int>(){70,80,90} },
                {"JQuery",new List<int>(){3,5,15} },
                {"SQL",new List<int>(){70,80} },

            };

            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });
            foreach (var kavram in kitapIndeks)
            {

            Console.WriteLine(kavram.Key);

                kavram.Value.ForEach(s=> Console.WriteLine($"\t>"+s));

               
            }
        }
    }
}
