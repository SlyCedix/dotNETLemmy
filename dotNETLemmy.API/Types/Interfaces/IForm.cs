using System.Net.Mime;
using System.Reflection;
using System.Text;
using dotNETLemmy.API.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dotNETLemmy.API.Types;

public interface IForm : IJsonObject
{
    [JsonIgnore] public string EndPoint { get; }
    [JsonIgnore] public HttpMethod Method { get; }
    [JsonIgnore] private string RequestUri => $"/api/v3/{EndPoint.TrimStart('/').TrimEnd('/')}";
    

    public HttpRequestMessage ToRequest(Uri baseUri)
    {
        var requestUri = new Uri(baseUri, RequestUri + Json.JsonToQuery());

        return new HttpRequestMessage
        {
            RequestUri = requestUri, Method = Method
        };
    }
}