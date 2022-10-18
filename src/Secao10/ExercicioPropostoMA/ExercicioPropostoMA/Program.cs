using ExercicioPropostoMA.Entities;
using System;
using System.Globalization;

namespace EXPropostoMA;

class Program
{
    static void Main(string[] args)
    {
        List<Taxpayer> list = new List<Taxpayer>();

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            Console.Write("Individual or Company (i/c)? ");
            char ch = char.Parse(Console.ReadLine().ToString().ToLower());
            Console.Write("Name: ");
            string taxPayerName = Console.ReadLine();
            Console.Write("Anual Income: ");
            double taxPayerAnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            if(ch == 'i')
            {
                Console.Write("Health expenditures: ");
                double individualHealthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Individual(individualHealthExpenditures, taxPayerName, taxPayerAnualIncome));
            }
            else
            {
                Console.Write("Number of employees: ");
                int companyNumberEmployees = int.Parse(Console.ReadLine());
                list.Add(new Company(companyNumberEmployees, taxPayerName, taxPayerAnualIncome));
            }


        }

        Console.WriteLine();

        double sum = 0.0;
        Console.WriteLine("TAXES PAID: ");
        foreach(Taxpayer taxpayer in list)
        {
            double tax = taxpayer.Tax();
            Console.WriteLine(taxpayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            sum += tax;
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

    }
}