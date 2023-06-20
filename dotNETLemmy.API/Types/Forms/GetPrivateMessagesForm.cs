namespace dotNETLemmy.API.Types.Forms;

public class GetPrivateMessagesForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public bool? UnreadOnly { get; set; }

    public string EndPoint => "/private_message/list";
    public HttpMethod Method => HttpMethod.Get;
}