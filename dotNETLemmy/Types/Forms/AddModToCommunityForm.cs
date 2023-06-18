namespace dotNetLemmy.Types;

public class AddModToCommunityForm : IForm
{
    public bool Added { get; set; }
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public int PersonId { get; set; }
    public string EndPoint => "/community/mod";
    public HttpMethod Method => HttpMethod.Post;
}