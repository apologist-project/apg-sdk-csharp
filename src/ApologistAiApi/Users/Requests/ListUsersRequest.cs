using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record ListUsersRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// Results per page (clamped to 100).
    /// </summary>
    [JsonIgnore]
    public int? PerPage { get; set; }

    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Comma-separated tag ids.
    /// </summary>
    [JsonIgnore]
    public string? Tags { get; set; }

    [JsonIgnore]
    public string? ResponderId { get; set; }

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
