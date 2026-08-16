using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ReceiveLineWebhookRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Base64-encoded HMAC-SHA256 of the raw body keyed with the LINE channel secret. Required when the webhook URL does not include an api_key.
    /// </summary>
    [JsonIgnore]
    public string? LineSignature { get; set; }

    /// <summary>
    /// LINE webhook payload (`destination` + `events`).
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
