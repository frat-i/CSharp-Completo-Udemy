using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ExFixacaoEnum.Entities.Enums;

namespace ExFixacaoEnum.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        private Client Client { get; set; }
        public List<OrderItem>Items { get; set; } = new List<OrderItem> { };
        public Order()
        {

        }

        public void AddItem(OrderItem orderitem)
        {
            Items.Add(orderitem);
        }

        public void RemoveItem(OrderItem orderitem)
        {
            Items.Remove(orderitem);
        }

        public void VincularCliente(Client client)
        {
            Client = client;
        }

        public void AtribuirStatusPedido(string status)
        {
            bool possivelConverter = Enum.TryParse<OrderStatus>(status, out OrderStatus result);
            if (!possivelConverter) throw new Exception(); // se nao pode converter -> tipo string para orderstatus

            Status = result;
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal(); 
            }

            return sum;
        }


        //STRINGBUILDER

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total: " + Total());

            return sb.ToString();
        }



    }
}
