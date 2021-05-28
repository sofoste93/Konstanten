using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstanten
{
	class Program
	{
		// value of constant cannot be changed after initialized
		const double PI = 3.14159265359;
		const int weeks = 52;
		const int months = 12;
		const string birthDay = "06.06.1998";
		static void Main(string[] args)
		{
			Console.WriteLine("My birthday is {0}", birthDay);
			Console.ReadLine();
			Console.ReadKey();
		}
	}
}
