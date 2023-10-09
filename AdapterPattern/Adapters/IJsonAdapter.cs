using System;

namespace AdapterPattern.Adapters
{
    public interface IJsonAdapter
    {
        /// <summary>
        /// Converts the specified JSON string to a different format.
        /// </summary>
        /// <typeparam name="T">The class of the serialized JSON object</typeparam>
        /// <param name="json">The JSON string</param>
        /// <returns>The JSON string in a different format</returns>
        string ConvertJson<T>(string json);
    }
}
