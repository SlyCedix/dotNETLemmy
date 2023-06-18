namespace dotNetLemmy.Types;

public class MarkPersonMentionAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PersonMentionId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/user/mention/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}