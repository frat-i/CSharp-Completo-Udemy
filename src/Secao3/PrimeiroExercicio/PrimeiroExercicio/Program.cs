using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 52.234567;

            Console.WriteLine($"Produtos: \n {produto1}, cujo preço é $ {preco1}\n" +
                              $"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero} ");

            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (3 casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}