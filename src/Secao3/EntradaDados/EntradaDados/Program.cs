using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1 ENTRADA DE DADOS

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            ////string s = Console.ReadLine(); jeito 1
            ////string[] vet = s.Split(' ');
            //string[] vet = Console.ReadLine().Split(' ');
            //string a = vet[0];
            //string b = vet[1];
            //string c = vet[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            //PARTE 2 ENTRADA DE DADOS

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio Proposto


            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}