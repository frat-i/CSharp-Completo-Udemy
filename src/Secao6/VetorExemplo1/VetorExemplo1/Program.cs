using System.Globalization;
namespace VetorExemplo1;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];
        for (int i = 0; i < n; i++)
        {
            vet[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0.0;
        for (int i = 0; i < n; i++)
        {
            soma  += vet[i];
        }

        double avg = soma / n;

        Console.WriteLine(avg.ToString("C"));
    }
}