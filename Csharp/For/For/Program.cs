using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sonuc = 2;
            //for (int i = 0; i <= 9; i++)
            //{
            //    sonuc += 1;
            //    Console.WriteLine("Sonuç : " + sonuc);
            //}

            //Sonsuz Döngü

            //for (; ; )
            //    Console.WriteLine("aa");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0)
                {
                    Console.WriteLine("Değer : " + i);
                }
                else
                {
                    Console.WriteLine("Kazandınız!");
                }
            }

            Console.ReadLine();
        }
    }
}
