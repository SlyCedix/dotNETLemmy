using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class SearchResponse : Response
{
    [JsonInclude] public CommentView[] Comments { get; private set; } = null!;
    [JsonInclude] public CommunityView[] Communities { get; private set; } = null!;
    [JsonInclude] public PostView[] Posts { get; private set; } = null!;
    [JsonPropertyName("type_")] public string Type { get; private set; } = string.Empty;
    [JsonInclude] public PersonViewSafe[] Users { get; private set; } = null!;
}