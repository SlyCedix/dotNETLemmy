namespace dotNetLemmy.Types;

public class ResolveObjectForm : IForm
{
    public string? Auth { get; set; }
    public string Q { get; set; } = string.Empty;

    public string EndPoint => "/resolve_object";
    public HttpMethod Method => HttpMethod.Get;
}