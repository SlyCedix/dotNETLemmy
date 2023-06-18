namespace dotNetLemmy.Types;

public class GetPostForm : IForm
{
    public string? Auth { get; set; }
    public int? CommentId { get; set; }
    public int? PostId { get; set; }

    public string EndPoint => "/post";
    public HttpMethod Method => HttpMethod.Get;
}