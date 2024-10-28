using FilterForDeliveryService.Model;

namespace FilterForDeliveryService.Controller
{
    public class Filter
    {
        public List<Order> FilterOrders(List<Order> orders, string district, DateTime firstDeliveryTime)
        {               
            var filteredOrders = orders.Where(order =>
                order.District == district &&
                order.DeliveryDateTime >= firstDeliveryTime &&
                order.DeliveryDateTime <= firstDeliveryTime.AddMinutes(30)).ToList();

            Logger.Info($"Найдено {filteredOrders.Count} заказов для района {district} в течение 30 минут после {firstDeliveryTime}.");
            return filteredOrders;
        }
    }
}
