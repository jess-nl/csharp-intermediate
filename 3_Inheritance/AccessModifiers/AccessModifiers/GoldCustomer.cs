using System;
namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            // var rating = this.CalculateRating(excludeOrders: true); // this won't work 'cause CalculateRating() has been removed from its parent
        }
    }
}
