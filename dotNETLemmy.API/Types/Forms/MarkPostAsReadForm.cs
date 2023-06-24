namespace dotNETLemmy.API.Types.Forms;

public class MarkPostAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/api/v3/post/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}