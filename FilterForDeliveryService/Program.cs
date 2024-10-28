using FilterForDeliveryService.Controller;
using FilterForDeliveryService.Model;
using FilterForDeliveryService.View;
using System.Globalization;


namespace FilterForDeliveryService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var validator = new InputDataValidator();
            try
            {
                validator.InputdataValidation(args);
            }
            catch(Exception ex)
            {
                ErrorView.ShowError(ex.Message);
                return;
            }

            string cityDistrict = args[0];
            string inputPath = args[1];
            string firstDeliveryDateTimeString = args[2];
            string deliveryLog = args[3];
            string deliveryOrder = args[4];
            var reader = new FileJsonReader();
            var orderController = new Filter();
            var writer = new FileJsonWriter();
            var orderView = new OrderView();            

            try
            {       
                Logger.Init(deliveryLog);
                Logger.Info("Приложение запущено.");
                List<Order> validOrders = reader.Reader(inputPath);   
                List<Order> filteredOrders = orderController.FilterOrders(validOrders, cityDistrict,DateTime.Parse(firstDeliveryDateTimeString));                
                writer.FileWriter(deliveryOrder, filteredOrders);                
                orderView.ShowResult(filteredOrders);
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);                
                Logger.Error($"Ошибка: {ex.Message}");
            }
        }
    }
}
