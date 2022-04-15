using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5, b = 0;
            try
            {
                //Hata oluşabilecek kodların yazıldığı alan
                Console.WriteLine(a / b);
            }
          
            catch (Exception)
            {
                // Hata oluştuştuğunda yapılacak işlerin yazıldığı alan
                Console.WriteLine("Hata oluştu");
            }
            finally
            {
                // Hata oluşsa da oluşmasa da çalışacak alan
                Console.WriteLine("finally");
            }

            Console.ReadLine();
        }
    }
}
