using FilterForDeliveryService.Model;
using FilterForDeliveryService.View;
using Newtonsoft.Json;

namespace FilterForDeliveryService.Controller
{
    internal class FileJsonWriter
    {
        public void FileWriter(string deliveryOrder,List<Order> filteredOrders)
        {
            try
            {
                File.WriteAllText(deliveryOrder, JsonConvert.SerializeObject(filteredOrders, Formatting.Indented));
            }
            catch
            {
                throw new Exception($"Ошибка при создании файла {deliveryOrder}.");
            }                   

            Logger.Info($"Результаты успешно записаны в файл {deliveryOrder}.");
        }
    }    
}
