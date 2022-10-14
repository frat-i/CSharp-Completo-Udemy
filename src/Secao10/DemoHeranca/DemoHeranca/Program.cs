using System;
using System.Globalization;
using DemoHeranca.Entities;
namespace DemoHeranca;

class Program
{
    static void Main(string[] args)
    {
        //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 6900.00, 1000.00) ;

        //Console.WriteLine(account.Balance);

        //Account acc = new(number: 1001, holder:"Bob Brown", balance: 0.00);
        //BusinessAccount bacc = new(number: 1002, holder: "Jao Arcus", balance: 0.00, loanLimit: 500.00); //(Devendo pro takezo)

        ////UPCASTING

        //Account acc1 = bacc; // bacc é uma account então funciona 10
        //Account acc2 = new BusinessAccount(number: 1003, holder: "Maria", balance: 0.00, loanLimit: 500.00); //mesma coisa ^ mas intanciando uma nova
        //Account acc3 = new SavingsAccount(number: 1004, holder: "Locsfudz", balance: 0.00, interestRate: 0.01); //mesma coisa ^ mas instanciando uma nova

        //// DOWNCASTING

        //BusinessAccount acc4 = (BusinessAccount)acc2;
        //acc4.Loan(100.0);

        //// BusinessAccount acc5 = (BusinessAccount)acc3;
        //if (acc3 is BusinessAccount) // is é igual ao ingles mesmo
        //{
        //    //BusinessAccount acc5 = (BusinessAccount)acc3;
        //    BusinessAccount acc5 = acc3 as BusinessAccount; // <- AS é outra maneira de fazer encapsulamento ()
        //    acc5.Loan(200.0);
        //    Console.WriteLine("Loan!");
        //}

        //if (acc3 is SavingsAccount)
        //{
        //    //SavingsAccount acc5 = (SavingsAccount)acc3;
        //    SavingsAccount acc5 = acc3 as SavingsAccount;
        //    acc5.UpdateBalance();
        //    Console.WriteLine("Update!");
        //}

        Account acc1 = new(number:1001,holder:"Alex",balance: 100.00);
        Account acc2 = new SavingsAccount(number: 1002, holder: "Maria", balance: 100.00, interestRate: 0.01);

        acc1.WithDraw(10.00);
        acc2.WithDraw(10.00);

        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);







    }
}