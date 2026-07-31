using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ListChatCompletionsRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// Results per page (clamped to 100).
    /// </summary>
    [JsonIgnore]
    public int? PerPage { get; set; }

    [JsonIgnore]
    public string? AgentId { get; set; }

    [JsonIgnore]
    public string? ChannelId { get; set; }

    [JsonIgnore]
    public string? BibleId { get; set; }

    [JsonIgnore]
    public string? Cached { get; set; }

    [JsonIgnore]
    public string? Client { get; set; }

    [JsonIgnore]
    public string? ConfigId { get; set; }

    [JsonIgnore]
    public string? ConversationId { get; set; }

    [JsonIgnore]
    public string? DeviceId { get; set; }

    [JsonIgnore]
    public string? Flagged { get; set; }

    [JsonIgnore]
    public string? Favorited { get; set; }

    [JsonIgnore]
    public string? Language { get; set; }

    [JsonIgnore]
    public string? Liked { get; set; }

    [JsonIgnore]
    public string? SessionId { get; set; }

    [JsonIgnore]
    public string? UserId { get; set; }

    [JsonIgnore]
    public string? MinTimestamp { get; set; }

    [JsonIgnore]
    public string? MaxTimestamp { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
