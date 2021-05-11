using System;

namespace InterfacesAndTestability
{
    public class OrderProcessor
    {
        //OrderProcessor doesn't know about IShippingCalculator. It just knows there is a class that can fulfill that need
        private readonly IShippingCalculator _shippingCalculator;

        // there is no reference to the shipping calculator concrete class, you're just
        // referencing an interface and this is an example of loose coupling.
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        
        //public OrderProcessor()
        //{
        //    _shippingCalculator = new ShippingCalculator();
        //}

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}   