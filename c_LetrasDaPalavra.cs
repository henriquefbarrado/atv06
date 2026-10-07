using System;

namespace ExC_LetrasDaPalavra
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
			string palavra = Console.ReadLine();

			// uma string e uma sequencia de caracteres, entao o foreach passa letra por letra
			foreach (char letra in palavra)
			{
				Console.WriteLine(letra);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
