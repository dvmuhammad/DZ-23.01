using System;

namespace zadaniya5
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

			for (int i = 0; i < myArray.Length; i++)
			{
				Console.WriteLine(myArray[i]);

			}
			Array.Sort(myArray);
			int maxValue = myArray[myArray.Length - 1];
			Console.WriteLine($"MAX: {maxValue}");


			int index = 0;

			for (int i = 0; i < 5; i++)
			{
				if (myArray[i] < myArray[index])
				{
					index = i;
			    }
			}
			int min = myArray[index];
			Console.WriteLine($"MIN: {min}");

			int sum = 0;
			foreach (int value in myArray)
			{
				sum += value;
			}
			Console.WriteLine("Сумма элементов массива: " + sum);

			int summ=0;
			for (int i = 0; i < myArray.Length; i++)
				 summ += myArray[i];
			int sr = summ / myArray.Length;
			Console.WriteLine("Среднее арифметическое элементов:" + sr);


			for (int i = 0; i < n; i++)
			{
				if (myArray[i] % 2 != 0)
				{
					Console.Write("{0} ", myArray[i]);
				}
			}

			Console.ReadKey();
		}
	}
}
