namespace dotNetLemmy.Types;

public class MarkPostAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/post/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}