using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПроектПробный
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			Console.Write("Русские вперед???: ");
			string nn = Console.ReadLine();
			if (nn == "да")
			{
				n = 30;
			}
			else
				Console.WriteLine("Пендос");
			for (int i = 0;i < n;i++)
			{
				Console.WriteLine("Русские вперед!!!");
			}
			Console.ReadLine();
		}
	}
}
