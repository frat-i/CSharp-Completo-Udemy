using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Cincunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de pi " + CalculadoraPi.ToString("F2",CultureInfo.InvariantCulture));
        }

    
    }
}