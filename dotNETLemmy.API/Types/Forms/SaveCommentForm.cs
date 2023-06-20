namespace dotNETLemmy.API.Types.Forms;

public class SaveCommentForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public bool Save { get; set; }

    public string EndPoint => "/comment/save";
    public HttpMethod Method => HttpMethod.Put;
}