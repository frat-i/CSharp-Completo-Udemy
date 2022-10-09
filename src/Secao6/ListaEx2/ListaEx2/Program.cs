using System.Collections.Generic;
namespace ListaEx2;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Paulo");
        list.Add("Arnaldo");
        list.Add("Ana");
        list.Add("Jao cringe");
        list.Insert(3, "Locsgay");
        list.Add("Anao peludo");

        foreach (string pessoa in list)
        {
            Console.WriteLine(pessoa);
        }

        Console.Write("Contador da lista: " + list.Count);

        Console.WriteLine("");

        string s1 = list.Find(c => c.StartsWith("A")); // expressao lambda -> ve conversa com o gabriel q ele explica
        Console.WriteLine("Primeira pessoa que o nome começa com A: " + s1);

        string s2 = list.FindLast(c => c.StartsWith("A") || c.StartsWith("a")); // expressao lambda -> ve conversa com o gabriel q ele explica
        Console.WriteLine("Ultima pessoa que o nome começa com A: " + s2);

        int pos1 = list.FindIndex(c => c.StartsWith("A"));
        Console.WriteLine("1 posicao com A: " + pos1);

        int pos2 = list.FindLastIndex(c => c.StartsWith("A"));
        Console.WriteLine("Ultima posicao com A: " + pos2);

        List<string> list2 = list.FindAll(c => c.Length <= 5);
        Console.WriteLine("-------------------");
        foreach(string cliente in list2)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("------------");
        list.RemoveRange(1, 2);
        foreach (string cliente in list)
        {
            Console.WriteLine(cliente);
        }

        list.RemoveAt(3); // ta tirando a Ana pq o locsgay ta inserido na posicaçao 2
        Console.WriteLine("------------");
        foreach(string cliente in list)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("------------");
        list.RemoveAll(c => c.StartsWith("A"));
        foreach(string cliente in list)
        {
            Console.WriteLine(cliente);
        }


    }

    //static bool EncontraLetra(string l)
    //{
    //    return l.StartsWith("A");
    //}

    //static bool EncontraLetra2(string l1)
    //{
    //    return l1[0] == 'A';
    //}
}