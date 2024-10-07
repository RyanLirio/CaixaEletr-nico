using System;
using System.Globalization;

namespace caixaEletronico
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();
            //Console.Clear();
            Console.WriteLine("Caixa Eletrônico\n=================");
            Console.Write("Entre com o numero da conta: ");
            c.NumeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("\nEntre com o nome do titular da conta: ");
            c.NomeDoTitular = Console.ReadLine();
            Console.Write("\nHaverá depósito inicial? (sim ou não): ");
            c.DepósitoInicial = Console.ReadLine();
            if (c.DepósitoInicial == "sim")
            {
                Console.Write("\nEntre com o valor do depósito inicial: ");
                c.ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (c.DepósitoInicial == "não")
            {
                c.ValorInicial = 0.00;
            }
            Console.Clear();
            Console.WriteLine("\nDados da conta:\n" + c);

            Console.WriteLine("Qual valor deseja depositar?");
            c.ValorDeposito = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da conta atualizados:\n" + c);

            Console.WriteLine("Qual valor deseja sacar?(Para cada saque é cobrada uma taxa fixa de R$5.00)");
            ContaBancaria.ValorSaque = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da conta atualizados:\n" + c);

            





        }
    }
}