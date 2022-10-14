using ExFixacaoEnum.Entities;
using ExFixacaoEnum.Entities.Enums;
using System;
using System.Runtime.CompilerServices;

namespace ExFixacaoEnum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");
        Console.Write("Name: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string clientEmail = Console.ReadLine();
        Console.Write("Birth date: (dd/mm/yyyy): ");
        DateOnly clientBirthDate = DateOnly.Parse(Console.ReadLine());

        Client client = new(name: clientName, email: clientEmail, dateBirth: clientBirthDate);

        Console.WriteLine("Enter order data: ");
        Console.Write("Status: ");
        string status = Console.ReadLine();
        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        Order order = new();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} data");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());
            order.AddItem(new OrderItem(productQuantity, productPrice, new Product(productName, productPrice)));

        }

        order.VincularCliente(client);
        order.AtribuirStatusPedido(status);
        


        Console.WriteLine();

        Console.WriteLine("ORDER SUMMARY: ");
        Console.WriteLine(order.ToString());


    }
}