namespace ExemploHashSetSortedSet;

class Program
{
    static void Main(string[] args)
    {
        //HashSet<string> strings = new HashSet<string>();

        //strings.Add("TV");
        //strings.Add("Notebook");
        //strings.Add("Tablet");

        //Console.WriteLine(strings.Contains("Computer"));
        //Console.WriteLine();

        //foreach (string s in strings) //como não existem posições o for(int i = 0; i < x...) não funciona e é necessário usar foreach para listagem
        //{
        //    Console.WriteLine(s);
        //}

        SortedSet<int> a = new SortedSet<int>() { 10, 2, 4, 5, 6, 8, 0 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        PrintCollection(a);

        //union with

        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        PrintCollection(c);

        //interseccao

        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintCollection(d);

        //diferenca

        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintCollection(e);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}