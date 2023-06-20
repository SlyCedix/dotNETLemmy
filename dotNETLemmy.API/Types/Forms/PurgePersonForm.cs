namespace dotNETLemmy.API.Types.Forms;

public class PurgePersonForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PersonId { get; set; }
    public string? Reason { get; set; }

    public string EndPoint => "/admin/purge/person";
    public HttpMethod Method => HttpMethod.Post;
}