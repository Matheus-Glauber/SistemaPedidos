using Modulo9.Models;
using Modulo9.Models.Enums;
using System;

namespace Modulo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, DateTime.Now, OrderStatus.PendingPayment);

            Console.WriteLine(order1.ToString());

            string status = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(status);

            OrderStatus os = Enum.Parse<OrderStatus>(status);

            Console.WriteLine(os);
        }
    }
}
