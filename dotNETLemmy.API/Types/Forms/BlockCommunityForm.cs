namespace dotNETLemmy.API.Types.Forms;

public class BlockCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Block { get; set; }
    public int CommunityId { get; set; }
    public string EndPoint => "/api/v3/community/block";
    public HttpMethod Method => HttpMethod.Post;
}