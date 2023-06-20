using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetSiteResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Admins { get; private set; } = null!;
    [JsonProperty] public Language[] AllLanguages { get; private set; } = null!;
    [JsonProperty] public int[] DiscussionLanguages { get; private set; } = null!;
    [JsonProperty] public FederatedInstances? FederatedInstances { get; private set; }
    [JsonProperty] public MyUserInfo? MyUser { get; private set; }
    [JsonProperty] public int Online { get; private set; }
    [JsonProperty] public SiteView SiteView { get; private set; } = null!;
    [JsonProperty] public Tagline[] Taglines { get; private set; } = null!;
    [JsonProperty] public string Version { get; private set; } = string.Empty;
}