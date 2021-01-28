using System;

namespace zadaniya6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("N: ");
			int n = int.Parse(Console.ReadLine());
			int[] myArray = new int[n];

			for (int i = 0; i < myArray.Length; i++)
			{
				Console.Write($"Введите элемент массива под индексом {i}: ");
				myArray[i] = int.Parse(Console.ReadLine());

			}

			Console.WriteLine("Массив:");

			for (int i = myArray.Length-1; i>=0; i--)
			{
				Console.WriteLine(myArray[i]);

			}
			Console.ReadKey();
		}
	}
}
