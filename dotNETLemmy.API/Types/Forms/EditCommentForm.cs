namespace dotNETLemmy.API.Types.Forms;

public class EditCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public string? Content { get; set; }
    public bool? Distinguished { get; set; }
    public string? FormId { get; set; }
    public int? LanguageId { get; set; }
    public string EndPoint => "/api/v3/comment";
    public HttpMethod Method => HttpMethod.Put;
}