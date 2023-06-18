namespace dotNetLemmy.Types;

public class BlockCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Block { get; set; }
    public int CommunityId { get; set; }
    public string EndPoint => "/community/block";
    public HttpMethod Method => HttpMethod.Post;
}