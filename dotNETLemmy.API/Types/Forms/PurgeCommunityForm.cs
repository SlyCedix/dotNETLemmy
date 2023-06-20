namespace dotNETLemmy.API.Types.Forms;

public class PurgeCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public string? Reason { get; set; }

    public string EndPoint => "/admin/purge/community";
    public HttpMethod Method => HttpMethod.Post;
}