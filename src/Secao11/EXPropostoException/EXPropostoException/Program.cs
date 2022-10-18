using EXPropostoException.Entities;
using EXPropostoException.Entities.Exceptions;
using System;

namespace EXPException;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double accountBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double accountWithdrawLimit = double.Parse(Console.ReadLine());

            Account account = new(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);
            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine());
            account.Withdraw(amountWithdraw);
            Console.Write($"New balance: {account.Balance}");
        }
        catch(DomainException e)
        {
            Console.WriteLine($"Withdraw error: {e.Message}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format error : {e.Message}");
        }
    }
}