using System;

namespace zadaniya3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int i1 = 0, i2 = 0;
			for (int a = 0; a < 14; a++)
			{
				for (int b = 0; b < 15; b++)
				{

					if (b == i1 || b == i2) Console.Write("*");
					else Console.Write(" ");
				}
				Console.Write("\n");
				i2++;
			}
			for (int b = 0; b < 15; b++)
			{
				Console.Write("*");
			}
			Console.Read();

		}

	}
}
