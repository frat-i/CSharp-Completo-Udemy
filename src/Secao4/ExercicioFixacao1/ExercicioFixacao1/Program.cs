using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área: " +  ret.CalcArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + ret.CalcPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.CalcDiagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}