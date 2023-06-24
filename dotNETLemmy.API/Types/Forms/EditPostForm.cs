namespace dotNETLemmy.API.Types.Forms;

public class EditPostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string? Body { get; set; }
    public int? LanguageId { get; set; }
    public string? Name { get; set; }
    public bool? Nsfw { get; set; }
    public int PostId { get; set; }
    public string? Url { get; set; }
    public string EndPoint => "/api/v3/post";
    public HttpMethod Method => HttpMethod.Put;
}