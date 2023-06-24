namespace dotNETLemmy.API.Types.Forms;

public class PurgeCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public string? Reason { get; set; }

    public string EndPoint => "/api/v3/admin/purge/comment";
    public HttpMethod Method => HttpMethod.Post;
}