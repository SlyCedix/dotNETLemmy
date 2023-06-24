namespace dotNETLemmy.API.Types.Forms;

public class DeletePrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Deleted { get; set; }
    public int PrivateMessageId { get; set; }
    public string EndPoint => "/api/v3/private_message/delete";
    public HttpMethod Method => HttpMethod.Post;
}