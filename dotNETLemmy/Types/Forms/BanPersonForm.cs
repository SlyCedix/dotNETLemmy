namespace dotNetLemmy.Types;

public class BanPersonForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Ban { get; set; }
    public int? Expires { get; set; }
    public int PersonId { get; set; }
    public string? Reason { get; set; }
    public bool? RemoveData { get; set; }
    public string EndPoint => "/user/ban";
    public HttpMethod Method => HttpMethod.Post;
}