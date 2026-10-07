using System;

namespace ExE_Primo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um numero inteiro: ");
			int n = int.Parse(Console.ReadLine());

			// numeros menores que 2 nao sao primos
			bool primo = n >= 2;

			// basta testar divisores ate a raiz quadrada do numero
			for (int i = 2; i * i <= n; i++)
			{
				if (n % i == 0)
				{
					primo = false;
					break; // achou um divisor, ja nao e primo
				}
			}

			if (primo)
				Console.WriteLine(n + " e primo.");
			else
				Console.WriteLine(n + " nao e primo.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
