using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class Post
{
    [JsonProperty] public string ApId { get; private set; } = string.Empty;
    [JsonProperty] public string? Body { get; private set; }
    [JsonProperty] public int CommunityId { get; private set; }
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public bool Deleted { get; private set; }
    [JsonProperty] public string? EmbedDescription { get; private set; }
    [JsonProperty] public string? EmbedTitle { get; private set; }
    [JsonProperty] public string? EmbedVideoUrl { get; private set; }
    [JsonProperty] public bool FeaturedCommunity { get; private set; }
    [JsonProperty] public bool FeaturedLocal { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int LanguageId { get; private set; }
    [JsonProperty] public bool Local { get; private set; }
    [JsonProperty] public bool Locked { get; private set; }
    [JsonProperty] public string Name { get; private set; } = string.Empty;
    [JsonProperty] public bool Nsfw { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public bool Removed { get; private set; }
    [JsonProperty] public string? ThumbnailUrl { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
    [JsonProperty] public string? Url { get; private set; }
}