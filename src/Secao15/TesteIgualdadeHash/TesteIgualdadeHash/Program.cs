using TesteIgualdadeHash.Entities;
namespace TesteIgualdadeHash;

class Program
{
    static void Main(string[] args)
    {
        HashSet<Product> p = new HashSet<Product>();

        p.Add(new Product("TV", 900.00));
        p.Add(new Product("Notebook", 1200.00));

        HashSet<Point> point = new HashSet<Point>();

        point.Add(new Point(3, 4));
        point.Add(new Point(5, 10));

        Product product = new Product("Notebook", 1200.00);
        Console.WriteLine(p.Contains(product));// dá falso pq como product é um tipo referencia e não possui gethashcode e
                                               // equals a comparação é feita com base pra onde ele aponta na memória
                                               // e como ele aponta para um lugar diferente o resultado se torna falso
                                               // apos adicionar gethashcode e equals ele verifica e da true
                                               // mesmo sendo outro obj o conteudo é igual

        Point pointp = new Point(5, 10);
        Console.WriteLine(point.Contains(pointp)); // dá verdadeiro pq o contains para o tipo struct compara os valores


        //HashSet<string> set = new HashSet<string>();

        //set.Add("Maria");
        //set.Add("Alex");

        //Console.WriteLine(set.Contains("Maria")); //primeiro ele usa o gethashcode e caso confirme ele procede para usar o equals 

    }
}