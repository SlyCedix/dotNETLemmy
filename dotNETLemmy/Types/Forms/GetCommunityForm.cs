namespace dotNetLemmy.Types;

public class GetCommunityForm : IForm
{
    public string? Auth { get; set; }
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string EndPoint => "/community";
    public HttpMethod Method => HttpMethod.Get;
}