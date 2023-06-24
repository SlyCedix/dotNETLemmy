namespace dotNETLemmy.API.Types.Forms;

public class RemoveCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public int? Expires { get; set; }
    public string? Reason { get; set; }
    public bool Removed { get; set; }

    public string EndPoint => "/api/v3/community/remove";
    public HttpMethod Method => HttpMethod.Post;
}