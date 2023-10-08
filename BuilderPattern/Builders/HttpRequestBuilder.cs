using System;
using System.Net.Http;

namespace BuilderPattern.Builders
{
    public class HttpRequestBuilder : IHttpRequestBuilder
    {
        private HttpRequestMessage _httpRequestMessage;

        public HttpRequestBuilder(string uri)
        {
            _httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        }

        public IHttpRequestBuilder AddHeader(string type, string value)
        {
            _httpRequestMessage.Headers.Add(type, value);

            return this;
        }

        public IHttpRequestBuilder WithMethod(HttpMethod httpMethod)
        {
            _httpRequestMessage.Method = httpMethod;

            return this;
        }

        public IHttpRequestBuilder WithUri(string uri)
        {
            _httpRequestMessage.RequestUri = new Uri(uri);

            return this;
        }

        public IHttpRequestBuilder WithContent(Func<HttpContent> httpContentConfiguration)
        {
            _httpRequestMessage.Content = httpContentConfiguration();

            return this;
        }

        public HttpRequestMessage Build()
        {
            return _httpRequestMessage;
        }
    }
}
