namespace dotNETLemmy.API.Types.Forms;

public class SavePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public bool Save { get; set; }

    public string EndPoint => "/api/v3/post/save";
    public HttpMethod Method => HttpMethod.Put;
}