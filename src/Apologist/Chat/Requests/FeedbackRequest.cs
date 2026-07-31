using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record FeedbackRequest
{
    /// <summary>
    /// The ID of the chat completion
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("feedback")]
    public required string Feedback { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
