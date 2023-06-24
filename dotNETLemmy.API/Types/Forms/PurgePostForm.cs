namespace dotNETLemmy.API.Types.Forms;

public class PurgePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public string? Reason { get; set; }

    public string EndPoint => "/api/v3/admin/purge/post";
    public HttpMethod Method => HttpMethod.Post;
}