using FilterForDeliveryService;
using FilterForDeliveryService.Model;

namespace FilterForDeliveryServiceTests
{
    [TestClass]
    public class OrderValidatorTests
    {
        [TestMethod]
        public void ValidateOrder_Order_True()
        {
            Order order = new Order
            {
                OrderId = "002",
                Weight = 3.0,
                District = "B",
                DeliveryDateTime = new DateTime(2024, 10, 22, 12, 10, 00)
            };
            OrderValidator validator = new OrderValidator();
            Assert.IsTrue(validator.ValidateOrder(order));
        }
        [TestMethod]
        public void ValidateOrder_Order_False()
        {
            Logger.Init("deliveryLog");
            Order order = new Order
            {
                OrderId = null,
                Weight = 0.0,
                District = null,
                DeliveryDateTime = new DateTime(2024, 10, 22, 12, 10, 00)
            };
            OrderValidator validator = new OrderValidator();
            Assert.IsFalse(validator.ValidateOrder(order));
        }
    }
}

