using System;

namespace ExF_VetorSoma
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] v1 = new int[5];
			int[] v2 = new int[5];
			int[] soma = new int[5];

			// leitura do primeiro vetor
			Console.WriteLine("Primeiro vetor:");
			for (int i = 0; i < 5; i++)
			{
				Console.Write("Elemento " + (i + 1) + ": ");
				v1[i] = int.Parse(Console.ReadLine());
			}

			// leitura do segundo vetor
			Console.WriteLine("Segundo vetor:");
			for (int i = 0; i < 5; i++)
			{
				Console.Write("Elemento " + (i + 1) + ": ");
				v2[i] = int.Parse(Console.ReadLine());
			}

			// soma posicao por posicao
			for (int i = 0; i < 5; i++)
			{
				soma[i] = v1[i] + v2[i];
			}

			Console.WriteLine("\nVetor soma:");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(v1[i] + " + " + v2[i] + " = " + soma[i]);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
