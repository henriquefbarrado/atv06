using System;

namespace ExC_MediaVetor
{
	class Program
	{
		public static void Main(string[] args)
		{
			// vetor de decimais com 5 posicoes (use virgula ao digitar)
			double[] valores = new double[5];
			double soma = 0;

			for (int i = 0; i < valores.Length; i++)
			{
				Console.Write("Digite o valor " + (i + 1) + ": ");
				valores[i] = double.Parse(Console.ReadLine());
				soma += valores[i]; // ja vou somando durante a leitura
			}

			double media = soma / valores.Length;
			Console.WriteLine("A media dos valores e " + media.ToString("F2"));

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
