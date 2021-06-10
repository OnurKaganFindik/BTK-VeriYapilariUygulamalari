using System;
using System.Collections.Generic;

namespace LinkedListUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elemanların hafızada ki konumlarının sıralı olarak organize edilmediği doğrusal bir liste yapısıdır.
            //Add First, Add Last, First,Last Remove,Remove First, Remove Last,Add Befor, Add After Komutları kullanılır

            var sehirler = new LinkedList<string>();
            sehirler.AddLast("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("Istanbul");

            sehirler.AddAfter(sehirler.Find("Ordu"),"Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;
            while (eleman!=null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;

            }

            Console.WriteLine();
            Console.WriteLine("Geliş Güzergahı");
            Console.WriteLine();

            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;

            }



            Console.ReadKey();

        }
    }
}
