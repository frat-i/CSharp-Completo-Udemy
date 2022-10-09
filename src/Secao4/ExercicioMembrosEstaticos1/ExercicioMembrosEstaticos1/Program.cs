using ExercicioMembrosEstaticos1;
using System;
using System.Globalization;

namespace ExercMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar?: ");
            double valorCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares vc vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConverterDolar(qtd, valorCotacao); // criando uma variavel que envia as outras variaveis necessarias para fazer o calculo

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
  
        }
    }
}