using System;
using System.Globalization;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1,n2,n3);

            Console.WriteLine("Maior: " + resultado);

            static int Maior(int a,int b, int c)//saida(tipo) da funcao em 2 lugar
            {
                int m;

                if(a > b && a > c)
                {
                    m = a;
                }
                else if(b > c)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }

                return m;


            } 

        }
    }
}