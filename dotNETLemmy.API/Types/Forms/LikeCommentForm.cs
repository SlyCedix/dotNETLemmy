namespace dotNETLemmy.API.Types.Forms;

public class LikeCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public int Score { get; set; }

    public string EndPoint => "/api/v3/post/like";
    public HttpMethod Method => HttpMethod.Post;
}