namespace dotNETLemmy.API.Types.Forms;

public class MarkAllAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/mark_all_as_read";
    public HttpMethod Method => HttpMethod.Post;
}