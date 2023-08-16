using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio
{
    internal abstract class Conta
    {
        public string agencia { get; set; }
        public string sataAbertura { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; }

        public abstract void Depositar(double valor);

        public abstract void Retirar(double valor);

    }
}
