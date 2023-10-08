namespace FactoryMethodPattern.Loggers
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
        }
    }
}
