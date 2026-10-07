using System;

namespace ExJ_SomaPares
{
	class Program
	{
		public static void Main(string[] args)
		{
			int soma = 0;

			// de 2 em 2 a partir do 2 (primeiro par depois do 1)
			for (int i = 2; i <= 100; i += 2)
			{
				soma += i;
			}

			Console.WriteLine("A soma dos numeros pares entre 1 e 100 e " + soma);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
