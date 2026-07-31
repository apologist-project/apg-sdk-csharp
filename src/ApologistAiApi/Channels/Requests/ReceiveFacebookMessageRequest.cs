using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record ReceiveFacebookMessageRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Meta webhook payload.
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
