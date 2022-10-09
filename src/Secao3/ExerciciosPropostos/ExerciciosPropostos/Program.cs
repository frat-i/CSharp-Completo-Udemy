using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //double n1 = double.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine());

            //Console.WriteLine(n1 + n2);

            //Exercicio 2
            //double raio = double.Parse(Console.ReadLine());
            //double pi = 3.14159;
            //double area = pi * (raio * raio);

            //Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

            //Exercicio 3 
            //double a, b, c, d, dif;

            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //c = double.Parse(Console.ReadLine());
            //d = double.Parse(Console.ReadLine());

            //dif = (a * b - c * d);

            //Console.WriteLine("Diferença é : " + dif);

            //Exercicio 4
            //int numeroFuncionario, horasTrabalhadas;
            //double valorHora, salario;

            //numeroFuncionario = int.Parse(Console.ReadLine());
            //horasTrabalhadas = int.Parse(Console.ReadLine());
            //valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = horasTrabalhadas * valorHora;

            //Console.WriteLine("Número = " + numeroFuncionario + "\nSalario = " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 5
            //int codigoPeca1, codigoPeca2, numeroPeca1, numeroPeca2;
            //double valorPeca1, valorPeca2, total;

            //string[] vet1 = Console.ReadLine().Split(' ');
            //codigoPeca1 = int.Parse(vet1[0]);
            //numeroPeca1 = int.Parse(vet1[1]);
            //valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            //string[] vet2 = Console.ReadLine().Split(' ');
            //codigoPeca2 = int.Parse(vet2[0]);
            //numeroPeca2 = int.Parse(vet2[1]);
            //valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //total = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

            //Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 6
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));












        }
    }
}