using System;
using System.Net.Http;
using BuilderPattern.Builders;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var reqMessageBuilder = new HttpRequestBuilder("https://google.com");
            var requestMessage = reqMessageBuilder
                .WithMethod(HttpMethod.Post)
                .AddHeader("User-Agent", "Windows 13")
                .WithContent(() => new StringContent("data"))
                .Build();
        }
    }
}
