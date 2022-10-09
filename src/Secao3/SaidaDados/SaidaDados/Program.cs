using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome,idade,saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais."); //mto mais dahora
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais." );

            //Console.Write("Bom dia"); //sem o Line ele não quebra linha
            //Console.WriteLine("Boa Tarde");
            //Console.WriteLine("Boa Noite");
            //Console.WriteLine("---------------------");

            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo.ToString("F"));
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //InvariantCulture ignora qualquer formatação de país

        }
    }
}