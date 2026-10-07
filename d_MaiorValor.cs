using System;

namespace ExD_MaiorValor
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numeros = new int[5];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Digite o numero " + (i + 1) + ": ");
				numeros[i] = int.Parse(Console.ReadLine());
			}

			// comeco assumindo que o primeiro e o maior e comparo com os outros
			int maior = numeros[0];
			for (int i = 1; i < numeros.Length; i++)
			{
				if (numeros[i] > maior)
					maior = numeros[i];
			}

			Console.WriteLine("O maior valor do vetor e " + maior);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
