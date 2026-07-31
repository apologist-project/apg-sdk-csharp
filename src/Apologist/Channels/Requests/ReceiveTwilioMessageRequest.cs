using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ReceiveTwilioMessageRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("From")]
    public string? From { get; set; }

    [JsonPropertyName("Body")]
    public string? Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
