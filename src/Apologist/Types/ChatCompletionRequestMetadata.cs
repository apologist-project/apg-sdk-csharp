using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ChatCompletionRequestMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("anonymous")]
    public bool? Anonymous { get; set; }

    [JsonPropertyName("conversation")]
    public string? Conversation { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("max_memories")]
    public int? MaxMemories { get; set; }

    [JsonPropertyName("parent_url")]
    public string? ParentUrl { get; set; }

    [JsonPropertyName("parent_host")]
    public string? ParentHost { get; set; }

    [JsonPropertyName("session")]
    public string? Session { get; set; }

    [JsonPropertyName("device")]
    public string? Device { get; set; }

    /// <summary>
    /// Acquisition / campaign referral code stored on the user first-write-wins. Empty values are ignored; an existing user referral_code is never overwritten. The Agent UI maps ?ref=, then ?referral_code=, then ?utm_campaign= into this field.
    /// </summary>
    [JsonPropertyName("referral_code")]
    public string? ReferralCode { get; set; }

    [JsonPropertyName("shared_prompt")]
    public int? SharedPrompt { get; set; }

    [JsonPropertyName("translation")]
    public string? Translation { get; set; }

    /// <summary>
    /// String key/value pairs substituted into `{key}` placeholders in the assembled system prompt. Never persisted; omitted from response metadata. Reserved system keys (language, bible, translation, passages, date/geo tokens) cannot be overridden.
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, string?>? Variables { get; set; }

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
