using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record User : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Internal user id (UUID).
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// First-write-wins acquisition / campaign referral code.
    /// </summary>
    [JsonPropertyName("referral_code")]
    public string? ReferralCode { get; set; }

    [JsonPropertyName("team_id")]
    public int? TeamId { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("migrated_at")]
    public string? MigratedAt { get; set; }

    [JsonPropertyName("migrated_to_user_id")]
    public string? MigratedToUserId { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<TagRef>? Tags { get; set; }

    [JsonPropertyName("responder_id")]
    public int? ResponderId { get; set; }

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
