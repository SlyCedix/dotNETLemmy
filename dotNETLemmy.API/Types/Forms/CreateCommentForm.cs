namespace dotNETLemmy.API.Types.Forms;

public class CreateCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? FormId { get; set; }
    public int? LanguageId { get; set; }
    public int? ParentId { get; set; }
    public int PostId { get; set; }
    public string EndPoint => "/api/v3/comment";
    public HttpMethod Method => HttpMethod.Post;
}