using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Aplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Bakiye görüntüleme
            //2 - Para çekme
            //3 - Para yatırma
            //q - Çıkış yapma

            int bakiye = 1000;

            Console.WriteLine("ATM'ye hoş geldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1 - Bakiye görüntüleme");
            Console.WriteLine("2 - Para çekme");
            Console.WriteLine("3 - Para yatırma");
            Console.WriteLine("q - Çıkış yapma");
            string islem = Console.ReadLine();

            if (islem == "1")
            {
                Console.WriteLine("Şuan ki bakiyeniz: " + bakiye);
            }
            else if (islem == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan tutar: " + (bakiye - cekilecek_tutar));
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
            }
            else if (islem == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int yatirilicak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Güncel tutar: " + (bakiye + yatirilicak_tutar));
            }
            else if (islem == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı iyi günler...");
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli bir değer giriniz");
            }
            Console.ReadLine();


        }
    }
}
