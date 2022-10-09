using PrimeirosExerciciosDois;
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace PrimeirosExerciciosUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo Funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2;
            Console.Write("Salario médio: " + media.ToString("F2",CultureInfo.InvariantCulture));






        }
    }
}
