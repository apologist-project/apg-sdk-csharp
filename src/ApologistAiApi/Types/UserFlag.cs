using ApologistAiApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

/// <summary>
/// A team-level user flag definition from the user_flags table.
/// </summary>
[Serializable]
public record UserFlag : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Upstream owning user id when present (mirrored from Ignite).
    /// </summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    [JsonPropertyName("team_id")]
    public int? TeamId { get; set; }

    [JsonPropertyName("synced_at")]
    public string? SyncedAt { get; set; }

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
