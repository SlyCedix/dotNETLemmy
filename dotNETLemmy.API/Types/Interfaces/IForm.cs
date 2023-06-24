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
    
    public HttpRequestMessage ToRequest(string baseUri)
    {
        var endPoint = EndPoint;
        if ((Method == HttpMethod.Get ||
            Method == HttpMethod.Head) &&
            Json.Length > 0) 
            endPoint += Json.JsonToQuery();

        var req = new HttpRequestMessage
        {
            RequestUri = new Uri(new Uri(baseUri), endPoint), Method = Method
        };

        if (Method != HttpMethod.Get &&
            Method != HttpMethod.Head)
            req.Content = new StringContent(Json, Encoding.UTF8, "application/json");

        return req;
    }
}