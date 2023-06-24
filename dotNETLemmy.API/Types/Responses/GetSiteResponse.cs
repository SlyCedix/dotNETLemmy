using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetSiteResponse : Response
{
    [JsonInclude] public PersonViewSafe[] Admins { get; private set; } = null!;
    [JsonInclude] public Language[] AllLanguages { get; private set; } = null!;
    [JsonInclude] public int[] DiscussionLanguages { get; private set; } = null!;
    [JsonInclude] public FederatedInstances? FederatedInstances { get; private set; }
    [JsonInclude] public MyUserInfo? MyUser { get; private set; }
    [JsonInclude] public int Online { get; private set; }
    [JsonInclude] public SiteView SiteView { get; private set; } = null!;
    [JsonInclude] public Tagline[] Taglines { get; private set; } = null!;
    [JsonInclude] public string Version { get; private set; } = string.Empty;
}