﻿namespace dotNetLemmy.Types;

public class CreatePrivateMessageReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int PrivateMessageId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string EndPoint => "/private_message/report";
    public HttpMethod Method => HttpMethod.Post;
}