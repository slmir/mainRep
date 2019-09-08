using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПроектПробный
{
	class Program
	{
		const int a = 10;
		static void Main(string[] args)
		{
			if (a == 10)
			{
				Console.WriteLine("Тобой выбрана верная дверь, кожевник");
				Console.WriteLine("Ответ положительный");
			}
			for (int i = 0;i<a;i++)
			{
				Console.WriteLine("Русские вперед!!!");
			}
			Console.ReadLine();
		}
	}
}
