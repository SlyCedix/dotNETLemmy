namespace dotNETLemmy.API.Types.Forms;

public class MarkPrivateMessageAsReadForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PrivateMessageId { get; set; }
    public bool Read { get; set; }

    public string EndPoint => "/private_message/mark_as_read";
    public HttpMethod Method => HttpMethod.Post;
}