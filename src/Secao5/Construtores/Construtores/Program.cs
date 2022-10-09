using Construtores;
using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";


            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);





            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////Console.Write("Quantidade em estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());

            //// Produto p = new Produto(nome, preco, quantidade);
            //Produto p = new Produto(nome, preco);

            //Produto p2 = new Produto()
            //{
            //    Nome = "TV",
            //    Preco = 500.00,
            //    Quantidade = 20

            //};

            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            //int qtd = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qtd);
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            //qtd = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qtd);
            //Console.WriteLine("Dados atualizados: " + p);
        }
    }
}