namespace VetorExemplo2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Produto[] vet = new Produto[n];

        for (int i = 0; i < n; i++)
        {
            string nome = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());
            vet[i] = new Produto(nome, valor); //{ Nome = nome, Preco = valor}; // poderia ser feito com construtor
            //new Produto(nome,valor)
            //
        }

        double soma = 0.00;

        for (int i = 0; i < n; i++)
        {
            soma += vet[i].Preco;
        }

        double media = soma / n;

        Console.Write("Preco medio: " + media.ToString("C"));
       
    }
}