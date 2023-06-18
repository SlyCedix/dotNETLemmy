﻿namespace dotNetLemmy.Types;

public class EditPrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int PrivateMessageId { get; set; }
    public string EndPoint => "/private_message";
    public HttpMethod Method => HttpMethod.Put;
}