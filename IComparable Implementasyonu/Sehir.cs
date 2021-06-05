using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Implementasyonu
{
    public class Sehir:IComparable<Sehir>
    {
        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

        public Sehir(int plakaNo, string sehirAdi )
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{PlakaNo,-5}{SehirAdi,-15}";
        }

        

        //public int CompareTo(Sehir other)
        //{
        //    if (this.PlakaNo<other.PlakaNo>)
        //    {
        //        return -1;
        //    }
        //    else if(this.PlakaNo==other.PlakaNo)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
    }
}
