namespace dotNETLemmy.API.Types.Forms;

public class MarkCommentReplyAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentReplyId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/api/v3/comment/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}