using Modulo9.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo9.Models
{
    class Order
    {        
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Client = cliente;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }
        
        public double Total()
        {
            double total = 0;
            foreach (var item in OrderItens)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            return Moment + ", " + Status;
        }
    }
}
