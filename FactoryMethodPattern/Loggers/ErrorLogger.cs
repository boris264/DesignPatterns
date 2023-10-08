using System;

namespace FactoryMethodPattern.Loggers
{
    public class ErrorLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ERR] {message}");
        }
    }
}
