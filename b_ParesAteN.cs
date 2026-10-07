using System;

namespace ExB_ParesAteN
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um numero inteiro positivo: ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("Numeros pares entre 0 e " + n + ":");

			// testa um por um e mostra so os que dividem por 2 sem sobrar resto
			for (int i = 0; i <= n; i++)
			{
				if (i % 2 == 0)
					Console.WriteLine(i);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
