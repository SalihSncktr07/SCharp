using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Whlie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    do
            //    {
            //        Console.WriteLine("Do While");
            //    } while (true);

            //string str;
            //int counter = 0, length = 0;

            //do
            //{
            //    Console.WriteLine("Şifre : ");
            //    str = Console.ReadLine();
            //    length = str.Length;
            //    counter++;
            //} while (str != "12345");

            //Console.WriteLine();
            //Console.WriteLine("Deneme sayısı : " + counter);
            //Console.WriteLine("Şifre uzunluğu : " + length);
            //Console.WriteLine("Döngüden çıkıldı");

            //Ternary Operator(1?2:3) : Soru işaretinin sol tarafı FALSE ise 2 numaralı yer çalışıcak eğer TRUE ise 3 num çalışıcak. 
            //string mesaj = false ? "Doğru" : "Yanlış";
            //Console.WriteLine(mesaj);

            int counter = 0;
            bool isValid = default(bool);
            string message = string.Empty;
            string str = string.Empty;

            do
            {
                Console.Write("Şifreyi Giriniz : ");
                str = Console.ReadLine();
                if (str == "12345")
                {
                    isValid = true;
                }
                counter++;
                if (counter >= 5)
                {
                    break;
                }
            } while (str != "12345");

            Console.WriteLine("************");
            message = isValid ? "Başarılı" : "Başarısız";
            Console.WriteLine("Giriş " + message);
            Console.WriteLine("Parola deneme sayısı : " + counter);
            Console.WriteLine("************");

            Console.ReadLine();
        }
    }
}
