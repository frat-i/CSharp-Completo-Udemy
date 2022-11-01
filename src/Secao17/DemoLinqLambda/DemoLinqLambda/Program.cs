using DemoLinqLambda.Entities;

namespace DemoLinqLambda;

class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T item in collection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Category c1 = new(1, "Tools", 2);
        Category c2 = new(2, "Computers", 1);
        Category c3 = new(3, "Eletronics", 1);

        List<Product> products = new List<Product>()
        {
            new(1, "Computer", 1100.0, c2),
            new(2, "Hammer", 90.0, c1) ,
            new(3, "TV", 1700.0, c3) ,
            new(4, "Notebbok", 1300.0, c2) ,
            new(5, "Saw", 80.0, c1) ,
            new(6, "Tablet", 700.0, c2) ,
            new(7, "Camera", 700.0, c3) ,
            new(8, "Printer", 350.0, c3) ,
            new(9, "Macbook", 1800.0, c2) ,
            new(10, "Soundbar", 700.0, c3) ,
            new(11, "Level", 70.0, c1)
        };

        // testes sem o valor default envolvido 
        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        Print("TIER 1 AND PRICE < 900.00 : ", r1);

        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); // o select ali transforma ao invés da linha inteira só o nome
        Print("NAME OF PRODUCTS FROM TOOLS : ", r2);

        var r3 = products.Where(p => p.Name.StartsWith("C")).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //para pegar primeira letra tbm serve p.Name[0] = 'C'
        Print("NAME OF PRODUCTS THAT START WITH 'C' AND ANONYMOUS OBJECT : ", r3);

        var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

        var r5 = r4.Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

        // testes com valor default envolvido
        var r6 = products.FirstOrDefault();
        Console.WriteLine($"First or default test 1 : {r6}");
        Console.WriteLine();
        var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        Console.WriteLine($"First or default test 2 : {r7}");
        Console.WriteLine();

        var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); //se tirar o sinlgeordefault o r8 se torna um IEnumerable, aqui ele está como Product
        Console.WriteLine($"SINGLE OR DEFAULT test 1: {r8}");
        Console.WriteLine();
        var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine($"SINGLE OR DEFAULT test 2: {r9}");
        Console.WriteLine();

        var r10 = products.Max(p => p.Price);
        Console.WriteLine($"Max price: {r10}");
        Console.WriteLine();
        var r11 = products.Min(p => p.Price);
        Console.WriteLine($"Min price: {r11}");
        Console.WriteLine();
        var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        Console.WriteLine($"Category 1 sum prices: {r12}");
        Console.WriteLine();
        var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
        Console.WriteLine($"Category 1 average price: {r13}");
        Console.WriteLine();
        var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
        Console.WriteLine($"Category 5 average price:  {r14}");
        Console.WriteLine();
        var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (a, b) => a + b); //0.0 cai como valor default
        Console.WriteLine($"Category 1 aggregate sum: {r15}");
        Console.WriteLine();
        var r16 = products.GroupBy(p => p.Category);
        foreach (IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine($"Category: {group.Key.Name}");
            foreach (Product product in group)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        };


    }
}