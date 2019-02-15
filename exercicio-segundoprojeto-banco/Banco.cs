using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_segundoprojeto_banco
{
    class Banco
    {
        public int numeroDaConta { get; private set; }
        public string titularDaConta { get; set; }

        public double depositoInicial { get; set; }

        public double Saldo { get; private set; }

        public Banco(int numeroDaConta, string titularDaConta, double saldo)
        {
            this.numeroDaConta = numeroDaConta;
            this.titularDaConta = titularDaConta;
            this.Saldo = depositoInicial + saldo;
        }

        public void deposito(double Deposito)
        {
            Saldo = Saldo + Deposito;
        }

        public void saque(double Saque)
        {
            Saldo = Saldo - Saque - 5.0;
        }
    }
}
