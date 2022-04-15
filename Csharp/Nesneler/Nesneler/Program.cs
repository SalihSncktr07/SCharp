using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar

            Kutu k = new Kutu(5, 6, 7);
            Console.WriteLine(k._uzunluk);

            Console.ReadLine();
        }
    }
}
