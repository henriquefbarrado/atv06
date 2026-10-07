using System;

namespace ExA_Pares0a100
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Numeros pares entre 0 e 100:");

			// o contador comeca em 0 e pula de 2 em 2, so cai em pares
			for (int i = 0; i <= 100; i += 2)
			{
				Console.WriteLine(i);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
