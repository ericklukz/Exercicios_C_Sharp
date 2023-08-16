using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio
{
    internal class ContaCorrente : Conta
    {
        public TipoConta tipoConta { get; set; }
        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que 0!");
            }
            else
            {
                saldo =+ valor;
                Console.WriteLine("Seu saldo atual é: " + saldo);
            }
        }

        public override void Retirar(double valor)
        {
            if (tipoConta == TipoConta.comum && valor > saldo)
            {
                throw new ArgumentException("O valor excede o saldo da conta!");
            }
            else
            {
                saldo = -valor;
                Console.WriteLine("Seu saldo atual é: " + saldo);
            }
        }

        internal enum TipoConta {comum, especial, platinum}
    }
}
