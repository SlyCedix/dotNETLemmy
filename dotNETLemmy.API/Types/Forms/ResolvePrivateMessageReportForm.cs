namespace dotNETLemmy.API.Types.Forms;

public class ResolvePrivateMessageReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int ReportId { get; set; }
    public bool Resolved { get; set; }

    public string EndPoint => "/private_message/report/resolve";
    public HttpMethod Method => HttpMethod.Put;
}