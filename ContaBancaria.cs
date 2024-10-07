using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace caixaEletronico
{
    public class ContaBancaria
    {
        public int NumeroDaConta;
        public string NomeDoTitular;
        public string DepósitoInicial;
        public double ValorInicial;
        public double ValorDeposito;
        public static double ValorSaque;

        public double AposDeposito()
        {   
            if(ValorSaque > 0)
                return (ValorInicial + ValorDeposito) - (ValorSaque + 5);
            else
            {
                return ValorInicial + ValorDeposito;
            }
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta + "," 
            + " Titular: " + NomeDoTitular + ","
            + " Saldo: $" + AposDeposito().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}