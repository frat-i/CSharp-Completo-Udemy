

namespace Proposto;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> courseA = new HashSet<int>();
        HashSet<int> courseB = new HashSet<int>();
        HashSet<int> courseC = new HashSet<int>();

        try
        {
            Console.Write("How many students for course A? ");
            int courseAStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseAStudents; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                courseA.Add(codigo);
            }

            Console.Write("How many students for course B? ");
            int courseBStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseBStudents; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                courseB.Add(codigo);
            }
            Console.Write("How many students for course A? ");
            int courseCStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseCStudents; i++)
            {
                int codigo = int.Parse(Console.ReadLine());
                courseC.Add(codigo);
            }

            HashSet<int> total = new HashSet<int>(courseA);
            total.UnionWith(courseB);
            total.UnionWith(courseC);
            Console.Write($"Total Students: {total.Count}");



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}