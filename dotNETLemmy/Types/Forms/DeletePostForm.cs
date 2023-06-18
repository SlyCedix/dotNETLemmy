namespace dotNetLemmy.Types;

public class DeletePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Deleted { get; set; }
    public int PostId { get; set; }
    public string EndPoint => "/post/delete";
    public HttpMethod Method => HttpMethod.Post;
}