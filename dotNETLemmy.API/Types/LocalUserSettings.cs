using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class LocalUserSettings
{
    [JsonProperty] public bool AcceptedApplication { get; private set; }
    [JsonProperty] public int DefaultListingType { get; private set; }
    [JsonProperty] public int DefaultSortType { get; private set; }
    [JsonProperty] public string? Email { get; private set; }
    [JsonProperty] public bool EmailVerified { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string InterfaceLanguage { get; private set; } = string.Empty;
    [JsonProperty] public int PersonId { get; private set; }
    [JsonProperty] public bool SendNotificationsToEmail { get; private set; }
    [JsonProperty] public bool ShowAvatars { get; private set; }
    [JsonProperty] public bool ShowBotAccounts { get; private set; }
    [JsonProperty] public bool ShowNewPostNotifs { get; private set; }
    [JsonProperty] public bool ShowNsfw { get; private set; }
    [JsonProperty] public bool ShowReadPosts { get; private set; }
    [JsonProperty] public bool ShowScores { get; private set; }
    [JsonProperty] public string Theme { get; private set; } = string.Empty;
    [JsonProperty] public string ValidatorTime { get; private set; } = string.Empty;
}