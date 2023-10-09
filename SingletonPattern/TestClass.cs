using System;
using System.Net.Http;

namespace SingletonPattern;

public static class TestClass
{
    public static void TestSingleton(HttpClient client)
    {
        Console.WriteLine($"Test singleton class: {client == HttpClientSingleton.Get()}");
    }
}
