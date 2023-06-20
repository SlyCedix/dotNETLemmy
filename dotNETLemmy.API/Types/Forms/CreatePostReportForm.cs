namespace dotNETLemmy.API.Types.Forms;

public class CreatePostReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PostId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string EndPoint => "/post/report";
    public HttpMethod Method => HttpMethod.Post;
}