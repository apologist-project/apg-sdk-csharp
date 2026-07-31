using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record ReferralRequest
{
    /// <summary>
    /// The model type (e.g., 'source')
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
