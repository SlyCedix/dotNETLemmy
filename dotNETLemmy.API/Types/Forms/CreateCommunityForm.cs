namespace dotNETLemmy.API.Types.Forms;

public class CreateCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string? Banner { get; set; }
    public string? Description { get; set; }
    public int[]? DiscussionLanguages { get; set; }
    public string? Icon { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool? Nsfw { get; set; }
    public bool? PostingRestrictedToMods { get; set; }
    public string Title { get; set; } = string.Empty;
    public string EndPoint => "/api/v3/community";
    public HttpMethod Method => HttpMethod.Post;
}