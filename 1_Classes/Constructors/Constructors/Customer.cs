using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // third
        public Customer() 
        {
            Orders = new List<Order>();
        }

        // second
        public Customer(int id)
            : this() 
        {
            this.Id = id;
        }

        // first we go here if there's a value, if not, go to second
        public Customer(int id, string name) 
            : this(id) 
        {
            //this.Id = id; this can be removed 'cause of : this(id)
            this.Name = name;
        }
    }
}
