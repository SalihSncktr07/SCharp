using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
	class Program
	{
		static void Main(string[])
		{
			short number3 = 12345;
			int number1 = 0123456789;
			long number2 = 0123456789123456789;
			byte number4 = 255;
			char character = 's';
			double number5 = 19.7;
		
			Console.WriteLine("Number1 is {0}", number1);
			Console.WriteLine("Number2 is {0}", number2);
			Console.WriteLine("Number3 is {0}", number3);
			Console.WriteLine("Number4 is {0}", number4);
			Console.WriteLine("Charcter is {0}", character);
			Console.WriteLine("Number5 is {0}", number5);
			Console.ReadLine();
        }
	}
}