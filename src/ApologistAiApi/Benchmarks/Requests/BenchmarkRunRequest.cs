using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;
using OneOf;

namespace ApologistAiApi;

[Serializable]
public record BenchmarkRunRequest
{
    /// <summary>
    /// The id or key of the benchmark
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Content to evaluate. Required when `source_id` is supplied.
    /// </summary>
    [JsonPropertyName("content")]
    public OneOf<string?, IEnumerable<object>?>? Content { get; set; }

    /// <summary>
    /// Completion UUID whose stored response should be evaluated.
    /// </summary>
    [JsonPropertyName("completion_id")]
    public string? CompletionId { get; set; }

    [JsonPropertyName("source_id")]
    public int? SourceId { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("num_responses")]
    public int? NumResponses { get; set; }

    [JsonPropertyName("use_question_variants")]
    public bool? UseQuestionVariants { get; set; }

    [JsonPropertyName("reasoning_effort")]
    public BenchmarkRunRequestReasoningEffort? ReasoningEffort { get; set; }

    [JsonPropertyName("verbosity")]
    public BenchmarkRunRequestVerbosity? Verbosity { get; set; }

    [JsonPropertyName("score_threshold")]
    public double? ScoreThreshold { get; set; }

    [JsonPropertyName("value_threshold")]
    public double? ValueThreshold { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("top_p")]
    public double? TopP { get; set; }

    [JsonPropertyName("frequency_penalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("presence_penalty")]
    public double? PresencePenalty { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
