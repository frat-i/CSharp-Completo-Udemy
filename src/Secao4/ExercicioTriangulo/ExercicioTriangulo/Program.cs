using System;
using System.Globalization;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo y: ");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.calcArea();

            double areaY = y.calcArea();

            Console.WriteLine("Área de x = " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Triangulo X tem a maior área");
            }
            else
            {
                Console.WriteLine("Triangulo Y  tem a maior área");
            }


        }
    }
}