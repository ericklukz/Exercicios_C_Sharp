using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio
{
    internal class ContaPoupanca : Conta, IContaInvestimento
    {
        readonly double _rendimento;
        readonly double _taxa; 

        public ContaPoupanca(double rendimento, double taxa)
        {
            _rendimento = rendimento;
            _taxa = taxa;
        }
        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que 0!");
            }
            else
            {
                saldo = +valor;
                Console.WriteLine("Seu saldo atual é: " + saldo);
            }
        }

        public override void Retirar(double valor)
        {
            if (valor > (saldo + _taxa) || saldo < 0)
            {
                throw new ArgumentException("O valor excede seu saldo!");
            }
            else
            {
                saldo = -valor + _taxa;
                Console.WriteLine("Seu saldo atual é:" + saldo);
            }
            

        }
    }
}
