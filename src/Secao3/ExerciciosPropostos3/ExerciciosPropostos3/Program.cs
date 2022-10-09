using System;
using System.Globalization;

namespace ExerciciosPropostos3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());

            //while(senha != 2002)
            //{
            //    Console.WriteLine("Senha Incorreta");
            //    Console.WriteLine("Digite a senha novamente");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");

            //Exercicio 2
            //string[] numeros = Console.ReadLine().Split(' ');
            //int n1 = int.Parse(numeros[0]);
            //int n2 = int.Parse(numeros[1]);

            //while(n1 != 0 && n2 != 0)
            //{

            //    if (n1 > 0 && n2 > 0)
            //    {
            //        Console.WriteLine("Q1");
            //    }
            //    else if (n1 < 0 && n2 > 0)
            //    {
            //        Console.WriteLine("Q2");
            //    }
            //    else if (n1 < 0 && n2 < 0)
            //    {
            //        Console.WriteLine("Q3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Q4");
            //    }
            //    numeros = Console.ReadLine().Split(' ');
            //    n1 = int.Parse(numeros[0]);
            //    n2 = int.Parse(numeros[1]);
            //}

            //Console.WriteLine("Invalido");

            //Exercicio 3
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite como vai reabastecer");
            int tipo = int.Parse(Console.ReadLine());


            while(tipo != 4) { 
                if(tipo == 1)
                {
                    alcool++;
                    Console.WriteLine("Digite como vai reabastecer");
                     tipo = int.Parse(Console.ReadLine());
                }
                else if (tipo == 2)
                {
                    gasolina++;
                    Console.WriteLine("Digite como vai reabastecer");
                    tipo = int.Parse(Console.ReadLine());
                }
                else if (tipo == 3)
                {
                    diesel++;
                    Console.WriteLine("Digite como vai reabastecer");
                    tipo = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Código Inválido, repita a ação");
                    tipo = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("MUITO OBRIGADO" +
                              "\nAlcool: " + alcool + 
                              "\nGasolina: " + gasolina + 
                              "\nDiesel: " + diesel);





        }


    }
}