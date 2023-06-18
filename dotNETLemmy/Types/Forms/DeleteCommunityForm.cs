namespace dotNetLemmy.Types;

public class DeleteCommunityForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommunityId { get; set; }
    public bool Deleted { get; set; }
    public string EndPoint => "/community/delete";
    public HttpMethod Method => HttpMethod.Post;
}