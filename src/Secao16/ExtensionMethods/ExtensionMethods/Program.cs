namespace ExemploExtension;

class ProcessFiles
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45, DateTimeKind.Utc);
        Console.WriteLine(dt.ElapsedTime());

        DateTime dt2 = new DateTime(2022, 10, 28, 8, 10, 45, DateTimeKind.Utc);
        Console.WriteLine(dt2.ElapsedTime());

        string s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));

    }
}