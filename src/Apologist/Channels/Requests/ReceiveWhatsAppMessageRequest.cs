using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ReceiveWhatsAppMessageRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Meta `sha256=&lt;hex&gt;` HMAC of the raw body keyed with the WhatsApp App Secret. Required when the channel has an App Secret configured and the webhook URL does not include an api_key.
    /// </summary>
    [JsonIgnore]
    public string? HubSignature256 { get; set; }

    /// <summary>
    /// WhatsApp Cloud API webhook payload (`entry` + `changes`).
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
