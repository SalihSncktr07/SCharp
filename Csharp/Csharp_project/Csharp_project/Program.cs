using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  C#_NOTES
//Object, türü de değeri de değiştirilebilir bir tiptir.
//Var, türü değil, saadece değeri değiştirilebilir bir tiptir.
//

namespace Csharp_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 55;

            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
            obj = 123;
            Console.WriteLine(obj.GetType());
            Console.ReadLine();
        }
    }
}
