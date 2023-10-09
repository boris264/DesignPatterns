using System;
using System.Net.Http;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = HttpClientSingleton.Get();
            Console.WriteLine(client.GetHashCode());

            TestMethod(client);
            TestClass.TestSingleton(client);
        }

        static void TestMethod(HttpClient client)
        {
            Console.WriteLine(client == HttpClientSingleton.Get());
        }
    }
}
