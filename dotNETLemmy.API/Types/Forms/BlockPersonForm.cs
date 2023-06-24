namespace dotNETLemmy.API.Types.Forms;

public class BlockPersonForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Block { get; set; }
    public int PersonId { get; set; }
    public string EndPoint => "/api/v3/user/block";
    public HttpMethod Method => HttpMethod.Post;
}