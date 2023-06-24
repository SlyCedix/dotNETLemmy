namespace dotNETLemmy.API.Types.Forms;

public class DeletePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Deleted { get; set; }
    public int PostId { get; set; }
    public string EndPoint => "/api/v3/post/delete";
    public HttpMethod Method => HttpMethod.Post;
}