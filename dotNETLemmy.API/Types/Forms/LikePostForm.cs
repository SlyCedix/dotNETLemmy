namespace dotNETLemmy.API.Types.Forms;

public class LikePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public int Score { get; set; }

    public string EndPoint => "/api/v3/post/like";
    public HttpMethod Method => HttpMethod.Post;
}