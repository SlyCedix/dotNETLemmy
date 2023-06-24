namespace dotNETLemmy.API.Types.Forms;

public class MarkPersonMentionAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PersonMentionId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/api/v3/user/mention/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}