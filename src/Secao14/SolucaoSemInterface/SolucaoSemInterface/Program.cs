﻿using SolucaoSemInterface.Entities;
using SolucaoSemInterface.Services;
using System.Globalization;
namespace SolucaoSemInterface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data: ");
        Console.Write("Car model: ");
        string model = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine());
        Console.Write("Enter price per day: ");
        double pricePerDay = double.Parse(Console.ReadLine());


        CarRental carRental = new(start, finish, new Vehicle(model));

        RentalService rentalservice = new(pricePerHour, pricePerDay);

        rentalservice.ProcessInvoice(carRental);

        Console.WriteLine("Invoice: ");
        Console.WriteLine(carRental.Invoice);



    }
}