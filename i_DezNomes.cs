using System;

namespace ExI_DezNomes
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nomes = new string[10];

			for (int i = 0; i < nomes.Length; i++)
			{
				Console.Write("Digite o nome " + (i + 1) + ": ");
				nomes[i] = Console.ReadLine();
			}

			Console.WriteLine("\n=== LISTAGEM DE NOMES ===");
			for (int i = 0; i < nomes.Length; i++)
			{
				Console.WriteLine((i + 1) + " - " + nomes[i]);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
