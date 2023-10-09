using System;
using AdapterPattern.Adapters;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonToXmlAdapter = new JsonToXmlAdapter();

            var userXml = jsonToXmlAdapter.ConvertJson<User>(Fetcher.GetData());
            Console.WriteLine(userXml);
        }
    }
}
