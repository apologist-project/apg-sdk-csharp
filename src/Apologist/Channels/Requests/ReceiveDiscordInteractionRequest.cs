using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ReceiveDiscordInteractionRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Discord request signature (hex).
    /// </summary>
    [JsonIgnore]
    public required string SignatureEd25519 { get; set; }

    /// <summary>
    /// Discord request timestamp.
    /// </summary>
    [JsonIgnore]
    public required string SignatureTimestamp { get; set; }

    /// <summary>
    /// Discord interaction payload.
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
