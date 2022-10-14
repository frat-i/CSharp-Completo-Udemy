using System;

namespace UpcastingEDowncasting;

class Program
{
    static void Main(string[] args)
    {
        // UPCASTING
        int UC_numeroInt = 10;
        double UC_numeroDouble = UC_numeroInt;

        // DOWNCASTING
        double DC_numeroDouble = 25.5;
        int DC_numeroInt = (int)DC_numeroDouble;

        double DC2_numeroDouble = 25.77;
        long DC_numeroLong = (long)DC2_numeroDouble;

        Console.WriteLine($"UpCasting result: {UC_numeroDouble}");
        Console.WriteLine($"DownCasting result: {DC_numeroInt}");
    }
}