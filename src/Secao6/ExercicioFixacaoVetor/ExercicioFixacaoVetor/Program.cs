using ExercicioFixacaoVetor;

namespace FixacaoVetor;

class Program
{
    static void Main(string[] args)
    {

        Estudante[] vet = new Estudante[10]; // maximo de 10 quartos alugados na pousada
        Console.WriteLine("Quantos quartos serao alugados?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Aluguel: " + i );
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vet[quarto] = new Estudante(nome, email); // vet[quarto] -> vai instanciar um novo estudante no vetor 
                                                      // e o número do quarto vai ser a posição dele no vetor

        }


        Console.WriteLine("Salas ocupadas: ");
        for (int i = 0; i < 10; i++)
        {
            if (vet[i] != null) // verifica individualmente cada linha do vetor Estudante[] para saber se tem algum dado ou não
            {
                Console.WriteLine(i + ": " + vet[i]);
            }
        }
        
    }
}