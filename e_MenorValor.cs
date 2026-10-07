using System;

namespace ExE_MenorValor
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

			// mesma ideia do maior, so que invertendo a comparacao
			int menor = numeros[0];
			for (int i = 1; i < numeros.Length; i++)
			{
				if (numeros[i] < menor)
					menor = numeros[i];
			}

			Console.WriteLine("O menor valor do vetor e " + menor);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
