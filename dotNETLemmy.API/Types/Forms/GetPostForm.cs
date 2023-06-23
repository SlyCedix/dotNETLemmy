namespace dotNETLemmy.API.Types.Forms;

public class GetPostForm : IForm
{
    public string? Auth { get; set; }
    public int? CommentId { get; set; }
    public int? Id { get; set; }

    public string EndPoint => "/post";
    public HttpMethod Method => HttpMethod.Get;
}