using System;
using System.Globalization;

namespace ExercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final : " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if(aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram : " + aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " pontos");
            }
           
        }
    }
}