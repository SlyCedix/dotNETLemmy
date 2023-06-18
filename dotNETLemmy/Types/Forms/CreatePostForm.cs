namespace dotNetLemmy.Types;

public class CreatePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string? Body { get; set; }
    public int CommunityId { get; set; }
    public string? Honeypot { get; set; }
    public int? LanguageId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool? Nsfw { get; set; }
    public string? Url { get; set; }
    public string EndPoint => "/post";
    public HttpMethod Method => HttpMethod.Post;
}