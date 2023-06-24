using System.Net;
using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public abstract class Response : IJsonObject
{
    public HttpStatusCode StatusCode { get; private set; }
    public bool IsSuccessStatusCode { get; private set; }
    public string? ReasonPhrase { get; private set; }

    [JsonInclude] public string? Error { get; private set; }
    public bool HasError => Error is not null;

    public static async Task<TResponse> FromHttpResponseMessage<TResponse>(HttpResponseMessage message)
        where TResponse : Response, new()
    {
        var json = await message.Content.ReadAsStringAsync();
        var resObject = SerializationUtils.Deserialize<TResponse>(json) ?? new TResponse();

        resObject.StatusCode = message.StatusCode;
        resObject.IsSuccessStatusCode = message.IsSuccessStatusCode;
        resObject.ReasonPhrase = message.ReasonPhrase;

        return resObject;
    }
}