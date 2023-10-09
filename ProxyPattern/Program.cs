using System;
using ProxyPattern.Proxies;
using ProxyPattern.Servers;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(0, "Admin");
            IServer proxyServer = new ProxyServer(user);

            try
            {
                Console.WriteLine(proxyServer.GetResource());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
