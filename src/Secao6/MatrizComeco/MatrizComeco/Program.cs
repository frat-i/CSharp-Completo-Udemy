namespace MatrizComeco;

class Program
{
    static void Main(string[] args)
    {
        double[,] mat = new double[5, 10];
        Console.WriteLine(mat.Length); // faz [x,y] -> x * y
        Console.WriteLine(mat.Rank); // quantas coisas dentro de [] tem
        Console.WriteLine(mat.GetLength(0)); // comprimento da coluna 
        Console.WriteLine(mat.GetLength(1)); // comprimento da linha
    }
}