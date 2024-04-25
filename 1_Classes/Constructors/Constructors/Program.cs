using System;
using System.Collections.Generic;

namespace Constructors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Jay");
            customer.Id = 1;
            customer.Name = "Jay";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Orders);
        }
    }
}
