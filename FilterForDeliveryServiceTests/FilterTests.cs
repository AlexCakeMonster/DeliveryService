using FilterForDeliveryService;
using FilterForDeliveryService.Controller;
using FilterForDeliveryService.Model;

namespace FilterForDeliveryServiceTests
{
    [TestClass]
    public class FilterTests
    {
        List<Order> orders;
        [TestInitialize]
        public void Initialization()
        {
            Logger.Init("deliveryLog");
            orders = new List<Order>();
            orders.Add(new Order
            {
                OrderId = "002",
                Weight = 3.0,
                District = "B",
                DeliveryDateTime = new DateTime(2024, 10, 22, 12, 10, 00)
            });            
        }

        [TestMethod]
        public void FilterOrders_OrdersDistrictFirstDeliveryTime_FilteredOrders()
        {            
            Filter filter = new Filter();
            List<Order> filteredOrders = new List<Order>();
            filteredOrders = filter.FilterOrders(orders, "B", new DateTime(2024, 10, 22, 12, 00, 00));
            Assert.IsTrue(filteredOrders.Count > 0);
        }

        [TestMethod]
        public void FilterOrders_OrdersDistrictFirstDeliveryTime_Null()
        {
            Filter filter = new Filter();
            List<Order> filteredOrders = new List<Order>();
            filteredOrders = filter.FilterOrders(orders, "C", new DateTime(2024, 10, 22, 12, 00, 00));
            Assert.IsTrue(filteredOrders.Count == 0);
        }
    }
}