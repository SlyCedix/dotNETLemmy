namespace dotNetLemmy.Types;

public class AddAdminForm : IForm
{
    public bool Added { get; set; }
    public string Auth { get; set; } = string.Empty;
    public int PersonId { get; set; }

    public string EndPoint => "/admin/add";
    public HttpMethod Method => HttpMethod.Post;
}