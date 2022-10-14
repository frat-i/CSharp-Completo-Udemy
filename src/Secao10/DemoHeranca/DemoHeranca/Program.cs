using System;
using DemoHeranca.Entities;
namespace DemoHeranca;

class Program
{
    static void Main(string[] args)
    {
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 6900.00, 1000.00) ;

        Console.WriteLine(account.Balance);

    }
}