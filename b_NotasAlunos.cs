using System;

namespace ExB_NotasAlunos
{
	class Program
	{
		public static void Main(string[] args)
		{
			// um vetor pra cada informacao; o indice i liga os dados do mesmo aluno
			string[] nomes = new string[5];
			double[] nota1 = new double[5];
			double[] nota2 = new double[5];

			// entrada dos dados (notas com virgula, ex: 7,5)
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("--- Aluno " + (i + 1) + " ---");
				Console.Write("Nome: ");
				nomes[i] = Console.ReadLine();
				Console.Write("Nota 1: ");
				nota1[i] = double.Parse(Console.ReadLine());
				Console.Write("Nota 2: ");
				nota2[i] = double.Parse(Console.ReadLine());
			}

			// listagem final
			Console.WriteLine("\n=== LISTAGEM ===");
			for (int i = 0; i < 5; i++)
			{
				double media = (nota1[i] + nota2[i]) / 2;
				Console.WriteLine(nomes[i] + " | Nota 1: " + nota1[i] + " | Nota 2: " + nota2[i] + " | Media: " + media.ToString("F2"));
			}

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}
