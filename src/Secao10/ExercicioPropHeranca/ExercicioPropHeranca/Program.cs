using System;
using System.Globalization;
using ExercicioPropHeranca.Entities;

namespace ExPropHeranca;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter the number of Products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product {i} data: ");
            Console.Write("Commom, used or imported (c/u/i)? ");
            char ch = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Name: ");
            string productName = Console.ReadLine();
            Console.Write("Price: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'c')
            {

                list.Add(new Product(productName, productPrice));

            }
            else if (ch == 'u')
            {

                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(dateManufacture,productName,productPrice));

            }
            else{

                Console.Write("Custom fee: ");
                double productCustomFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new ImportedProduct(productCustomFee, productName, productPrice));

            }
            
        }

        Console.WriteLine("");

        Console.WriteLine("PRODUCTS:");

        foreach (Product product in list)
        {
            Console.WriteLine(product.Pricetag());
        }

    }
}