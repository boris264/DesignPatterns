using System.Text.Json;

namespace AdapterPattern;

public static class Fetcher
{
    public static string GetData()
    {
        return JsonSerializer.Serialize(new User("test", 13),
            new JsonSerializerOptions()
            {
                WriteIndented = true
            });
    }
}
