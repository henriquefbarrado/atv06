using System;

namespace ExF_MaiorDaSequencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			int maior = 0;
			bool primeiro = true; // serve pra saber se ainda nao li nenhum numero
			string texto;

			// o usuario digita um numero por vez e escreve "fim" pra parar
			do
			{
				Console.Write("Digite um numero (ou 'fim' para terminar): ");
				texto = Console.ReadLine().ToLower();

				if (texto != "fim")
				{
					int n = int.Parse(texto);

					// o primeiro numero ja vira o maior; depois so troca se aparecer um maior
					if (primeiro || n > maior)
					{
						maior = n;
						primeiro = false;
					}
				}
			} while (texto != "fim");

			if (primeiro)
				Console.WriteLine("Nenhum numero foi digitado.");
			else
				Console.WriteLine("O maior numero digitado foi: " + maior);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
