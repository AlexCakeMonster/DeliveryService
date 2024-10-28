using FilterForDeliveryService.Controller;
using FilterForDeliveryService.Model;

namespace FilterForDeliveryServiceTests
{
    [TestClass]
    public class FileJsonReaderTests
    {
        [TestMethod]
        public void Reader_FilePath_NotNull()
        {
            FileJsonReader reader = new FileJsonReader();
            List<Order> orders = new List<Order>();
            orders = reader.Reader("orders.json");
            Assert.IsTrue(orders.Count > 0);
        }
    }
}