using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace AdapterPattern.Adapters
{
    public class JsonToXmlAdapter : IJsonAdapter
    {
        public string ConvertJson<T>(string json)
        {
            T? jsonObject = JsonSerializer.Deserialize<T>(json);

            if (jsonObject == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            var stringBuilder = new StringBuilder();
            
            using (var stringWriter = new StringWriter(stringBuilder))
            {
                xmlSerializer.Serialize(stringWriter, jsonObject);

                return stringBuilder.ToString();
            }
        }
    }
}
