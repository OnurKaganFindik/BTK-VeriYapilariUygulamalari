using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Implementasyonu
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")

            };

            sehirler.ForEach(s => Console.WriteLine(s));

            

            Console.ReadKey();
        }
    }
}
