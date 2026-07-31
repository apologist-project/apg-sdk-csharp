using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record FlagRequest
{
    /// <summary>
    /// The ID of the chat completion
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("flagged")]
    public required bool Flagged { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
