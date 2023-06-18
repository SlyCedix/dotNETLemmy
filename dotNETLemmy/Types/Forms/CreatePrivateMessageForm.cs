﻿namespace dotNetLemmy.Types;

public class CreatePrivateMessageForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Recipient { get; set; }
    public string EndPoint => "/private_message";
    public HttpMethod Method => HttpMethod.Post;
}