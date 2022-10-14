using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

using System;
using System.Globalization;

namespace Enumeracoes;
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(txt);
        Console.WriteLine(os);
    }
}