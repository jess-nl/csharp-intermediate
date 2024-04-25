using System;

namespace Fields
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); // this clears the orders field out and if you wanna avoid that, that's when you should use the readonly modifier

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
