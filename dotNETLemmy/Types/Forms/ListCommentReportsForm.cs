﻿namespace dotNetLemmy.Types;

public class ListCommentReportsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? CommunityId { get; set; }
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public bool? UnresolvedOnly { get; set; }

    public string EndPoint => "/comment/report/list";
    public HttpMethod Method => HttpMethod.Get;
}