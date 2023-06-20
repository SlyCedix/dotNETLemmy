namespace dotNETLemmy.API.Types.Forms;

public class RemoveCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public string? Reason { get; set; }
    public bool Removed { get; set; }

    public string EndPoint => "/comment/remove";
    public HttpMethod Method => HttpMethod.Post;
}