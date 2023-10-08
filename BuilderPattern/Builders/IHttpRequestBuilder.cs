using System;
using System.Net.Http;

namespace BuilderPattern.Builders
{
    public interface IHttpRequestBuilder
    {
        IHttpRequestBuilder WithMethod(HttpMethod httpMethod);

        IHttpRequestBuilder WithUri(string uri);

        IHttpRequestBuilder AddHeader(string type, string value);

        IHttpRequestBuilder WithContent(Func<HttpContent> httpContentConfiguration);

        HttpRequestMessage Build();
    }
}
