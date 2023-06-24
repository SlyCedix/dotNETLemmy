namespace dotNETLemmy.API.Types.Forms;

public class CreatePrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Recipient { get; set; }
    public string EndPoint => "/api/v3/private_message";
    public HttpMethod Method => HttpMethod.Post;
}