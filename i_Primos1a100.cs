using System;

namespace ExI_Primos1a100
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Numeros primos entre 1 e 100:");

			// o 1 nao e primo, entao comeco do 2
			for (int n = 2; n <= 100; n++)
			{
				bool primo = true;

				// mesmo teste do exercicio do numero primo, so que repetido pra cada n
				for (int i = 2; i * i <= n; i++)
				{
					if (n % i == 0)
					{
						primo = false;
						break;
					}
				}

				if (primo)
					Console.WriteLine(n);
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
