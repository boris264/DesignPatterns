using System.IO;
using System.Xml.Serialization;

namespace AdapterPattern;

public static class Processer
{
    public static T? XMLProcess<T>(string xml)
        where T : class
    {
        using (var xmlReader = new StringReader(xml))
        {
            var serializer = new XmlSerializer(typeof(T));
            var serializedObject = serializer.Deserialize(xmlReader);

            return (T?)serializedObject;
        }
    }
}
