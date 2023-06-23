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
        var requestUri = RequestUri;
        if (Method == HttpMethod.Get ||
            Method == HttpMethod.Head)
            requestUri += Json.JsonToQuery();

        var req = new HttpRequestMessage
        {
            RequestUri = new Uri(baseUri, requestUri), Method = Method
        };

        if (Method != HttpMethod.Get &&
            Method != HttpMethod.Head)
            req.Content = new StringContent(Json, Encoding.UTF8, "application/json");

        return req;
    }
}