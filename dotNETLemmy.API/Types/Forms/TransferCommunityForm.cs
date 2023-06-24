namespace dotNETLemmy.API.Types.Forms;

public class TransferCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public int PersonId { get; set; }

    public string EndPoint => "/api/v3/community/transfer";
    public HttpMethod Method => HttpMethod.Post;
}