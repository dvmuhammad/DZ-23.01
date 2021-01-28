using System;

namespace zadaniya1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе число");
			int b = Convert.ToInt32(Console.ReadLine());
			int summ = 0;
			for (int i = a + 1; i < b; i++)
			{
				summ += i;
			}
			Console.WriteLine($"Сумма:{summ}");

			Console.ReadKey();
		}
	}
}
