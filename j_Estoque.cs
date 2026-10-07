using System;

namespace ExJ_Estoque
{
	class Program
	{
		public static void Main(string[] args)
		{
			const int MAX = 40; // limite de mercadorias do sistema

			// tres vetores paralelos: a mesma posicao representa a mesma mercadoria
			string[] nomes = new string[MAX];
			int[] quantidades = new int[MAX];
			double[] precos = new double[MAX];
			int total = 0; // quantas mercadorias ja foram cadastradas

			int opcao;
			do
			{
				Console.WriteLine("\nMENU");
				Console.WriteLine("1. Cadastra mercadorias");
				Console.WriteLine("2. Exibe valor total em mercadorias da empresa");
				Console.WriteLine("3. Sair");
				Console.Write("OPCAO: ");
				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 1:
						// cadastra uma de cada vez e pergunta se quer continuar
						string continuar = "s";
						while (continuar == "s" && total < MAX)
						{
							Console.WriteLine("\n-- Mercadoria " + (total + 1) + " de " + MAX + " --");
							Console.Write("Nome: ");
							nomes[total] = Console.ReadLine();
							Console.Write("Quantidade em estoque: ");
							quantidades[total] = int.Parse(Console.ReadLine());
							Console.Write("Preco unitario (use virgula): ");
							precos[total] = double.Parse(Console.ReadLine());
							total++;

							if (total < MAX)
							{
								Console.Write("Cadastrar outra? (s/n): ");
								continuar = Console.ReadLine().ToLower();
							}
						}
						if (total == MAX)
							Console.WriteLine("Limite de " + MAX + " mercadorias atingido.");
						break;

					case 2:
						// valor total = soma de (quantidade x preco) de cada item
						double valorTotal = 0;
						for (int i = 0; i < total; i++)
						{
							valorTotal += quantidades[i] * precos[i];
						}
						Console.WriteLine("\nMercadorias cadastradas: " + total);
						Console.WriteLine("Valor total em estoque: R$ " + valorTotal.ToString("F2"));
						break;

					case 3:
						Console.WriteLine("Saindo do sistema...");
						break;

					default:
						Console.WriteLine("Opcao invalida.");
						break;
				}
			} while (opcao != 3);

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
