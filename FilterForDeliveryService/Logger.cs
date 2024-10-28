
namespace FilterForDeliveryService
{
    public static class Logger
    {
        private static string logFilePath;
        
        public static void Init(string filePath)
        {
            logFilePath = filePath;
            using (var writer = new StreamWriter(logFilePath, false))
            {
                writer.WriteLine($"[{DateTime.Now}] INFO: Логирование инициализировано.");
            }
        }        
        public static void Info(string message)
        {
            WriteLog("INFO", message);
        }               
        public static void Warn(string message)
        {
            WriteLog("WARN", message);
        }        
        public static void Error(string message)
        {
            WriteLog("ERROR", message);
        }
        private static void WriteLog(string level, string message)
        {
            using (var writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] {level}: {message}");
            }
        }
    }
}
