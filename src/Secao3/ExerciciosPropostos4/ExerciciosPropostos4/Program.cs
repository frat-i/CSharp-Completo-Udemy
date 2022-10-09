using System;
using System.Globalization;

namespace ProjetoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1

            //Console.Write("Digite um valor até 1000 e maior que 1: ");
            //int x = int.Parse(Console.ReadLine());



            //for (int i = 1; i <= x; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercicio 2

            //Console.Write("Digite o valor: ");
            //int n = int.Parse(Console.ReadLine());

            //int count_in = 0;
            //int count_out = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if(x >=10 && x <= 20)
            //    {
            //        count_in++;
            //    }
            //    else
            //    {
            //        count_out++;
            //    }

            //}

            //Console.WriteLine(count_in + " in");
            //Console.WriteLine(count_out + " out");

            //Exercicio 3
            //Console.Write("Digite o valor de notas a serem avaliadas: ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            //}

            //Exercicio 4 
            //Console.Write("Digite o valor de operações: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');
            //    double n1 = double.Parse(line[0]);
            //    double n2 = double.Parse(line[1]);

            //    if(n2 == 0)
            //    {
            //        Console.WriteLine("Divisao impossivel");
            //    }
            //    else
            //    {
            //        double resultado = (double)n1 / n2;
            //        Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            ////Exercicio 5
            //Console.Write("Digite o valor de repetições: ");
            //int n = int.Parse(Console.ReadLine());
            //int fatorial = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //      fatorial = fatorial * i;

            //}

            //Console.WriteLine(fatorial);

            //Exercicio 6
            //Console.Write("Digite o valor : ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercicio 7 
            Console.Write("Digite o valor para a contagem de linhas : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = (int)i * i;
                int cubo = (int)i * i * i;


                Console.Write(i + " ");
                Console.Write(quadrado + " ");
                Console.Write(cubo + " ");
                Console.WriteLine("");

            }


        }
    }
}
