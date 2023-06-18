namespace dotNetLemmy.Types;

public class DeletePrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public bool Deleted { get; set; }
    public int PrivateMessageId { get; set; }
    public string EndPoint => "/private_message/delete";
    public HttpMethod Method => HttpMethod.Post;
}