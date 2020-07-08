using Modulo9.Models;
using Modulo9.Models.Enums;
using System;

namespace Modulo9
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Inserting datas a client
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // Instantiating a client
            Client client = new Client(name, email, birthDate);

            // Instantiating a Order
            Order order = new Order();
            order.Client = client;

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            order.Status = status;
            order.Moment = DateTime.Now;

            Console.Write("How many items to this order?: ");
            int quantityOrders = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityOrders; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
