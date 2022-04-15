using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aa = 10;

            //Param(aa);
            ParamRef(ref aa);
            //ParamOut(out aa);

            //Console.WriteLine("Param içinde değer tüuar. " + a);
            Console.WriteLine("ParamRef ise tamınladığın parametre değerini refereans alarak verdiğin komuta göre geri döndürür, pointer mantığı gibi çalışır. " + aa);
            //Console.WriteLine("ParamOut da ise bir parametre tanımlamadan direk verdiğin değeri çeker, dışarıdan veri  çekmek zorunda değilsin. " + aaa);
            Console.ReadLine();
        }

        static void param(int x)
        {
            x = x * 2;
        }

        static  void ParamRef(ref int x)
        {
            x = x * 2;
        }

        static void ParamOut(out int x)
        {
            x = 2;
        }
    }
}
