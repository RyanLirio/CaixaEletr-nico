using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace caixaEletronico
{
    public class ContaBancaria
    {
        public int NumeroDaConta{get; private set;}
        public string NomeDoTitular{get; set;}
        public double ValorInicial{get; private set;}
        public double ValorDeposito;
        public static double ValorSaque;

        
        
        public ContaBancaria(int numeroC, string nome)
        {
            NumeroDaConta = numeroC;
            NomeDoTitular = nome;
        }
        public ContaBancaria(int numeroC, string nome, double depositoInicial) : this(numeroC, nome)
        {
            AposDeposito(depositoInicial);
        }

        public void AposDeposito(double ValorDeposito)
        {
            ValorInicial += ValorDeposito;
        }
        public void AposSaque(double ValorSaque)
        {
            ValorInicial -= ValorSaque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta + "," 
            + " Titular: " + NomeDoTitular + ","
            + " Saldo: $" + ValorInicial.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}