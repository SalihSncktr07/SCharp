using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_ve_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i < 9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Döngü Bitti");

            int sayi = 0;
            for(; ; )
            {
                Console.Write("Bir Sayı Giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                    break;
                if (sayi == 5)
                {
                    Console.WriteLine("Sayi Değeri 5");
                    continue;
                }
            }
            Console.WriteLine("Dögü Bitti");

            Console.ReadLine();
        }
    }
}
