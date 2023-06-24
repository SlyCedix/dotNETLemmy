using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class LocalUserSettings : IJsonObject
{
    [JsonInclude] public bool AcceptedApplication { get; private set; }
    [JsonInclude] public int DefaultListingType { get; private set; }
    [JsonInclude] public int DefaultSortType { get; private set; }
    [JsonInclude] public string? Email { get; private set; }
    [JsonInclude] public bool EmailVerified { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string InterfaceLanguage { get; private set; } = string.Empty;
    [JsonInclude] public int PersonId { get; private set; }
    [JsonInclude] public bool SendNotificationsToEmail { get; private set; }
    [JsonInclude] public bool ShowAvatars { get; private set; }
    [JsonInclude] public bool ShowBotAccounts { get; private set; }
    [JsonInclude] public bool ShowNewPostNotifs { get; private set; }
    [JsonInclude] public bool ShowNsfw { get; private set; }
    [JsonInclude] public bool ShowReadPosts { get; private set; }
    [JsonInclude] public bool ShowScores { get; private set; }
    [JsonInclude] public string Theme { get; private set; } = string.Empty;
    [JsonInclude] public string ValidatorTime { get; private set; } = string.Empty;
}