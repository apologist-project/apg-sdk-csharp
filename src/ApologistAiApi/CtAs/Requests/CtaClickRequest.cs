using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record CtaClickRequest
{
    /// <summary>
    /// The ID of the CTA
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("prompt_id")]
    public required string PromptId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
