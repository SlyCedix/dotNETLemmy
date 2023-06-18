namespace dotNetLemmy.Types;

public class SavePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public bool Save { get; set; }

    public string EndPoint => "/post/save";
    public HttpMethod Method => HttpMethod.Put;
}