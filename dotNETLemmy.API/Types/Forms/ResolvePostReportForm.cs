namespace dotNETLemmy.API.Types.Forms;

public class ResolvePostReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int ReportId { get; set; }
    public bool Resolved { get; set; }

    public string EndPoint => "/api/v3/post/report/resolve";
    public HttpMethod Method => HttpMethod.Put;
}