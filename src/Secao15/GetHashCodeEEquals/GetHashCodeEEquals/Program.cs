using GetHashCodeEEquals.Entities;

namespace ExemploGHSEquals;

class Program
{
    static void Main(string[] args)
    {

        Client a = new("Maria", "maria@gmail.com");
        Client b = new("Alex", "maria@gmail.com");

        Console.WriteLine(a.Equals(b)); //vai dar true pq atendeu aos criterios
        Console.WriteLine(a == b); // vai dar false pq sao dois objs diferentes
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());






        //string a = "Maria";
        //string b = "Maria";

        ////Console.WriteLine(a.Equals(b));

        //Console.WriteLine(a.GetHashCode());
        //Console.WriteLine(b.GetHashCode());




    }
}