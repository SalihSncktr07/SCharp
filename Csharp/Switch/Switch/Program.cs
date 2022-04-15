using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = 3;

            switch (sayi)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("İlk 3");
                    break;
                case 4:
                    Console.WriteLine("Dört");
                    break;
                case 5:
                    Console.WriteLine("Beş");
                    break;
                default:
                    Console.WriteLine("Tanımsız Sayı");
                    break;
            }
            Console.ReadLine();
        }
    }
}
