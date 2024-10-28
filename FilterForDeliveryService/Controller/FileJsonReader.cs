using FilterForDeliveryService.Model;
using Newtonsoft.Json;

namespace FilterForDeliveryService.Controller
{
    public class FileJsonReader
    {
        private OrderValidator validator = new();
        public List<Order>? Reader(string InputPath)
        {            
            if (File.Exists(InputPath))
            {
                string jsonData = File.ReadAllText(InputPath);
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

                if (orders.Count == 0)
                {
                    throw new Exception($"Файл {InputPath} не имеет содержимого");
                }

                List<Order> validOrders = new();
                foreach (var order in orders)
                {
                    if (validator.ValidateOrder(order))
                    {
                        validOrders.Add(order);
                    }
                    else
                    {
                        Logger.Warn($"Заказ {order.OrderId} не прошел валидацию.");
                    }
                }
                return validOrders;
            }
            else
            {
                throw new Exception("Файл с вводными данными не найден");
            }            
        }
    }
}
