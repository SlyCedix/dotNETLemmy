namespace dotNetLemmy.Types;

public class RemovePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public string? Reason { get; set; }
    public bool Removed { get; set; }

    public string EndPoint => "/post/remove";
    public HttpMethod Method => HttpMethod.Post;
}