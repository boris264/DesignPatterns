using FactoryMethodPattern.Loggers;
using FactoryMethodPattern.Loggers.Factories;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = new LoggerFactory();

            var logger = loggerFactory.Create(LoggerType.Warning);

            logger.Log("Unsafe operation");
        }
    }
}
