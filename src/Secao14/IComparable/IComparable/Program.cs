using EXIEComparable.Entities;

namespace EXIEComparable;

class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\teste\in.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream) // enquanto não é o final do texto
                {
                    list.Add(new Employee(sr.ReadLine()));
                }

                list.Sort();
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error has occurred");
            Console.WriteLine(e.Message);
        }


    }
}