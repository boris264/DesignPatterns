using System;

namespace FactoryMethodPattern.Loggers.Factories
{
    public interface ILoggerFactory
    {
        ILogger Create(LoggerType loggerType);
    }
}
