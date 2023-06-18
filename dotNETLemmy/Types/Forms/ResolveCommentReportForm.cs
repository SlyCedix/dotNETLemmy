namespace dotNetLemmy.Types;

public class ResolveCommentReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int ReportId { get; set; }
    public bool Resolved { get; set; }

    public string EndPoint => "/comment/report/resolve";
    public HttpMethod Method => HttpMethod.Put;
}