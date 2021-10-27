using Atividade.Enums.ClassesAbstratos.Entitis;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade.Enums.ClassesAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numeor de contribuintes");
            int cont = int.Parse(Console.ReadLine());

            List<Contribuintes> list = new List<Contribuintes>();

            for(int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"Contribuinte #{i}");
                Console.Write("Juridico ou Fisico (j/f)");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (opcao == 'j')
                {
                    Console.Write("Quantidade de Funcionarios: ");
                    int qntFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, qntFuncionarios));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Gastos com a saude: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            double soma = 0.0;
            foreach (Contribuintes emp in list)
            {
                //chamar  o metodo imposto da classe contribuintes
                double imposto = emp.Imposto();
                Console.WriteLine("Impostos pagos: ");
                Console.WriteLine(emp.Nome + "-R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture)+"\n");
                soma = soma + imposto;
            }
            Console.WriteLine("Total Imposto:" + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
