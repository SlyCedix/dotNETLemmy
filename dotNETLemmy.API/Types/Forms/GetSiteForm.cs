﻿namespace dotNETLemmy.API.Types.Forms;

public class GetSiteForm : IForm
{
    public string? Auth { get; set; }

    public string EndPoint => "/api/v3/site";
    public HttpMethod Method => HttpMethod.Get;
}