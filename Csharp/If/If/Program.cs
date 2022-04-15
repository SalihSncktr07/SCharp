using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF Örnekler

            //bool deger = true;
            //if (deger)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");    
            //}

            int x = 1, y = 2;

            if (x == y)
            {
                Console.WriteLine("Eşit");
            }
            else if (x > y)
            {
                Console.WriteLine("Büyük");
            }
            else
            {
                Console.WriteLine("Küçük");
            }

            #endregion
            Console.ReadLine();
        }
    }
}
