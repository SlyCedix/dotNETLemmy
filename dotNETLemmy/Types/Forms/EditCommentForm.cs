namespace dotNetLemmy.Types;

public class EditCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public string? Content { get; set; }
    public bool? Distinguished { get; set; }
    public string? FormId { get; set; }
    public int? LanguageId { get; set; }
    public string EndPoint => "/comment";
    public HttpMethod Method => HttpMethod.Put;
}