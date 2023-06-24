namespace dotNETLemmy.API.Types.Forms;

public class EditCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string? Banner { get; set; }
    public int CommunityId { get; set; }
    public string? Description { get; set; }
    public int[]? DiscussionLanguages { get; set; }
    public string? Icon { get; set; }
    public bool? Nsfw { get; set; }
    public bool? PostingRestrictedToMods { get; set; }
    public string? Title { get; set; }
    public string EndPoint => "/api/v3/community";
    public HttpMethod Method => HttpMethod.Put;
}