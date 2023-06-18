using System.Net;

namespace dotNetLemmy.Types;

public interface IResponse
{
    public HttpStatusCode StatusCode { get; }
    public bool IsSuccessStatusCode { get; }
    public string? ReasonPhrase { get; }
}