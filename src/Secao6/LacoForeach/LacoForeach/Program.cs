namespace Foreach;

class Program
{
    static void Main(string[] args)
    {
        string[] vet = new string[] { "Maria", "Paulo", "Jao" };

        foreach (string obj in vet)
        {
            Console.WriteLine(obj);
        }
    }
}