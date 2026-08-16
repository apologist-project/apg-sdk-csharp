using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// A conversation scoped to the requesting agent.
/// </summary>
[Serializable]
public record Conversation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Internal conversation id (UUID).
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Team-scoped external conversation id.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("agent_id")]
    public int? AgentId { get; set; }

    [JsonPropertyName("team_id")]
    public int? TeamId { get; set; }

    [JsonPropertyName("tags")]
    public Dictionary<string, object?>? Tags { get; set; }

    [JsonPropertyName("started_at")]
    public string? StartedAt { get; set; }

    [JsonPropertyName("ended_at")]
    public string? EndedAt { get; set; }

    [JsonPropertyName("agent_paused")]
    public bool? AgentPaused { get; set; }

    [JsonPropertyName("agent_paused_at")]
    public string? AgentPausedAt { get; set; }

    [JsonPropertyName("agent_resumed_at")]
    public string? AgentResumedAt { get; set; }

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
