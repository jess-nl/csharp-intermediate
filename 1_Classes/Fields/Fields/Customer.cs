using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        //public List<Order> Orders; // this only necessary if using the constructor methord
        public readonly List<Order> Orders = new List<Order>();

        // instead you can initialize with the orders field like do above (either approaches are good, matter of taste)
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); // this won't work anymore 'cause of the readonly modifier we added. the error: A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)
            // ...
        }
    }
}
