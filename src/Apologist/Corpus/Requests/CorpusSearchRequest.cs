using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record CorpusSearchRequest
{
    [JsonPropertyName("query")]
    public required string Query { get; set; }

    [JsonPropertyName("prompt_id")]
    public string? PromptId { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("filters")]
    public CorpusSearchRequestFilters? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
