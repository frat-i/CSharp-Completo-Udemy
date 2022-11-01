using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salaryVar = double.Parse(Console.ReadLine());
        Console.WriteLine();

        List<Employee> list = new List<Employee>();
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }

                var func1 = list.Where(e => e.Salary > salaryVar).OrderBy(e => e.Email).Select(e => e.Email);
                foreach (string email in func1)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine();

                // soma salario de todos q o nome começa com M
                var func2 = list.Where(e => e.Name.StartsWith("M")).Sum(e => e.Salary);
                Console.Write($"Soma todos os salários de funcionários que o nome começa com M: {func2.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}