using ClassesAbstratas.Entities;
using System;
using System.Globalization;

namespace ClassesAbstratas;

class Program
{
    static void Main(string[] args)
    {
        List<Account> list = new List<Account>();

        list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
        list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

        double sum = 0;

        foreach (Account account in list)
        {
            sum += account.Balance;
        }

        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (Account account in list)
        {
            account.Withdraw(10.00);
        }

        foreach (Account account in list)
        {
            Console.WriteLine($"Saldo atualizado para a conta {account.Number} : {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}" );
        }
    }
}