namespace dotNETLemmy.API.Types.Forms;

public class ListPrivateMessageReportsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public bool? UnresolvedOnly { get; set; }

    public string EndPoint => "/private_message/report/list";
    public HttpMethod Method => HttpMethod.Get;
}