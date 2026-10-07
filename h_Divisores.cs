using System;

namespace ExH_Divisores
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um numero inteiro positivo: ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("Divisores de " + n + ":");

			// testa todos os numeros de 1 ate n e mostra os que dividem certinho
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					Console.WriteLine(i);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
