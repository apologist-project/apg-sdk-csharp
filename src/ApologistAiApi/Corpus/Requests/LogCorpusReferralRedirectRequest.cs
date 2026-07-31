using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record LogCorpusReferralRedirectRequest
{
    /// <summary>
    /// The model type (e.g., 'source')
    /// </summary>
    [JsonIgnore]
    public required string Model { get; set; }

    /// <summary>
    /// The numeric ID of the corpus item
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonIgnore]
    public required string PromptId { get; set; }

    [JsonIgnore]
    public string? UserId { get; set; }

    /// <summary>
    /// URL-encoded destination to redirect to after logging the referral.
    /// </summary>
    [JsonIgnore]
    public string? Url { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
