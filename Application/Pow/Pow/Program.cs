using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // KONU: Pow
            //int sayi;
            //int isaret;

            //BASADON:

            //Console.Write("Stok adet giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //isaret = Math.Sign(sayi);

            //if (isaret == 0 || isaret == -1)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Lütfen 0'dan büyük bir değer bir değer giriniz.");
            //    goto BASADON;
            //}
            //else
            //{
            //    Console.WriteLine("Stok kayıt işlemi başarılı.");
            //}


            //KONU: Karekök Alma
            Console.WriteLine("1. Kenar uzunluğunu giriniz.");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Kenar uzunluğunu giriniz.");
            double kenar2 = Convert.ToDouble(Console.ReadLine());
            double kenarkaretoplamı = Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2);
            double hipotnus = Math.Sqrt(kenarkaretoplamı);
            Console.Write("Hipotenüs Uzunluğu: ", hipotnus);

            Console.ReadLine();
        }
    }
}
