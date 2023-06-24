namespace dotNETLemmy.API.Types.Forms;

public class DeleteCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public bool Deleted { get; set; }
    public string EndPoint => "/api/v3/community/delete";
    public HttpMethod Method => HttpMethod.Post;
}