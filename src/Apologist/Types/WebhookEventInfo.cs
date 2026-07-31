using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record WebhookEventInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Stable machine-readable event key.
    /// </summary>
    [JsonPropertyName("key")]
    public required WebhookEventInfoKey Key { get; set; }

    /// <summary>
    /// Human-readable event label.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    [JsonPropertyName("occurred_at")]
    public required DateTime OccurredAt { get; set; }

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
