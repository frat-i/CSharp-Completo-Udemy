using ExercicioResolvidoLinq.Entities;
using System.Globalization;

namespace ExecResolvidoLinq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        List<Product> list = new List<Product>();

        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }
        }

        // preco medio produtos
        var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
        Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();

        var productNames = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
        foreach (var product in productNames)
        {
            Console.WriteLine(product);
        }

    }
}