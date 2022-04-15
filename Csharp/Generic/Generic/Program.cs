using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric

            #region ArrayList Example

            Arraylist Sehirler = new ArrayList();
            Sehirler.Add("İstannbul");
            Sehirler.Add("Antalya");
            Sehirler.Add("İzmir");
            Sehirler.Add("Ankara");

            foreach (var sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
