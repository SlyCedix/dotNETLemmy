namespace dotNETLemmy.API.Types.Forms;

public class LockPostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Locked { get; set; }
    public int PostId { get; set; }

    public string EndPoint => "/api/v3/post/lock";
    public HttpMethod Method => HttpMethod.Post;
}