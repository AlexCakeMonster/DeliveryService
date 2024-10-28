using FilterForDeliveryService.Model;

namespace FilterForDeliveryService.View
{
    public class OrderView
    {
        public void ShowResult(List<Order> orders)
        {
            foreach (var order in orders)
            { 
                Console.WriteLine($"Заказ номер: {order.OrderId}, район доставки: {order.District}, время доставки: {order.DeliveryDateTime}");
            }

            Console.ReadKey();
        }
    }
}
