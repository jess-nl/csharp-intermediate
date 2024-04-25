using System;
namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // once the CalculateRating() is removed here, this will affect the GoldCustomer class (this is why you should avoid protected unless there's a valid reason to use it)
        //public void Promote()
        //{
        //    var rating = CalculateRating(excludeOrders: true);
        //    if (rating == 0)
        //        Console.WriteLine("Promoted to Level 1");
        //    else
        //        Console.WriteLine("Promoted to Level 2");
        //}

        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}

        public void Promote()
        {
            Console.WriteLine("Promote logic changed");
        }
    }
}
