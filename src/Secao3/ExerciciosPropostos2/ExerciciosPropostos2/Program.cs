using System;
using System.Globalization;

namespace ExerciciosPropostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //int x = int.Parse(Console.ReadLine());

            //if (x < 0)
            //{
            //    Console.WriteLine("Positivo");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}

            //Exercicio 2
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Impar");
            //}

            //Exercicio 3 
            //string[] valores = Console.ReadLine().Split(' ');
            //int a = int.Parse(valores[0]);
            //int b = int.Parse(valores[1]);

            //if(a % b == 0 || b % a == 0)
            //{
            //    Console.WriteLine("São Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Não são multiplos");
            //}

            //Exerccicio 4
            //string[] horas = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(horas[0]);
            //int horaFinal = int.Parse(horas[1]);

            //int duracao;

            //if( horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}

            //Console.WriteLine("O jogo durou " + duracao + " horas");

            //Exercicio 5
            //string[] numeros = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(numeros[0]);
            //double quantidade = double.Parse(numeros[1]);
            //double total = 0.0;

            //if(codigo == 1)
            //{
            //    total = quantidade * 4.00;
            //}
            //else if(codigo == 2)
            //{
            //    total = quantidade * 4.50;
            //}   
            //else if(codigo == 3)
            //{
            //    total = quantidade * 5.00;
            //}
            //else if(codigo == 4)
            //{
            //    total = quantidade * 2.00;
            //}
            //else
            //{
            //    total = quantidade * 1.50;
            //}

            //Console.WriteLine("O total é de : R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 6
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if(valor  < 25.0)
            //{
            //    Console.WriteLine("Está no intervalo [0,25]");
            //}
            //else if (valor < 50.0)
            //{
            //    Console.WriteLine("Está no intervalo [25,50]");
            //}
            //else if(valor < 75.0)
            //{
            //    Console.WriteLine("Está no intervalo [50,75]");
            //}
            //else if(valor  < 100.0)
            //{
            //    Console.WriteLine("Está no intervalo [75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Está fora do intervalo");
            //}

            //ou -> aqui já testa primeiro se o valor está dentro ou não. ^ testa o valor em último

            //if (valor < 0.00 || valor > 100.0)
            //{
            //    Console.WriteLine("Está fora do intervalo");
            //}
            //else if (valor < 25.0)
            //{
            //    Console.WriteLine("Está no intervalo [0,25]");
            //}
            //else if (valor < 50.0)
            //{
            //    Console.WriteLine("Está no intervalo [25,50]");
            //}
            //else if (valor < 75.0)
            //{
            //    Console.WriteLine("Está no intervalo [50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Está no intervalo [75,100]");
            //}

            //Exercicio 7
            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if( x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if( x == 0 && y > 0 )
            //{
            //    Console.WriteLine("Eixo y");
            //} 
            //else if( x > 0 && y == 0 )
            //{
            //    Console.WriteLine("Eixo x");
            //}
            //else if( x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if(x < 0 &&  y > 0)
            //{
            //    Console.WriteLine("Q2");
            //} 
            //else if(x < 0 &&  y < 0)
            //{
            //    Console.WriteLine("Q3");
            //} 
            //else 
            //{
            //    Console.WriteLine("Q4");
            //}

            //Exercicio 8
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if(salario < 2000.00)
            {
                imposto = 0.0;
            }
            else if(salario > 2000.01 && salario <= 3000.00)
            {
                imposto = salario * 0.08;
            }
            else if(salario <= 4500.00)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08; // aqui os 1000 reais do 2000 até 3000 são calculados com 8% e o que sobra a mais antes dos 4500 é 18%
            }
            else if(salario > 4500)
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08; // vc tem o imposto de 1000 R$ 8% somados com o R$ 1500 18% e o resto da diferença em 28%
            }

            if(imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }

            else
            {
                Console.WriteLine("imposto: R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            // || OU && E ! DIFERENTE

        }
    }
}