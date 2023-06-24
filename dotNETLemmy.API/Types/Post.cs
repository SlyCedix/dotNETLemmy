using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class Post : IJsonObject
{
    [JsonInclude] public string ApId { get; private set; } = string.Empty;
    [JsonInclude] public string? Body { get; private set; }
    [JsonInclude] public int CommunityId { get; private set; }
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public bool Deleted { get; private set; }
    [JsonInclude] public string? EmbedDescription { get; private set; }
    [JsonInclude] public string? EmbedTitle { get; private set; }
    [JsonInclude] public string? EmbedVideoUrl { get; private set; }
    [JsonInclude] public bool FeaturedCommunity { get; private set; }
    [JsonInclude] public bool FeaturedLocal { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int LanguageId { get; private set; }
    [JsonInclude] public bool Local { get; private set; }
    [JsonInclude] public bool Locked { get; private set; }
    [JsonInclude] public string Name { get; private set; } = string.Empty;
    [JsonInclude] public bool Nsfw { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public bool Removed { get; private set; }
    [JsonInclude] public string? ThumbnailUrl { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
    [JsonInclude] public string? Url { get; private set; }
}