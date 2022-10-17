using System;
using ExercicioResolvido1.Entities;
using System.Globalization;

namespace ExercicioResolvido1;

class Program
{
    static void Main(string[] args)
    {

        List<Employee> list = new List<Employee>();

        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Employ {i} data: ");
            Console.Write("Outsorced? (y/n): ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string employeeName = Console.ReadLine();
            Console.Write("Hours: ");
            int employeeHours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(employeeName,employeeHours, employeeValuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(employeeName,employeeHours,employeeValuePerHour));
                }

        }

        Console.WriteLine();
        Console.WriteLine("PAYMENTS: ");
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
        }



    }
}