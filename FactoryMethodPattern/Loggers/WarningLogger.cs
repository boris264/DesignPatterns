using System;

namespace FactoryMethodPattern.Loggers
{
    public class WarningLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[WARN] {message}");
        }
    }
}
