using ExemploAction.Entitites;

namespace ExemploAction;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        //list.ForEach(UpdatePrice);

        //Action<Product> act = UpdatePrice;
        //list.ForEach(act);

        //Action<Product> act = p => { p.Price += p.Price * 0.1; }; //se usa {} para mostrar que tem um corpo mas não retorna nada (void)
        //list.ForEach(act);

        list.ForEach(p => { p.Price += p.Price * 0.1; });

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }

    }

    static void UpdatePrice(Product p)
    {
        p.Price += p.Price * 0.1;
    }
}