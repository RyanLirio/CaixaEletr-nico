using System;
using System.Globalization;

namespace caixaEletronico
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria c = null;
            //Console.Clear();
            Console.WriteLine("Caixa Eletrônico\n=================");
            Console.Write("Entre com o numero da conta: ");
            int numeroC = int.Parse(Console.ReadLine());
            Console.Write("\nEntre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("\nHaverá depósito inicial? (sim ou não): ");
            string resposta = Console.ReadLine();
            char depositoInicial = resposta.Length > 0 ? char.ToLower(resposta[0]) : ' ';
            
            if (depositoInicial == 's')
            {
                Console.Write("\nEntre com o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numeroC, nome, saldo);
            }
            else if(depositoInicial == 'n')
            {
                double saldo = 0.00;
                c = new ContaBancaria(numeroC, nome, saldo);
            }
            
            Console.Clear();
            Console.WriteLine("\nDados da conta:\n" + c);
            Console.WriteLine("");

            Console.WriteLine("Qual valor deseja depositar?");
            c.ValorDeposito = double.Parse(Console.ReadLine());
            c.AposDeposito(c.ValorDeposito);

            Console.WriteLine("Dados da conta atualizados:\n" + c);
            Console.WriteLine("");

            Console.WriteLine("Qual valor deseja sacar?(Para cada saque é cobrada uma taxa fixa de R$5.00)");
            ContaBancaria.ValorSaque = double.Parse(Console.ReadLine());
            if(ContaBancaria.ValorSaque > 0)
                c.AposSaque(ContaBancaria.ValorSaque);
            else
            {
                ContaBancaria.ValorSaque = 5;
            }
            Console.WriteLine("Dados da conta atualizados:\n" + c);
            Console.WriteLine("");
            





        }
    }
}