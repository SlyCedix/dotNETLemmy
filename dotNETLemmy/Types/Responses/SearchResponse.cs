using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class SearchResponse : Response
{
    [JsonProperty] public CommentView[] Comments { get; private set; } = null!;
    [JsonProperty] public CommunityView[] Communities { get; private set; } = null!;
    [JsonProperty] public PostView[] Posts { get; private set; } = null!;
    [JsonProperty(PropertyName = "type_")] public string Type { get; private set; } = string.Empty;
    [JsonProperty] public PersonViewSafe[] Users { get; private set; } = null!;
}