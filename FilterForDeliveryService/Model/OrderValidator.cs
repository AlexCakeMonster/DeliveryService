namespace FilterForDeliveryService.Model
{
    public class OrderValidator
    {
        public bool ValidateOrder(Order order)
        {            
            if (string.IsNullOrWhiteSpace(order.OrderId))
            {
                Logger.Error("Неверный идентификатор заказа.");
                return false;
            }
            if (order.Weight <= 0)
            {
                Logger.Error($"Неверный вес заказа: {order.Weight}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(order.District))
            {
                Logger.Error("Район заказа не указан.");
                return false;
            }
            if (order.DeliveryDateTime == DateTime.MinValue)
            {
                Logger.Error("Неверная дата и время доставки.");
                return false;
            }

            return true;
        }
    }
}
