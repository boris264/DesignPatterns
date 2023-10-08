namespace FactoryMethodPattern.Loggers.Factories
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger Create(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.Warning:
                    return new WarningLogger();
                case LoggerType.Error:
                    return new ErrorLogger();
                default:
                    return new NullLogger();
            }
        }
    }
}