using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// Nested on message events. Conversation events send `id`, `status`, and `meta` at the top level instead.
/// </summary>
[Serializable]
public record ChatwootWebhookPayloadConversation : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    /// <summary>
    /// Conversation display id.
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// `pending`, `open`, `resolved`, or `snoozed`.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("account")]
    public ChatwootWebhookPayloadConversationAccount? Account { get; set; }

    [JsonPropertyName("meta")]
    public ChatwootConversationMeta? Meta { get; set; }

    [JsonIgnore]
    public AdditionalProperties AdditionalProperties { get; set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    void IJsonOnSerializing.OnSerializing() =>
        AdditionalProperties.CopyToExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
