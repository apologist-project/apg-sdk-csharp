using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ChatwootWebhookPayload
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string ChannelId { get; set; }

    /// <summary>
    /// `sha256=` plus hex HMAC-SHA256 of `{timestamp}.{rawBody}` keyed with the Agent Bot webhook secret. Required when the webhook URL does not include an api_key, and whenever a webhook secret is configured.
    /// </summary>
    [JsonIgnore]
    public string? ChatwootSignature { get; set; }

    /// <summary>
    /// Unix timestamp used in the HMAC payload.
    /// </summary>
    [JsonIgnore]
    public string? ChatwootTimestamp { get; set; }

    /// <summary>
    /// Chatwoot event name. Incoming visitor messages use `message_created`. Staff takeover and assignment use conversation events such as `conversation_opened`, `conversation_status_changed`, and `conversation_updated`.
    /// </summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// Message id on `message_*` events. Conversation display id on `conversation_*` events.
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Message text. Present on message events. Empty or private notes are ignored.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// Incoming visitor messages are `incoming` (or `0`). Staff replies are `outgoing` (or `1`).
    /// </summary>
    [JsonPropertyName("message_type")]
    public string? MessageType { get; set; }

    /// <summary>
    /// When true, the Agent ignores the message (Chatwoot private note).
    /// </summary>
    [JsonPropertyName("private")]
    public bool? Private { get; set; }

    [JsonPropertyName("account")]
    public ChatwootWebhookPayloadAccount? Account { get; set; }

    /// <summary>
    /// Present on message events.
    /// </summary>
    [JsonPropertyName("sender")]
    public ChatwootWebhookPayloadSender? Sender { get; set; }

    /// <summary>
    /// Nested on message events. Conversation events send `id`, `status`, and `meta` at the top level instead.
    /// </summary>
    [JsonPropertyName("conversation")]
    public ChatwootWebhookPayloadConversation? Conversation { get; set; }

    /// <summary>
    /// Top-level conversation status on conversation events.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Top-level conversation meta on conversation events.
    /// </summary>
    [JsonPropertyName("meta")]
    public ChatwootConversationMeta? Meta { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
