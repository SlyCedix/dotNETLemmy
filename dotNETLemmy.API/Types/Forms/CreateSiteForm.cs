using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dotNETLemmy.API.Types.Forms;

public class CreateSiteForm : IForm
{
    public int? ActorNameMaxLength { get; set; }
    public string[]? AllowedInstances { get; set; }
    public bool? ApplicationEmailAdmins { get; set; }
    public string? ApplicationQuestion { get; set; }
    public string Auth { get; set; } = string.Empty;
    public string? Banner { get; set; }
    public string[]? BlockedInstances { get; set; }
    public string? CaptchaDifficulty { get; set; }
    public bool? CaptchaEnabled { get; set; }
    public bool? CommunityCreationAdminOnly { get; set; }
    public string? DefaultPostListingType { get; set; }
    public string? DefaultTheme { get; set; }
    public string? Description { get; set; }
    public int[]? DiscussionLanguages { get; set; }
    public bool? EnableDownvotes { get; set; }
    public bool? EnableNsfw { get; set; }
    public bool? FederationDebug { get; set; }
    public bool? FederationEnabled { get; set; }
    public int? FederationWorkerCount { get; set; }
    public bool? HideModlogModNames { get; set; }
    public string? Icon { get; set; }
    public string? LegalInformation { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool? PrivateInstance { get; set; }
    public int? RateLimitComment { get; set; }
    public int? RateLimitCommentPerSecond { get; set; }
    public int? RateLimitImage { get; set; }
    public int? RateLimitImagePerSecond { get; set; }
    public int? RateLimitMessage { get; set; }
    public int? RateLimitMessagePerSecond { get; set; }
    public int? RateLimitPost { get; set; }
    public int? RateLimitPostPerSecond { get; set; }
    public int? RateLimitRegister { get; set; }
    public int? RateLimitRegisterPerSecond { get; set; }
    public int? RateLimitSearch { get; set; }
    public int? RateLimitSearchPerSecond { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public RegistrationMode? RegistrationMode { get; set; }

    public bool? ReportsEmailAdmins { get; set; }
    public string? Sidebar { get; set; }
    public string? SlurFilterRegex { get; set; }
    public string[]? Taglines { get; set; }
    public string EndPoint => "/api/v3/site";
    public HttpMethod Method => HttpMethod.Post;
}