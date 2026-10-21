using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ViewRequest
{
    /// <summary>
    /// Listing model. One of collection, contributor, organization, or source.
    /// </summary>
    [JsonIgnore]
    public required string Model { get; set; }

    /// <summary>
    /// The ID of the corpus item
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("prompt_id")]
    public required string PromptId { get; set; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
