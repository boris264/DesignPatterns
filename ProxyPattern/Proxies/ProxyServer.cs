using System;
using ProxyPattern.Servers;

namespace ProxyPattern.Proxies
{
    public class ProxyServer : IServer
    {
        private User _user;

        private readonly IServer _server;

        public ProxyServer(User user)
        {
            _user = user;
            _server = new Server();
        }

        public string GetResource()
        {
            if (_user.Id != 0 || _user.Name != "Admin")
            {
                throw new Exception("You cannot access resources from the server!");
            }

            return _server.GetResource();
        }
    }
}
