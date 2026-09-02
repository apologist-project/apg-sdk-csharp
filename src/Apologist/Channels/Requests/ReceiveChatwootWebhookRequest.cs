using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ReceiveChatwootWebhookRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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
    /// Chatwoot Agent Bot webhook payload (`event` plus message or conversation fields).
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
