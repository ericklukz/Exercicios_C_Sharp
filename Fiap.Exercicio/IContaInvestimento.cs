using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio
{
    internal interface IContaInvestimento
    {
        public double CalculaRetornoInvestimento(double saldo, double rendimento)
        {
            return saldo * rendimento;
        }
    }
}
