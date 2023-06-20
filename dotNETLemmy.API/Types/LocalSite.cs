using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class LocalSite
{
    [JsonProperty] public int ActorNameMaxLength { get; private set; }
    [JsonProperty] public bool ApplicationEmailAdmins { get; private set; }
    [JsonProperty] public string? ApplicationQuestion { get; private set; }
    [JsonProperty] public string CaptchaDifficulty { get; private set; } = string.Empty;
    [JsonProperty] public bool CaptchaEnabled { get; private set; }
    [JsonProperty] public bool CommunityCreationAdminOnly { get; private set; }
    [JsonProperty] public string DefaultPostListingType { get; private set; } = string.Empty;
    [JsonProperty] public string DefaultTheme { get; private set; } = string.Empty;
    [JsonProperty] public bool EnableDownvotes { get; private set; }
    [JsonProperty] public bool EnableNsfw { get; private set; }
    [JsonProperty] public bool FederationDebug { get; private set; }
    [JsonProperty] public bool FederationEnabled { get; private set; }
    [JsonProperty] public bool FederationWorkerCount { get; private set; }
    [JsonProperty] public bool HideModlogModNames { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string? LegalInformation { get; private set; }
    [JsonProperty] public bool PrivateInstance { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public RegistrationMode RegistrationMode { get; private set; }
    [JsonProperty] public bool ReportsEmailAdmins { get; private set; }
    [JsonProperty] public bool RequireEmailVerification { get; private set; }
    [JsonProperty] public int SiteId { get; private set; }
    [JsonProperty] public bool SiteSetup { get; private set; }
    [JsonProperty] public string? SlurFilterRegex { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}