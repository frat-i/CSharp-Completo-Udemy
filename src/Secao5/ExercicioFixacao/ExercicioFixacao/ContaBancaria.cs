using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    internal class ContaBancaria
    {
        public int CodigoConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int codigoConta, string nome)
        {
            CodigoConta = codigoConta;
            Nome = nome;
            Saldo = 0.00;
        }

        public ContaBancaria(int codigoConta, string nome, double saldo) : this(codigoConta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valorDeposito)
        {
             Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
             Saldo -= valorSaque + 5.00;
        }


        public override string ToString()
        {
            return "Dados da conta: " + CodigoConta +
                ", Titular " + Nome + ", Saldo: $ " + Saldo.ToString("C");
        }


    }

}
