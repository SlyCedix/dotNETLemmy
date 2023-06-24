namespace dotNETLemmy.API.Types.Forms;

public class BanFromCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Ban { get; set; }
    public int CommunityId { get; set; }
    public int? Expires { get; set; }
    public int PersonId { get; set; }
    public string? Reason { get; set; }
    public bool? RemoveData { get; set; }
    public string EndPoint => "/api/v3/community/ban_user";
    public HttpMethod Method => HttpMethod.Post;
}