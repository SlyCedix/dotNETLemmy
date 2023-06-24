namespace dotNETLemmy.API.Types.Forms;

public class DeleteCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public bool Deleted { get; set; }
    public string EndPoint => "/api/v3/comment/delete";
    public HttpMethod Method => HttpMethod.Post;
}