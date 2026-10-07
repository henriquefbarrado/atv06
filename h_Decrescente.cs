using System;

namespace ExH_Decrescente
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numeros = new int[6];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Digite o numero " + (i + 1) + ": ");
				numeros[i] = int.Parse(Console.ReadLine());
			}

			// bubble sort: compara vizinhos e troca de lugar se estiverem fora de ordem
			for (int i = 0; i < numeros.Length - 1; i++)
			{
				for (int j = 0; j < numeros.Length - 1 - i; j++)
				{
					// pra ordem decrescente, troca quando o da esquerda e MENOR
					if (numeros[j] < numeros[j + 1])
					{
						int temp = numeros[j];
						numeros[j] = numeros[j + 1];
						numeros[j + 1] = temp;
					}
				}
			}

			Console.WriteLine("\nVetor em ordem decrescente:");
			foreach (int n in numeros)
			{
				Console.WriteLine(n);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
