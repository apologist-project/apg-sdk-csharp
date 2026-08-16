using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// Agent-wide pause or resume result, including fan-out counts.
/// </summary>
[Serializable]
public record AgentPauseState : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("is_paused")]
    public bool? IsPaused { get; set; }

    [JsonPropertyName("paused_at")]
    public string? PausedAt { get; set; }

    [JsonPropertyName("resumed_at")]
    public string? ResumedAt { get; set; }

    /// <summary>
    /// Conversations that received a transition message.
    /// </summary>
    [JsonPropertyName("emitted")]
    public int? Emitted { get; set; }

    /// <summary>
    /// Conversations skipped during fan-out.
    /// </summary>
    [JsonPropertyName("skipped")]
    public int? Skipped { get; set; }

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
