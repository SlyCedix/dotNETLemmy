using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types;

public class LocalSite : IJsonObject
{
    [JsonInclude] public int ActorNameMaxLength { get; private set; }
    [JsonInclude] public bool ApplicationEmailAdmins { get; private set; }
    [JsonInclude] public string? ApplicationQuestion { get; private set; }
    [JsonInclude] public string CaptchaDifficulty { get; private set; } = string.Empty;
    [JsonInclude] public bool CaptchaEnabled { get; private set; }
    [JsonInclude] public bool CommunityCreationAdminOnly { get; private set; }
    [JsonInclude] public string DefaultPostListingType { get; private set; } = string.Empty;
    [JsonInclude] public string DefaultTheme { get; private set; } = string.Empty;
    [JsonInclude] public bool EnableDownvotes { get; private set; }
    [JsonInclude] public bool EnableNsfw { get; private set; }
    [JsonInclude] public bool FederationDebug { get; private set; }
    [JsonInclude] public bool FederationEnabled { get; private set; }
    [JsonInclude] public bool FederationWorkerCount { get; private set; }
    [JsonInclude] public bool HideModlogModNames { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string? LegalInformation { get; private set; }
    [JsonInclude] public bool PrivateInstance { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public RegistrationMode RegistrationMode { get; private set; }
    [JsonInclude] public bool ReportsEmailAdmins { get; private set; }
    [JsonInclude] public bool RequireEmailVerification { get; private set; }
    [JsonInclude] public int SiteId { get; private set; }
    [JsonInclude] public bool SiteSetup { get; private set; }
    [JsonInclude] public string? SlurFilterRegex { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}