using System;

namespace zadaniya2
{
	class MainClass
	{
		public static void Main(string[] args)
		{

		label: Console.Write("Введить число А = ");
			double a = double.Parse(Console.ReadLine());

			Console.Write("Введить число B = ");
			double b = double.Parse(Console.ReadLine());



			if (a < b)
			{
				
				for (double i = a; a < b; a++)
				{

					if (a % 2 != 0)
					{
						Console.WriteLine("{0,2}", a);
					}
				}


			}
			else
			{
				Console.WriteLine("нужно ввести  А<B\n");

				goto label;
			}
			Console.ReadKey();
		}
	}
}
