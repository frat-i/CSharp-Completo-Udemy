using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Digite o código da conta: ");
            int codigo =int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Terá deposito inicial? (s/n) :");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Digite o saldo inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(codigo, nome, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(codigo, nome);
            }

            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Digite quantos reais vai depositar: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            conta.Deposito(valorDeposito);

            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Digite quantos reais vai sacar: ");
            double valorSaque = double.Parse(Console.ReadLine());

            conta.Saque(valorSaque);

            Console.WriteLine(conta);




        }
    }
}