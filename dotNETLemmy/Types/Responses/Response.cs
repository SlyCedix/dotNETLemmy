using System.Net;
using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public abstract class Response : IResponse
{
    public HttpStatusCode StatusCode { get; private set; }
    public bool IsSuccessStatusCode { get; private set; }
    public string? ReasonPhrase { get; private set; }

    public static async Task<TResponse?> FromHttpResponseMessage<TResponse>(HttpResponseMessage message)
        where TResponse : Response, new()
    {
        var json = await message.Content.ReadAsStringAsync();
        var resObject = JsonConvert.DeserializeObject<TResponse>(json);

        if (resObject is null) resObject = new TResponse();

        resObject.StatusCode = message.StatusCode;
        resObject.IsSuccessStatusCode = message.IsSuccessStatusCode;
        resObject.ReasonPhrase = message.ReasonPhrase;

        return resObject;
    }
}