using FilterForDeliveryService.View;
using System.Text.RegularExpressions;


namespace FilterForDeliveryService.Controller
{
    public class InputDataValidator
    {        
        Regex patternCityDistrict = new("^[ABCD]$");
        Regex patternPath = new(@"^[a-zA-Z]:(\\|/)([a-zA-Z0-9_\-\\\/\.]+)(\.[a-zA-Z0-9]+)?$");
        Regex patternFirstDeliveryDateTimeString = new(@"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])\s(0\d|1\d|2[0-3]):([0-5]\d):([0-5]\d)$");
        
        public void InputdataValidation(string[] arg)
        {
            if(arg.Length != 5)
            {
                throw new ArgumentException("Недостаточное количество аргументов.");
            }
            if (!patternCityDistrict.IsMatch(arg[0]))
            {
                throw new ArgumentException($"Ошибка входного значения: Район {arg[0]} не существует.");
            }
            if (!patternPath.IsMatch(arg[1]))
            {
                throw new ArgumentException(@"Ошибка входного значения: Путь к файлу с данными.");             
            }
            if (!patternPath.IsMatch(arg[3]))
            {
                throw new ArgumentException("Ошибка входного значения: Путь для записи .log .");
            }
            if (!patternPath.IsMatch(arg[4]))
            {
                throw new ArgumentException(@"Ошибка входного значения: Путь для записи выходных данных.");
            }
            if (!patternFirstDeliveryDateTimeString.IsMatch(arg[2]))
            {
                throw new ArgumentException("Ошибка входного значения: Первая дата доставки.");
            }            
        }
    }
}
