/*


// assembly references on mac visual studio 2019 presently doesn't work
// the following is the unit test code for windows visual studio

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfacesAndTestability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION


        // the test passes because we have InvalidOperationException in the OrderProcessor class
        // the test will fail if you comment out InvalidOperationException in the OrderProcessor class
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator);
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        // the test will pass 'cause order is shipped is true, one (1) order is true, shipping date set as tomorrow is true
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order) {
            return 1;
        }
    }
}


*/