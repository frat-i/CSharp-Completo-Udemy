using System;
using System.Globalization;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);  

            ////a -= 2;
            ////Console.WriteLine(a);  
            
            //a *= 3;
            //Console.WriteLine(a);

            ////a /= 2;
            ////Console.WriteLine(a);  

            ////a %= 2;
            ////Console.WriteLine(a);

            string s = "ABC";

            Console.WriteLine(s);

            s += "DEF";

            Console.WriteLine(s);

            Console.WriteLine("----------------------------------");

            int a = 10;
            int b = a++; // ++a faz o calculo primeiro, resultado fica 11



            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
