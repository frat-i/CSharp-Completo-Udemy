using ExercicioFixacaoLista;

namespace ExercicioFixacao;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Quantos funcionarios vai colocar?: ");
        int n = int.Parse(Console.ReadLine());
        List<Funcionario> lista = new List<Funcionario>(); // da pra abrir uma lista com classe

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Digite o id do funcionario: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do salario do funcionario: ");
            double salarioFunc = double.Parse(Console.ReadLine());

           lista.Add(new Funcionario(id, nome, salarioFunc));
        }

        Console.Write("Digite o funcionario que tera o salario aumentado: ");
        int funcAcha = int.Parse(Console.ReadLine());

        Funcionario funcionario = lista.Find(f => f.Id == funcAcha);
        if(funcionario != null)
        {
            Console.Write("Digite a porcentagem de aumento: " );
            double porcentagemAumento = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagemAumento);

        }
        else 
        { 
            Console.Write("Funcionario nao existe");
        }

        Console.Write(funcionario);




    }
}