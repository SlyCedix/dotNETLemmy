namespace dotNETLemmy.API.Types.Forms;

public class SaveUserSettingsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string? Avatar { get; set; }
    public string? Banner { get; set; }
    public string? Bio { get; set; }
    public bool? BotAccount { get; set; }
    public int? DefaultListingType { get; set; }
    public int? DefaultSortType { get; set; }
    public int[]? DiscussionLanguages { get; set; }
    public string? DisplayName { get; set; }
    public string? Email { get; set; }
    public string? InterfaceLanguage { get; set; }
    public string? MatrixUserId { get; set; }
    public bool? SendNotificationsToEmail { get; set; }
    public bool? ShowAvatars { get; set; }
    public bool? ShowBotAccounts { get; set; }
    public bool? ShowNewPostNotifs { get; set; }
    public bool? ShowNsfw { get; set; }
    public bool? ShowReadPosts { get; set; }
    public bool? ShowScores { get; set; }
    public string? Theme { get; set; }

    public string EndPoint => "/api/v3/user/save_user_settings";
    public HttpMethod Method => HttpMethod.Put;
}