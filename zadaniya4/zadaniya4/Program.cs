using System;

namespace zadaniya4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int p = Convert.ToInt32(Console.ReadLine());
			int k = 1;
			int s = 1000;
			while (s <= 1100)
			{
				++k;
				s += s * p / 100;
			}
			Console.WriteLine($"{k} {s}");
			Console.ReadKey();
			                        
		}
	}
}
