using System;
using System.Globalization;

namespace ProjetoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros vc vai digitar?: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Valor # {0}: ", i );
                int valor = int.Parse(Console.ReadLine());
                soma += + valor; // soma += valor
            }

            Console.WriteLine("Total : " + soma);

        }
    }
}