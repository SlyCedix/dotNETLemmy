namespace dotNETLemmy.API.Types.Forms;

public class FollowCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public bool Follow { get; set; }
    public string EndPoint => "/api/v3/community/follow";
    public HttpMethod Method => HttpMethod.Post;
}