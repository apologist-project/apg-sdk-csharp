using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// Result of scrubbing or anonymizing a chat completion's message-adjacent text. Rows and identifiers are kept.
/// </summary>
[Serializable]
public record CompletionRedactResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Chat completion id (UUID).
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mode")]
    public CompletionRedactResponseMode? Mode { get; set; }

    /// <summary>
    /// Message rows rewritten in this request.
    /// </summary>
    [JsonPropertyName("messages_redacted")]
    public int? MessagesRedacted { get; set; }

    /// <summary>
    /// Message rows still waiting. Zero means this request finished the completion.
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
