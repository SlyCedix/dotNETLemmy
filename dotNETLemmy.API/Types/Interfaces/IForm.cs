using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dotNETLemmy.API.Types;

public interface IForm
{
    [JsonIgnore] public string EndPoint { get; }
    [JsonIgnore] public HttpMethod Method { get; }

    [JsonIgnore] private string RequestUri => $"/api/v3/{EndPoint.TrimStart('/').TrimEnd('/')}";

    private static JsonSerializerSettings SerializerSettings { get; } = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        }
    };

    public HttpRequestMessage ToRequest(Uri baseUri)
    {
        var json = JsonConvert.SerializeObject(this, SerializerSettings);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var requestUri = new Uri(baseUri, RequestUri);

        return new HttpRequestMessage
        {
            RequestUri = requestUri, Method = Method, Content = content
        };
    }
}