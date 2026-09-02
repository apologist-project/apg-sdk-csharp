using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// Result of scrubbing or anonymizing a user's message-adjacent text. Rows and identifiers are kept.
/// </summary>
[Serializable]
public record UserRedactResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Internal user id (UUID).
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mode")]
    public UserRedactResponseMode? Mode { get; set; }

    /// <summary>
    /// When the erase request was stamped. The hourly cron finishes leftover rows.
    /// </summary>
    [JsonPropertyName("redact_requested_at")]
    public string? RedactRequestedAt { get; set; }

    /// <summary>
    /// Message rows rewritten in this request.
    /// </summary>
    [JsonPropertyName("messages_redacted")]
    public int? MessagesRedacted { get; set; }

    /// <summary>
    /// Message rows still waiting. Zero means this request finished the user.
    /// </summary>
    [JsonPropertyName("remaining")]
    public int? Remaining { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
