namespace dotNETLemmy.API.Types.Forms;

public class EditPrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int PrivateMessageId { get; set; }
    public string EndPoint => "/api/v3/private_message";
    public HttpMethod Method => HttpMethod.Put;
}