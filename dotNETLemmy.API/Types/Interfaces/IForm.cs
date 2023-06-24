using System.Text;
using dotNETLemmy.API.Extensions;

namespace dotNETLemmy.API.Types;

public interface IForm : IJsonObject
{
    public string EndPoint { get; }
    public HttpMethod Method { get; }

    public HttpRequestMessage ToRequest(string baseUri)
    {
        var endPoint = EndPoint;
        if (Method == HttpMethod.Get ||
            Method == HttpMethod.Head)
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