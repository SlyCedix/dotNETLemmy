namespace dotNETLemmy.API.Types.Forms;

public class CreateCommentReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int CommentId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string EndPoint => "/comment/report";
    public HttpMethod Method => HttpMethod.Post;
}