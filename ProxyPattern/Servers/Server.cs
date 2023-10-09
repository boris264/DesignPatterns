namespace ProxyPattern.Servers
{
    public class Server : IServer
    {
        public string GetResource()
        {
            return "Very secret resource!!!";
        }
    }
}
