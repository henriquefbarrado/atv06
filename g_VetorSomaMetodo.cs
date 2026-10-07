using System;

namespace ExG_VetorSomaMetodo
{
	class Program
	{
		public static void Main(string[] args)
		{
			// versao do vetor soma usando um metodo auxiliar pra nao repetir a leitura
			Console.WriteLine("Primeiro vetor:");
			int[] v1 = LerVetor(5);
			Console.WriteLine("Segundo vetor:");
			int[] v2 = LerVetor(5);

			int[] soma = new int[5];
			int j = 0;
			while (j < 5)
			{
				soma[j] = v1[j] + v2[j];
				j++;
			}

			Console.WriteLine("\nVetor soma:");
			foreach (int valor in soma)
			{
				Console.Write(valor + " ");
			}
			Console.WriteLine();

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}

		// le "tamanho" numeros do teclado e devolve num vetor
		static int[] LerVetor(int tamanho)
		{
			int[] v = new int[tamanho];
			for (int i = 0; i < tamanho; i++)
			{
				Console.Write("Elemento " + (i + 1) + ": ");
				v[i] = int.Parse(Console.ReadLine());
			}
			return v;
		}
	}
}
