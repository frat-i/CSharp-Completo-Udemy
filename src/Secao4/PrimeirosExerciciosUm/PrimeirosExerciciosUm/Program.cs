using System;
using System.Globalization;
using System.Security.Cryptography;

namespace PrimeirosExerciciosUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }

        }
    }
}