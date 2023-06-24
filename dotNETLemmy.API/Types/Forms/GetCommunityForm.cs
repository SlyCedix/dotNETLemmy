namespace dotNETLemmy.API.Types.Forms;

public class GetCommunityForm : IForm
{
    public string? Auth { get; set; }
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string EndPoint => "/api/v3/community";
    public HttpMethod Method => HttpMethod.Get;
}