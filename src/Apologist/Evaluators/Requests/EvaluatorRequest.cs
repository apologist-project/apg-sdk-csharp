using Apologist.Core;
using global::System.Text.Json.Serialization;
using OneOf;

namespace Apologist;

[Serializable]
public record EvaluatorRequest
{
    /// <summary>
    /// The ID or key of the evaluator
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("frequency_penalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("confidence_threshold")]
    public double? ConfidenceThreshold { get; set; }

    [JsonPropertyName("content")]
    public required OneOf<string, IEnumerable<object>> Content { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("presence_penalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("reasoning_effort")]
    public EvaluatorRequestReasoningEffort? ReasoningEffort { get; set; }

    [JsonPropertyName("verbosity")]
    public EvaluatorRequestVerbosity? Verbosity { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("top_p")]
    public double? TopP { get; set; }

    /// <summary>
    /// Flat string key/value pairs substituted into `{key}` placeholders in the evaluator prompt. Reserved keys (`options`, `option_descriptions`, `criteria`) cannot be overridden. Not persisted; omitted from the response.
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, string?>? Variables { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
