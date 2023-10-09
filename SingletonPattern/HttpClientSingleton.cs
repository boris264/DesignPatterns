using System.Net.Http;

namespace SingletonPattern
{
    public static class HttpClientSingleton
    {
        private static readonly HttpClient _httpClient;

        static HttpClientSingleton()
        {
            _httpClient = new HttpClient();
        }

        public static HttpClient Get()
        {
            return _httpClient;
        }
    }
}
