namespace dotNetLemmy.Types;

public class PurgePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public string? Reason { get; set; }

    public string EndPoint => "/admin/purge/post";
    public HttpMethod Method => HttpMethod.Post;
}