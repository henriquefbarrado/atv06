using System;

namespace ExD_SomaAteN
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um numero inteiro positivo: ");
			int n = int.Parse(Console.ReadLine());

			int soma = 0;

			// vai acumulando 1 + 2 + 3 + ... + n
			for (int i = 1; i <= n; i++)
			{
				soma += i;
			}

			Console.WriteLine("A soma de 1 ate " + n + " e " + soma);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
