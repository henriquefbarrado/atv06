using System;

namespace ExG_Tabuada5
{
	class Program
	{
		public static void Main(string[] args)
		{
			// tabuada do 5, multiplicando de 1 ate 10
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine("5 x " + i + " = " + (5 * i));
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
