using System;

namespace ExA_ImprimeVetor
{
	class Program
	{
		public static void Main(string[] args)
		{
			// vetor ja criado com 6 valores
			int[] numeros = { 10, 25, 7, 42, 3, 18 };

			// Length diz quantos elementos o vetor tem
			for (int i = 0; i < numeros.Length; i++)
			{
				Console.WriteLine("Posicao " + i + ": " + numeros[i]);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
