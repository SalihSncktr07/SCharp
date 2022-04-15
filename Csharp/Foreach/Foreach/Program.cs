using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = { 1, 2, 3, 4, 53, 25, 53, 63, 12 };

            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
