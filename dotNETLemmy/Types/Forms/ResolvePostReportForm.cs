﻿namespace dotNetLemmy.Types;

public class ResolvePostReportForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int ReportId { get; set; }
    public bool Resolved { get; set; }

    public string EndPoint => "/post/report/resolve";
    public HttpMethod Method => HttpMethod.Put;
}