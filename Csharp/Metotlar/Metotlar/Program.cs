using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Yaz("Merhaba!");

            //var result = topla(4, 5);
            //yaz(result.tostring());
            //Yaz(Topla(3, 5).ToString());

            //var sonuc = GetAccountName(2);
            //Yaz(sonuc);

            var sonuc = IsValid("salihbaz07@gmail.com");
            Yaz(sonuc.ToString());

            Beklet();
        }

        static bool IsValid(string email)
        {
            bool isValid = default(bool);
            if (email.Contains("@"))
            {
                isValid = true;
            }
            return isValid;
        }

        static string GetAccountName(int accountID)
        {
            string accountName = string.Empty;
            switch (accountID)
            {
                case 0:
                    accountName = "Salih";
                    break;
                case 1:
                    accountName = "Ahmet";
                    break;
                case 2:
                    accountName = "Muhammed";
                    break;
                case 3:
                    accountName = "Cihan";
                    break;
                default:
                    accountName = "Unknown";
                    break;
            }
            return accountName;
        }

        //static void Bosluk()
        //{
        //    Console.WriteLine(Environment.NewLine);
        //}

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Beklet()
        {
            Console.ReadLine();
        }
    }
}
